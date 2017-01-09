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

namespace XML_Mgr
{
    public partial class DSelect : Form
    {
        public string DS_Str = "";
        public string DS_Select = "";
        List<string> DS_source = new List<string>();

        public DSelect(TreeView treev)
        {
            InitializeComponent();
            init(treev);
        }

        private void BT_DSelect_Creat_Click(object sender, EventArgs e)
        {
            string msg = this.ComboBox_DSelect.Text.ToString();
            if (msg != null && msg != "")
            {
                DialogResult dr = System.Windows.Forms.MessageBox.Show("确定建立" + msg + "项目?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DS_Str = msg;
                    ReFresh();
                    return;
                }
                else
                {
                    return;
                }
            }
            else
                return;
        }

        private void BT_DSelect_Ok_Click(object sender, EventArgs e)
        {
            string msg = this.ComboBox_DSelect.SelectedItem.ToString();
            if (msg != null && msg != "")
            {
                DS_Str = msg;
            }

            Mgr parents = (Mgr)this.Owner;
            parents.DSelect_ID = DS_Str;

            this.Close();
        }

        private void BT_DSelect_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void init(TreeView treev)
        {
            //XmlDocument doc = new XmlDocument();
            //string GL_XML_Name = Application.StartupPath + @"\XML\GL.xml";
            //doc.Load(GL_XML_Name);
            //readxml(doc.DocumentElement as XmlNode);

            TreeNode root = new TreeNode();
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
                DS_source.Add(tn.Text.ToString());
            }

            this.ComboBox_DSelect.DataSource = DS_source;
        }

        private void readxml(XmlNode node)
        {
            if (node.Name == "Disk")
            {
                if (node.HasChildNodes)
                {
                    readxml(node.FirstChild);
                }
            }
            if (node.Attributes["ID"] != null)
            {
                DS_source.Add(node.Name.ToString());
            }
            if (node.NextSibling != null)
            {
                readxml(node.NextSibling);
            }
        }

        private void ReFresh()
        {

        }
    }
}
