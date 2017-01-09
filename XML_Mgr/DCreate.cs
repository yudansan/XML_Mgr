using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XML_Mgr
{
    public partial class DCreate : Form
    {
        List<string> DC_source = new List<string>();
        List<int> DC_model_int = new List<int>();

        TreeNode root = new TreeNode();

        public DCreate(TreeView treev)
        {
            InitializeComponent();
            init(treev);
        }

        private void BT_DCreate_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_DCreate_Ok_Click(object sender, EventArgs e)
        {
            string DC_Id = this.ComboBox_DCreate.Text.ToString();
            string DC_Flag = this.TextBox_DCreate.Text.ToString();

            //TreeNode node = new TreeNode(DC_Id);
            //root.Nodes.Add(node);

            XmlDocument doc = new XmlDocument();
            string GL_XML_Name = Application.StartupPath + @"\XML\GL.xml";
            doc.Load(GL_XML_Name);
            //指定一个节点
            XmlNode root = doc.SelectSingleNode("/root");
            //生成一个新节点
            XmlElement node = doc.CreateElement("Disk");
            node.SetAttribute("Name", DC_Flag.ToString());
            node.SetAttribute("ID", DC_Id.ToString());
            node.SetAttribute("Mark", DC_Flag.ToString());
            node.SetAttribute("Used", "");
            node.SetAttribute("Total", "");
            node.SetAttribute("Update", System.DateTime.Now.ToString());

            //寻找插入点
            bool Flag = false;
            foreach (XmlNode xn in root.ChildNodes)
            {
                if (Convert.ToInt16(xn.Attributes["ID"].Value) > Convert.ToInt16(node.GetAttribute("ID")))
                {
                    root.InsertBefore(node, xn);
                    Flag = true;
                    break;
                }
            }
            if (!Flag)
            {
                //将节点加到指定节点下，作为其子节点
                root.AppendChild(node);
            }
            doc.Save(GL_XML_Name);

            CLog.Info("Add Node no." + DC_Id);

            this.Close();
        }

        private void init(TreeView treev)
        {
            foreach (TreeNode tn in treev.Nodes)
            {
                if (tn.Parent == null)
                {
                    root = tn;
                    break;
                }
            }
            foreach (TreeNode tn in root.Nodes)
            {
                DC_source.Add(tn.Text.ToString());
            }
            for (int i = 1; i < 20; i++)
            {
                if(!DC_source.Contains(i.ToString()))
                    DC_model_int.Add(i);
            }
            this.ComboBox_DCreate.DataSource = DC_model_int;
        }
    }
}
