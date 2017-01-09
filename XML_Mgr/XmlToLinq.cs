using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;

namespace XML_Mgr
{
    /// <summary>
    /// TreeView,TreeNode和XElement的相互转换的类
    /// </summary>
    public static class XmlToLinq
    {
        /// <summary>
        /// 将TreeNode转换为XElement
        /// </summary>
        /// <param name="treeNode"></param>
        /// <returns></returns>
        public static XElement ToXElement(this TreeNode treeNode)
        {
            return new XElement(treeNode.Text, treeNode.Nodes.ToXelement());
        }

        /// <summary>
        /// 将TreeNode的Nodes转换为XElement的集合
        /// </summary>
        /// <param name="nodes"></param>
        /// <returns></returns>
        public static IEnumerable<XElement> ToXelement(this TreeNodeCollection nodes)
        {
            return nodes.OfType<TreeNode>().Select(n => n.ToXElement());
        }

        /// <summary>
        /// 将XElement转换为TreeNode
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static TreeNode ToTreeNode(this XElement element)
        {
            //Console.WriteLine(element.ToString());
            //return new TreeNode(element.Name.ToString(), element.Elements().ToTreeNode().ToArray());

            //TreeNode Node = new TreeNode(element.Name.ToString(), element.Elements().ToTreeNode().ToArray());
            //2014.2.1 Modified
            TreeNode Node;
            if(element.Name == "root")
                 Node = new TreeNode(element.Attribute("Name").Value.ToString(), element.Elements().ToTreeNode().ToArray());
            else
                 Node = new TreeNode(element.Attribute("ID").Value.ToString(), element.Elements().ToTreeNode().ToArray());
            //Node.ToolTipText = element.Name.ToString();
            //Node.Name = element.Name.ToString();
            return Node;
            
        }

        /// <summary>
        /// 将Element的子元素转换为TreeNode的集合
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public static IEnumerable<TreeNode> ToTreeNode(this IEnumerable<XElement> elements)
        {
            return elements.Select(e => e.ToTreeNode());
        }

        /// <summary>
        /// 将TreeView转换为XDocument
        /// </summary>
        /// <param name="treeView"></param>
        /// <returns></returns>
        public static XDocument ToXml(this TreeView treeView)
        {
            return new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement(treeView.Name, treeView.Nodes.ToXelement()));
        }
    }
}
