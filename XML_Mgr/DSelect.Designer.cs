namespace XML_Mgr
{
    partial class DSelect
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_DSelect_Creat = new System.Windows.Forms.Button();
            this.BT_DSelect_Cancel = new System.Windows.Forms.Button();
            this.BT_DSelect_Ok = new System.Windows.Forms.Button();
            this.ComboBox_DSelect = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BT_DSelect_Creat);
            this.panel1.Controls.Add(this.BT_DSelect_Cancel);
            this.panel1.Controls.Add(this.BT_DSelect_Ok);
            this.panel1.Controls.Add(this.ComboBox_DSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 71);
            this.panel1.TabIndex = 0;
            // 
            // BT_DSelect_Creat
            // 
            this.BT_DSelect_Creat.Enabled = false;
            this.BT_DSelect_Creat.Location = new System.Drawing.Point(107, 38);
            this.BT_DSelect_Creat.Name = "BT_DSelect_Creat";
            this.BT_DSelect_Creat.Size = new System.Drawing.Size(75, 23);
            this.BT_DSelect_Creat.TabIndex = 3;
            this.BT_DSelect_Creat.Text = "Creat";
            this.BT_DSelect_Creat.UseVisualStyleBackColor = true;
            this.BT_DSelect_Creat.Click += new System.EventHandler(this.BT_DSelect_Creat_Click);
            // 
            // BT_DSelect_Cancel
            // 
            this.BT_DSelect_Cancel.Location = new System.Drawing.Point(188, 39);
            this.BT_DSelect_Cancel.Name = "BT_DSelect_Cancel";
            this.BT_DSelect_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BT_DSelect_Cancel.TabIndex = 2;
            this.BT_DSelect_Cancel.Text = "Cancel";
            this.BT_DSelect_Cancel.UseVisualStyleBackColor = true;
            this.BT_DSelect_Cancel.Click += new System.EventHandler(this.BT_DSelect_Cancel_Click);
            // 
            // BT_DSelect_Ok
            // 
            this.BT_DSelect_Ok.Location = new System.Drawing.Point(188, 10);
            this.BT_DSelect_Ok.Name = "BT_DSelect_Ok";
            this.BT_DSelect_Ok.Size = new System.Drawing.Size(75, 23);
            this.BT_DSelect_Ok.TabIndex = 1;
            this.BT_DSelect_Ok.Text = "OK";
            this.BT_DSelect_Ok.UseVisualStyleBackColor = true;
            this.BT_DSelect_Ok.Click += new System.EventHandler(this.BT_DSelect_Ok_Click);
            // 
            // ComboBox_DSelect
            // 
            this.ComboBox_DSelect.FormattingEnabled = true;
            this.ComboBox_DSelect.Location = new System.Drawing.Point(12, 12);
            this.ComboBox_DSelect.Name = "ComboBox_DSelect";
            this.ComboBox_DSelect.Size = new System.Drawing.Size(170, 20);
            this.ComboBox_DSelect.TabIndex = 0;
            // 
            // DSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 71);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DSelect";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_DSelect_Creat;
        private System.Windows.Forms.Button BT_DSelect_Cancel;
        private System.Windows.Forms.Button BT_DSelect_Ok;
        private System.Windows.Forms.ComboBox ComboBox_DSelect;
    }
}