using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgServerCopy
{
    class ServerItem
    {
        private string color;
        private string name;
        private int port;
        private string host;
        private string username;

        public string Color { get => color; set => color = value; }
        public string Name { get => name; set => name = value; }
        public int Port { get => port; set => port = value; }
        public string Host { get => host; set => host = value; }
        public string Username { get => username; set => username = value; }

        public override string ToString()
        {
            return $"{Username,-12} {Host,15} : {Port,-6} {Name}";
        }

        public ServerItem(string name, string host, int port, string username, string color) 
        {
            this.color = color;
            this.name = name;
            this.port = port;
            this.host = host;
            this.username = username;
        }
    }
}
