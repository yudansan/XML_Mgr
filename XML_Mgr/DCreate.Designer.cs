namespace XML_Mgr
{
    partial class DCreate
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
            this.ComboBox_DCreate = new System.Windows.Forms.ComboBox();
            this.BT_DCreate_Ok = new System.Windows.Forms.Button();
            this.BT_DCreate_Cancle = new System.Windows.Forms.Button();
            this.TextBox_DCreate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComboBox_DCreate
            // 
            this.ComboBox_DCreate.FormattingEnabled = true;
            this.ComboBox_DCreate.Location = new System.Drawing.Point(12, 12);
            this.ComboBox_DCreate.Name = "ComboBox_DCreate";
            this.ComboBox_DCreate.Size = new System.Drawing.Size(100, 20);
            this.ComboBox_DCreate.TabIndex = 0;
            // 
            // BT_DCreate_Ok
            // 
            this.BT_DCreate_Ok.Location = new System.Drawing.Point(151, 10);
            this.BT_DCreate_Ok.Name = "BT_DCreate_Ok";
            this.BT_DCreate_Ok.Size = new System.Drawing.Size(75, 23);
            this.BT_DCreate_Ok.TabIndex = 1;
            this.BT_DCreate_Ok.Text = "Ok";
            this.BT_DCreate_Ok.UseVisualStyleBackColor = true;
            this.BT_DCreate_Ok.Click += new System.EventHandler(this.BT_DCreate_Ok_Click);
            // 
            // BT_DCreate_Cancle
            // 
            this.BT_DCreate_Cancle.Location = new System.Drawing.Point(151, 36);
            this.BT_DCreate_Cancle.Name = "BT_DCreate_Cancle";
            this.BT_DCreate_Cancle.Size = new System.Drawing.Size(75, 23);
            this.BT_DCreate_Cancle.TabIndex = 2;
            this.BT_DCreate_Cancle.Text = "Cancle";
            this.BT_DCreate_Cancle.UseVisualStyleBackColor = true;
            this.BT_DCreate_Cancle.Click += new System.EventHandler(this.BT_DCreate_Cancle_Click);
            // 
            // TextBox_DCreate
            // 
            this.TextBox_DCreate.Location = new System.Drawing.Point(12, 38);
            this.TextBox_DCreate.Name = "TextBox_DCreate";
            this.TextBox_DCreate.Size = new System.Drawing.Size(100, 21);
            this.TextBox_DCreate.TabIndex = 3;
            // 
            // DCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 69);
            this.Controls.Add(this.TextBox_DCreate);
            this.Controls.Add(this.BT_DCreate_Cancle);
            this.Controls.Add(this.BT_DCreate_Ok);
            this.Controls.Add(this.ComboBox_DCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_DCreate;
        private System.Windows.Forms.Button BT_DCreate_Ok;
        private System.Windows.Forms.Button BT_DCreate_Cancle;
        private System.Windows.Forms.TextBox TextBox_DCreate;
    }
}