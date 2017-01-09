using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace XML_Mgr
{
    public partial class Mgr : Form
    {
        private static DirectoryInfo Select_Dir;
        private static DriveInfo Select_Dri;
        //private static FileInfo Select_File;
        private string Select_Floder;
        private IniFiles Config_INI;
        private string GL_XML_Name = Application.StartupPath + @"\XML\GL.xml";
        private string DS_ID = "";

        public Mgr()
        {
            XML_Mgr_Load();
            InitializeComponent();
            //Setfont();
            Init_Tree_Disk();
        }

        #region Init_Func

        private void Setfont()
        {
            string AppPath = Application.StartupPath;
            try
            {
                PrivateFontCollection font = new PrivateFontCollection();
                font.AddFontFile(AppPath + @"\Font\方正水柱_GBK.ttf");//字体的路径及名字 
                Font myFont = new Font(font.Families[0].Name, 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                //设置窗体控件字体，哪些控件要更改都写到下面
                //this.ListView.Font = myFont;
                //this.Menu.Font = myFont;
                this.Font = myFont;
            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //private void XML_Mgr_Load(object sender, EventArgs e)
        private void XML_Mgr_Load()
        {
            try
            {
                // 读取ini
                string INI_Name = Application.StartupPath + @"\config.ini";
                FileInfo fileInfo = new FileInfo(INI_Name);
                if ((!fileInfo.Exists))
                {
                    Config_INI = new IniFiles(Application.StartupPath + @"\config.ini");
                    Config_INI.WriteString("Global", "Path", "NULL");
                    Config_INI.WriteString("XML", "XML_Build_Path", Application.StartupPath + @"\XML");

                    CLog.Info("Initial INI");
                }
                else
                {
                    Config_INI = new IniFiles(Application.StartupPath + @"\config.ini");
                    Config_INI.WriteString("XML", "XML_Build_Path", Application.StartupPath + @"\XML");
                }

                DirectoryInfo SAVE_Dir = new DirectoryInfo(Config_INI.ReadString("XML", "XML_Build_Path", ""));
                if ((!SAVE_Dir.Exists))
                    Directory.CreateDirectory(Config_INI.ReadString("XML", "XML_Build_Path", ""));

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("ERROR 100 :\nGet INI failed!");
                this.Close();
            }
        }

        private void Init_Tree_Disk()
        {
            TreeDisk.Nodes.Clear();
            //TreeNode root = new TreeNode("Disk");

            FileInfo fileInfo = new FileInfo(GL_XML_Name);
            if ((!fileInfo.Exists))
            {
                XElement GL_XML = new XElement("root", new XAttribute("Name", "GL"), new XAttribute("Count", 0), new XAttribute("Update", System.DateTime.Now.ToString()));
                GL_XML.Save(GL_XML_Name);

                CLog.Info("Create GL_XML");

                XDocument XDoc = XDocument.Load(GL_XML_Name);
                this.TreeDisk.Nodes.AddRange(XDoc.Elements().ToTreeNode().ToArray());
            }
            else
            {
                XDocument XDoc = XDocument.Load(GL_XML_Name);
                this.TreeDisk.Nodes.AddRange(XDoc.Elements().ToTreeNode().ToArray());
            }
        }

        #endregion

        #region Menu

        private void MenuItem_Open_Click(object sender, EventArgs e)
        {
            Floder_Select_Dlg.ShowDialog();
            Select_Floder = Floder_Select_Dlg.SelectedPath;
            Console.WriteLine(Select_Floder);
            this.StatusLabel1.Text = Select_Floder;
            if (Select_Floder != null && Select_Floder != "")
            {
                TreeV.Nodes.Clear();
                DirectoryInfo tmp = new DirectoryInfo(Select_Floder);
                if (tmp.ToString() == tmp.Root.ToString())
                {
                    TreeNode root = new TreeNode(tmp.Root.Name);
                    TreeV.Nodes.Add(root);
                    Traverse(root, tmp.Root);
                    this.StatusLabel2.Text = "List.";
                }
                else
                {
                    TreeNode root = new TreeNode(tmp.Name);
                    TreeV.Nodes.Add(root);
                    Traverse(root, tmp);
                    this.StatusLabel2.Text = "List.";
                }
            }
        }

        private void MenuItem_Build_Click(object sender, EventArgs e)
        {
            if (Select_Floder != null && Select_Floder != "")
            {
                //2014.2.1 Add
                DSelect DSForm = new DSelect(this.TreeDisk);
                DSForm.Owner = this;
                DSForm.ShowDialog();

                Select_Dir = new DirectoryInfo(Select_Floder);

                if (Select_Dir.ToString() == Select_Dir.Root.ToString())
                {
                    //2014.2.2 Modified
                    Build_By_Id(Select_Dir, DS_ID);
                //    Console.WriteLine("It is a Driver!");
                //    Select_Dri = new DriveInfo(Select_Dir.Root.Name);
                //    XElement dirXml = Select_Dri.LToXml();//显示所有文件
                //    string XML_Name = DS_ID + "#" + Select_Dri.VolumeLabel + /* "#" + Select_Dri.Name.Substring(0, 1) + */ "(" + (Select_Dri.TotalSize / 1024 / 1024 / 1024).ToString() + "G)";
                //    string XML_Path = Config_INI.ReadString("XML", "XML_Build_Path", "");
                //    if (XML_Path == null || XML_Path == "")
                //    {
                //        MessageBox.Show("ERROR 101 :\nDO NOT Find XML_Build_Path in XML!");
                //        return;
                //    }
                //    string XML_FullPath = XML_Path + @"\" + XML_Name + @".xml";
                //    if (File.Exists(XML_FullPath))
                //    {
                //        //Make Backup
                //        DirectoryInfo SAVE_Dir = new DirectoryInfo(Config_INI.ReadString("XML", "XML_Build_Path", "") + @"\BackUp");
                //        if ((!SAVE_Dir.Exists))
                //            Directory.CreateDirectory(Config_INI.ReadString("XML", "XML_Build_Path", "") + @"\BackUp");
                //        FileInfo fileInfo = new FileInfo(XML_FullPath);
                //        FileInfo fileBack = new FileInfo(Config_INI.ReadString("XML", "XML_Build_Path", "") + @"\BackUp" + @"\" + XML_Name + @".xml");
                //        if (fileInfo.Exists)
                //        {
                //            if (fileBack.Exists)
                //                fileBack.Delete();
                //            fileInfo.MoveTo(Config_INI.ReadString("XML", "XML_Build_Path", "") + @"\BackUp" + @"\" + XML_Name + @".xml");
                //        }

                //        //MessageBox.Show("Existed!So Rewrite!");
                //        this.StatusLabel1.Text = "Existed!So Rewrite.";
                //        File.Delete(XML_FullPath);
                //        dirXml.Save(XML_FullPath);
                //        this.StatusLabel2.Text = "Created.(Driver)";

                //        CLog.Info("Update " + XML_Name + " # Used " + ((Select_Dri.TotalSize - Select_Dri.TotalFreeSpace) / 1024 / 1024 / 1024).ToString() + "G # " +
                //           "Total " + (Select_Dri.TotalSize / 1024 / 1024 / 1024).ToString() + "G");
                //    }
                //    else
                //    {
                //        dirXml.Save(XML_FullPath);
                //        this.StatusLabel2.Text = "Created.(Driver)";

                //        CLog.Info("Create " + XML_Name + " # Used " + ((Select_Dri.TotalSize - Select_Dri.TotalFreeSpace) / 1024 / 1024 / 1024).ToString() + "G # " +
                //           "Total " + (Select_Dri.TotalSize / 1024 / 1024 / 1024).ToString() + "G");
                //    }

                //    //2014.2.1 Add
                //    XmlDocument doc = new XmlDocument();
                //    doc.Load(GL_XML_Name);
                //    //指定一个节点
                //    XmlElement root = doc.DocumentElement;
                //    foreach (XmlElement tn in root.ChildNodes)
                //    {
                //        if (tn.GetAttribute("ID") == DS_ID)
                //        {
                //            tn.SetAttribute("Name", XML_Name);
                //            tn.SetAttribute("Used", ((Select_Dri.TotalSize - Select_Dri.TotalFreeSpace) / 1024 / 1024 / 1024).ToString());
                //            tn.SetAttribute("Total", (Select_Dri.TotalSize / 1024 / 1024 / 1024).ToString());
                //            tn.SetAttribute("Update", System.DateTime.Now.ToString());
                //            break;
                //        }
                //    }
                //    doc.Save(GL_XML_Name);

                }
                else
                {
                    //2014.2.1 Add
                    return;
                    XElement dirXml = Select_Dir.LToXml();//显示所有文件
                    string XML_Name = Select_Dir.Name;
                    string XML_Path = Config_INI.ReadString("XML", "XML_Build_Path", "");
                    if (XML_Path == null || XML_Path == "")
                    {
                        MessageBox.Show("ERROR 101 :\nDO NOT Find XML_Build_Path in XML!");
                        return;
                    }
                    string XML_FullPath = XML_Path + XML_Name + ".xml";
                    if (File.Exists(XML_FullPath))
                    {
                        //MessageBox.Show("Existed!So Rewrite!");
                        this.StatusLabel1.Text = "Existed!So Rewrite.";
                        File.Delete(XML_FullPath);
                        dirXml.Save(XML_FullPath);
                        this.StatusLabel2.Text = "Created.(Floder)";
                    }
                    else
                    {
                        dirXml.Save(XML_FullPath);
                        this.StatusLabel2.Text = "Created.(Floder)";
                    }
                }
            }
            else
                this.StatusLabel1.Text = "Path is NULL!";
        }

        private void MenuItem_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItem_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author :dansan\nVersion:1.3\nDate     :2014-02-02");
        }

        private void MenuItem_Update_Click(object sender, EventArgs e)
        {
            DriveInfo[] dCollect = DriveInfo.GetDrives();
            foreach (DriveInfo d in dCollect)
            {
                if (d.DriveType == DriveType.Fixed)
                {
                     FileInfo[] subFile = d.RootDirectory.GetFiles();
                     foreach (FileInfo f in subFile)
                     {
                         if (f.Name == "#ID.txt")
                         {
                             FileStream rFile = new FileStream(f.FullName, FileMode.Open);
                             StreamReader sr = new StreamReader(rFile);
                             string msg = sr.ReadLine();
                             sr.Close();

                             Build_By_Id(d.RootDirectory, msg);
                             break;
                         }
                     }
                }
            }
        }

        private void Build_By_Id(DirectoryInfo dir, string Id)
        {
            Console.WriteLine("It is a Driver!");
            DriveInfo dri = new DriveInfo(dir.Root.Name);
            XElement dirXml = dri.LToXml();//显示所有文件
            string XML_Name = Id + "#" + dri.VolumeLabel + /* "#" + dri.Name.Substring(0, 1) + */ "(" + (dri.TotalSize / 1024 / 1024 / 1024).ToString() + "G)";
            string XML_Path = Config_INI.ReadString("XML", "XML_Build_Path", "");
            if (XML_Path == null || XML_Path == "")
            {
                MessageBox.Show("ERROR 101 :\nDO NOT Find XML_Build_Path in XML!");
                return;
            }
            string XML_FullPath = XML_Path + @"\" + XML_Name + @".xml";
            if (File.Exists(XML_FullPath))
            {
                //Make Backup
                DirectoryInfo SAVE_Dir = new DirectoryInfo(Config_INI.ReadString("XML", "XML_Build_Path", "") + @"\BackUp");
                if ((!SAVE_Dir.Exists))
                    Directory.CreateDirectory(Config_INI.ReadString("XML", "XML_Build_Path", "") + @"\BackUp");
                FileInfo fileInfo = new FileInfo(XML_FullPath);
                FileInfo fileBack = new FileInfo(Config_INI.ReadString("XML", "XML_Build_Path", "") + @"\BackUp" + @"\" + XML_Name + @".xml");
                if (fileInfo.Exists)
                {
                    if (fileBack.Exists)
                        fileBack.Delete();
                    fileInfo.MoveTo(Config_INI.ReadString("XML", "XML_Build_Path", "") + @"\BackUp" + @"\" + XML_Name + @".xml");
                }

                //MessageBox.Show("Existed!So Rewrite!");
                this.StatusLabel1.Text = "Existed!So Rewrite.";
                File.Delete(XML_FullPath);
                dirXml.Save(XML_FullPath);
                this.StatusLabel2.Text = "Created.(Driver)";

                CLog.Info("Update " + XML_Name + " # Used " + ((dri.TotalSize - dri.TotalFreeSpace) / 1024 / 1024 / 1024).ToString() + "G # " +
                   "Total " + (dri.TotalSize / 1024 / 1024 / 1024).ToString() + "G");
            }
            else
            {
                dirXml.Save(XML_FullPath);
                this.StatusLabel2.Text = "Created.(Driver)";

                CLog.Info("Create " + XML_Name + " # Used " + ((dri.TotalSize - dri.TotalFreeSpace) / 1024 / 1024 / 1024).ToString() + "G # " +
                   "Total " + (dri.TotalSize / 1024 / 1024 / 1024).ToString() + "G");
            }

            //2014.2.1 Add
            XmlDocument doc = new XmlDocument();
            doc.Load(GL_XML_Name);
            //指定一个节点
            XmlElement root = doc.DocumentElement;
            foreach (XmlElement tn in root.ChildNodes)
            {
                if (tn.GetAttribute("ID") == Id)
                {
                    tn.SetAttribute("Name", XML_Name);
                    tn.SetAttribute("Used", ((dri.TotalSize - dri.TotalFreeSpace) / 1024 / 1024 / 1024).ToString());
                    tn.SetAttribute("Total", (dri.TotalSize / 1024 / 1024 / 1024).ToString());
                    tn.SetAttribute("Update", System.DateTime.Now.ToString());
                    break;
                }
            }
            doc.Save(GL_XML_Name);
        }

        #endregion

        #region TreeV

        private void TreeV_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void TreeV_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {

        }

        #endregion

        #region TreeD

        private void TreeD_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void TreeD_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {

        }

        private void BT_DTree_Add_Click(object sender, EventArgs e)
        {
            DCreate DCForm = new DCreate(this.TreeDisk);
            DCForm.ShowDialog();

            //XDocument XDoc = XDocument.Load(GL_XML_Name);
            //XElement GL_XML = XDoc.Element("root");
            //GL_XML.Attribute("count").Value = (Convert.ToInt32(GL_XML.Attribute("count").Value) + 1).ToString();
            //XDoc.Save(GL_XML_Name);

            XmlDocument doc = new XmlDocument();
            doc.Load(GL_XML_Name);
            //指定一个节点
            XmlElement root = doc.DocumentElement;
            root.SetAttribute("Count", (Convert.ToInt16(root.GetAttribute("Count")) + 1).ToString());
            doc.Save(GL_XML_Name);

            TreeD_Refresh();
        }

        private void BT_DTree_Del_Click(object sender, EventArgs e)
        {

        }

        private void TreeD_Refresh()
        {
            TreeDisk.Nodes.Clear();
            XDocument XDoc = XDocument.Load(GL_XML_Name);
            this.TreeDisk.Nodes.AddRange(XDoc.Elements().ToTreeNode().ToArray());
        }
        
        #endregion

        public void Traverse(TreeNode node, DirectoryInfo dir)
        {
            if (dir == null)
            {
                // 如果目录为空，则说明没有子目录，应该返回到上一层   
                return;
            }
            else
            {
                // TreeNode treeNode = new TreeNode(dir.Name);
                // node.Nodes.Add(treeNode); // 添加结点   
                // 子目录不空，则优先遍历所有的子目录，再遍历每个子目录中的文件   
                DirectoryInfo[] subDir = dir.GetDirectories();
                foreach (DirectoryInfo sub in subDir)
                {
                    if (sub.Attributes.ToString().LastIndexOf("System") == -1)
                    {
                        TreeNode treeNode = new TreeNode(sub.Name);
                        node.Nodes.Add(treeNode); // 添加结点   
                        Traverse(treeNode, sub); // 先遍历当前目录的子目录 
                    }
                }
                // 遍历当前目录的文件   
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo f in files)
                {
                    string fileName = f.Name;
                    TreeNode fileNode = new TreeNode(fileName);
                    node.Nodes.Add(fileNode);
                }
            }
        }

        public string DSelect_ID
        {
            get
            {
                return DS_ID;
            }
            set
            {
                DS_ID = value;
            }
        }

        

    }
}
