namespace XML_Mgr
{
    partial class Mgr
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Build = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.Floder_Select_Dlg = new System.Windows.Forms.FolderBrowserDialog();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.TreeDisk = new System.Windows.Forms.TreeView();
            this.ContextMenuStrip_Disk = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Flash = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Rename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Prop = new System.Windows.Forms.ToolStripMenuItem();
            this.BT_DTree_Del = new System.Windows.Forms.Button();
            this.BT_DTree_Add = new System.Windows.Forms.Button();
            this.TreeV = new System.Windows.Forms.TreeView();
            this.MenuItem_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.ContextMenuStrip_Disk.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File,
            this.ToolStripMenuItem_Info});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(322, 24);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "Menu";
            // 
            // ToolStripMenuItem_File
            // 
            this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Open,
            this.MenuItem_Build,
            this.MenuItem_Update,
            this.toolStripSeparator1,
            this.MenuItem_Exit});
            this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            this.ToolStripMenuItem_File.ShortcutKeyDisplayString = "F";
            this.ToolStripMenuItem_File.Size = new System.Drawing.Size(37, 20);
            this.ToolStripMenuItem_File.Text = "&File";
            // 
            // MenuItem_Open
            // 
            this.MenuItem_Open.Name = "MenuItem_Open";
            this.MenuItem_Open.ShortcutKeyDisplayString = "";
            this.MenuItem_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuItem_Open.Size = new System.Drawing.Size(154, 22);
            this.MenuItem_Open.Text = "&Open";
            this.MenuItem_Open.Click += new System.EventHandler(this.MenuItem_Open_Click);
            // 
            // MenuItem_Build
            // 
            this.MenuItem_Build.Name = "MenuItem_Build";
            this.MenuItem_Build.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.MenuItem_Build.Size = new System.Drawing.Size(154, 22);
            this.MenuItem_Build.Text = "&Build";
            this.MenuItem_Build.Click += new System.EventHandler(this.MenuItem_Build_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.Name = "MenuItem_Exit";
            this.MenuItem_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.MenuItem_Exit.Size = new System.Drawing.Size(154, 22);
            this.MenuItem_Exit.Text = "E&xit";
            this.MenuItem_Exit.Click += new System.EventHandler(this.MenuItem_Exit_Click);
            // 
            // ToolStripMenuItem_Info
            // 
            this.ToolStripMenuItem_Info.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_About});
            this.ToolStripMenuItem_Info.Name = "ToolStripMenuItem_Info";
            this.ToolStripMenuItem_Info.Size = new System.Drawing.Size(40, 20);
            this.ToolStripMenuItem_Info.Text = "&Info";
            // 
            // MenuItem_About
            // 
            this.MenuItem_About.Name = "MenuItem_About";
            this.MenuItem_About.Size = new System.Drawing.Size(107, 22);
            this.MenuItem_About.Text = "&About";
            this.MenuItem_About.Click += new System.EventHandler(this.MenuItem_About_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1,
            this.StatusLabel2});
            this.StatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.StatusStrip.Location = new System.Drawing.Point(0, 339);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(322, 22);
            this.StatusStrip.TabIndex = 4;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(60, 17);
            this.StatusLabel1.Text = "Welcome!";
            // 
            // StatusLabel2
            // 
            this.StatusLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.StatusLabel2.Name = "StatusLabel2";
            this.StatusLabel2.Size = new System.Drawing.Size(22, 17);
            this.StatusLabel2.Text = "     ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TreeV);
            this.splitContainer1.Size = new System.Drawing.Size(322, 315);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.TreeDisk);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.BT_DTree_Del);
            this.splitContainer2.Panel2.Controls.Add(this.BT_DTree_Add);
            this.splitContainer2.Size = new System.Drawing.Size(110, 315);
            this.splitContainer2.SplitterDistance = 250;
            this.splitContainer2.TabIndex = 1;
            // 
            // TreeDisk
            // 
            this.TreeDisk.ContextMenuStrip = this.ContextMenuStrip_Disk;
            this.TreeDisk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeDisk.Location = new System.Drawing.Point(0, 0);
            this.TreeDisk.Name = "TreeDisk";
            this.TreeDisk.Size = new System.Drawing.Size(110, 250);
            this.TreeDisk.TabIndex = 1;
            // 
            // ContextMenuStrip_Disk
            // 
            this.ContextMenuStrip_Disk.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Open,
            this.ToolStripMenuItem_Flash,
            this.toolStripSeparator9,
            this.ToolStripMenuItem_Copy,
            this.ToolStripMenuItem_Cut,
            this.ToolStripMenuItem_Paste,
            this.ToolStripMenuItem_Del,
            this.ToolStripMenuItem_Rename,
            this.toolStripSeparator10,
            this.ToolStripMenuItem_Prop});
            this.ContextMenuStrip_Disk.Name = "contextMenuStrip1";
            this.ContextMenuStrip_Disk.Size = new System.Drawing.Size(141, 192);
            // 
            // ToolStripMenuItem_Open
            // 
            this.ToolStripMenuItem_Open.Name = "ToolStripMenuItem_Open";
            this.ToolStripMenuItem_Open.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItem_Open.Text = "打开(&O)";
            // 
            // ToolStripMenuItem_Flash
            // 
            this.ToolStripMenuItem_Flash.Name = "ToolStripMenuItem_Flash";
            this.ToolStripMenuItem_Flash.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItem_Flash.Text = "刷新";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(137, 6);
            // 
            // ToolStripMenuItem_Copy
            // 
            this.ToolStripMenuItem_Copy.Name = "ToolStripMenuItem_Copy";
            this.ToolStripMenuItem_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.ToolStripMenuItem_Copy.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItem_Copy.Text = "复制";
            // 
            // ToolStripMenuItem_Cut
            // 
            this.ToolStripMenuItem_Cut.Name = "ToolStripMenuItem_Cut";
            this.ToolStripMenuItem_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.ToolStripMenuItem_Cut.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItem_Cut.Text = "剪切";
            // 
            // ToolStripMenuItem_Paste
            // 
            this.ToolStripMenuItem_Paste.Name = "ToolStripMenuItem_Paste";
            this.ToolStripMenuItem_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.ToolStripMenuItem_Paste.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItem_Paste.Text = "粘贴";
            // 
            // ToolStripMenuItem_Del
            // 
            this.ToolStripMenuItem_Del.Name = "ToolStripMenuItem_Del";
            this.ToolStripMenuItem_Del.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItem_Del.Text = "删除(&D)";
            // 
            // ToolStripMenuItem_Rename
            // 
            this.ToolStripMenuItem_Rename.Name = "ToolStripMenuItem_Rename";
            this.ToolStripMenuItem_Rename.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItem_Rename.Text = "重命名(&M)";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(137, 6);
            // 
            // ToolStripMenuItem_Prop
            // 
            this.ToolStripMenuItem_Prop.Name = "ToolStripMenuItem_Prop";
            this.ToolStripMenuItem_Prop.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItem_Prop.Text = "属性(&R)";
            // 
            // BT_DTree_Del
            // 
            this.BT_DTree_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_DTree_Del.Location = new System.Drawing.Point(0, 22);
            this.BT_DTree_Del.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.BT_DTree_Del.Name = "BT_DTree_Del";
            this.BT_DTree_Del.Size = new System.Drawing.Size(110, 20);
            this.BT_DTree_Del.TabIndex = 1;
            this.BT_DTree_Del.Text = "Del";
            this.BT_DTree_Del.UseVisualStyleBackColor = true;
            this.BT_DTree_Del.Click += new System.EventHandler(this.BT_DTree_Del_Click);
            // 
            // BT_DTree_Add
            // 
            this.BT_DTree_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_DTree_Add.Location = new System.Drawing.Point(0, 2);
            this.BT_DTree_Add.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.BT_DTree_Add.Name = "BT_DTree_Add";
            this.BT_DTree_Add.Size = new System.Drawing.Size(110, 20);
            this.BT_DTree_Add.TabIndex = 0;
            this.BT_DTree_Add.Text = "Add";
            this.BT_DTree_Add.UseVisualStyleBackColor = true;
            this.BT_DTree_Add.Click += new System.EventHandler(this.BT_DTree_Add_Click);
            // 
            // TreeV
            // 
            this.TreeV.ContextMenuStrip = this.ContextMenuStrip_Disk;
            this.TreeV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeV.Location = new System.Drawing.Point(0, 0);
            this.TreeV.Name = "TreeV";
            this.TreeV.Size = new System.Drawing.Size(208, 315);
            this.TreeV.TabIndex = 5;
            this.TreeV.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeV_BeforeExpand);
            this.TreeV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeV_AfterSelect);
            // 
            // MenuItem_Update
            // 
            this.MenuItem_Update.Name = "MenuItem_Update";
            this.MenuItem_Update.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.MenuItem_Update.Size = new System.Drawing.Size(154, 22);
            this.MenuItem_Update.Text = "&Update";
            this.MenuItem_Update.Click += new System.EventHandler(this.MenuItem_Update_Click);
            // 
            // Mgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 361);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.StatusStrip);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "Mgr";
            this.Text = "Mgr";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ContextMenuStrip_Disk.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Build;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Info;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_About;
        private System.Windows.Forms.FolderBrowserDialog Floder_Select_Dlg;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView TreeV;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_Disk;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Flash;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Copy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Cut;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Paste;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Del;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Rename;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Prop;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView TreeDisk;
        private System.Windows.Forms.Button BT_DTree_Del;
        private System.Windows.Forms.Button BT_DTree_Add;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Update;

    }
}

