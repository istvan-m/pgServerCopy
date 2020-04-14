using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pgServerCopy
{
    public partial class Form1 : Form
    {
        private readonly RegistryKey rk = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("pgAdmin III").OpenSubKey("Servers");

        public Form1()
        {
            InitializeComponent();

            checkedListBoxServers.Items.AddRange(GetServers(rk).ToArray());
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static List<ServerItem> GetServers(RegistryKey rkey)
        {
            String[] names = rkey.GetSubKeyNames();
            List<ServerItem> ret = new List<ServerItem>();

            foreach (String s in names)
            {
                RegistryKey serverkey = rkey.OpenSubKey(s);

                string color = (string)serverkey.GetValue("Colour");
                string name = (string)serverkey.GetValue("Description");
                int port = (int)serverkey.GetValue("Port");
                string host = (string)serverkey.GetValue("Server");
                string username = (string)serverkey.GetValue("Username");

                ret.Add(new ServerItem(name , host, port, username, color));                
            }

            return ret;
        }

        private void ButtonToggleSelectAll_Click(object sender, EventArgs e)
        {
            bool goingToCheck = checkedListBoxServers.CheckedItems.Count == 0;
            for (int i = 0; i < checkedListBoxServers.Items.Count; i++)
            {
                checkedListBoxServers.SetItemChecked(i, goingToCheck);
            }
        }

        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            string connectionString = @"URI=file:" + Environment.ExpandEnvironmentVariables("%AppData%") + "\\pgAdmin\\pgadmin4.db";
            SQLiteConnection con = new SQLiteConnection(connectionString);
            con.Open();

            string stm = "INSERT INTO server (user_id, servergroup_id, name, host, port, maintenance_db, username, ssl_mode, connect_timeout, bgcolor, fgcolor) "
                + " VALUES (1, 1, @name, @host, @port, 'postgres', @username, 'prefer', 10, @bgcolor, @fgcolor);";
            SQLiteCommand cmd = new SQLiteCommand(stm, con);
            cmd.Prepare();

            foreach (ServerItem serverItem in checkedListBoxServers.CheckedItems)
            {
                cmd.Parameters.AddWithValue("@name", serverItem.Name);
                cmd.Parameters.AddWithValue("@host", serverItem.Host);
                cmd.Parameters.AddWithValue("@port", serverItem.Port);
                cmd.Parameters.AddWithValue("@username", serverItem.Username);
                cmd.Parameters.AddWithValue("@bgcolor", serverItem.Color.Equals("#FFFFFF") || !checkBoxColors.Checked ? DBNull.Value : (object)serverItem.Color);
                cmd.Parameters.AddWithValue("@fgcolor", serverItem.Color.Equals("#FFFFFF") || !checkBoxColors.Checked ? DBNull.Value : IsBright(serverItem.Color) ? (object)"#222222" : (object)"#D4D4D4");
                cmd.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show(String.Format("Servers copied to pgAdmin4: {0}", checkedListBoxServers.CheckedItems.Count), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsBright(string color)
        {
            bool ret = false;
            Regex rgx = new Regex(@"^.[a-fA-F0-9]{6,}$");
            if (rgx.IsMatch(color))
            {
                string hexr = color.Substring(1, 2).ToUpper();
                string hexg = color.Substring(3, 2).ToUpper();
                string hexb = color.Substring(5, 2).ToUpper();
                int brightness = Int32.Parse(hexr, System.Globalization.NumberStyles.HexNumber)
                    + Int32.Parse(hexg, System.Globalization.NumberStyles.HexNumber)
                    + Int32.Parse(hexb, System.Globalization.NumberStyles.HexNumber);
                ret = brightness > 382.5;
            }
            return ret;
        }
    }
}
