namespace pgServerCopy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBoxServers = new System.Windows.Forms.CheckedListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonToggleSelectAll = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.checkBoxColors = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkedListBoxServers
            // 
            this.checkedListBoxServers.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxServers.FormattingEnabled = true;
            this.checkedListBoxServers.HorizontalScrollbar = true;
            this.checkedListBoxServers.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxServers.Name = "checkedListBoxServers";
            this.checkedListBoxServers.Size = new System.Drawing.Size(661, 394);
            this.checkedListBoxServers.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.Location = new System.Drawing.Point(512, 412);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(160, 37);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonToggleSelectAll
            // 
            this.buttonToggleSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonToggleSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonToggleSelectAll.Location = new System.Drawing.Point(12, 412);
            this.buttonToggleSelectAll.Name = "buttonToggleSelectAll";
            this.buttonToggleSelectAll.Size = new System.Drawing.Size(160, 37);
            this.buttonToggleSelectAll.TabIndex = 2;
            this.buttonToggleSelectAll.Text = "deselect / select all";
            this.buttonToggleSelectAll.UseVisualStyleBackColor = true;
            this.buttonToggleSelectAll.Click += new System.EventHandler(this.ButtonToggleSelectAll_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCopy.Location = new System.Drawing.Point(345, 412);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(160, 37);
            this.buttonCopy.TabIndex = 3;
            this.buttonCopy.Text = "copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // checkBoxColors
            // 
            this.checkBoxColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxColors.Location = new System.Drawing.Point(185, 421);
            this.checkBoxColors.Name = "checkBoxColors";
            this.checkBoxColors.Size = new System.Drawing.Size(156, 20);
            this.checkBoxColors.TabIndex = 4;
            this.checkBoxColors.Text = "background colors";
            this.checkBoxColors.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 454);
            this.Controls.Add(this.checkBoxColors);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonToggleSelectAll);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.checkedListBoxServers);
            this.Name = "Form1";
            this.Text = "Copy servers from pgAdmin III to pgAdmin 4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxServers;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonToggleSelectAll;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.CheckBox checkBoxColors;
    }
}

