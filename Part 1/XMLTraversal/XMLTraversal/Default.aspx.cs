using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Xml.XPath;

namespace XMLTraversal
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            outputPanel.Visible = false;
        }
        string str = "";
        
        protected void hotelBtn_Click(object sender, EventArgs e)
        {
            string hotelPath = Server.MapPath("Hotels.xml");
            urlInput.Text = hotelPath;
            submitBtn_Click(sender, e);
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            string url = urlInput.Text;
            
            XmlDocument doc = new XmlDocument();
            doc.Load(url);
            XmlNode root1 = doc.DocumentElement;
            XmlNode root2 = doc.DocumentElement;

            str = "";
            preOrder(root1);
            preText.Text = str;

            str = "";
            postOrder(root2);
            postText.Text = str;

            outputPanel.Visible = true;
        }

        void preOrder(XmlNode node)
        {
            if (node == null)
            {
                System.Environment.Exit(1);
            }

            str += ("<pre>Node type = " + node.NodeType + "&nbsp;&nbsp;&nbsp;&nbsp;Node name = " + node.Name + "&nbsp;&nbsp;&nbsp;&nbsp;Node text = " + node.Value);
            
            if (node.Attributes != null)
            {
                XmlAttributeCollection attrs = node.Attributes;

                bool ranOnce = false;
                foreach (XmlAttribute atr in attrs)
                {
                    if (!ranOnce)
                    {
                        str += "<br />Attributes:";
                        ranOnce = true;
                    }
                    str += "&nbsp;&nbsp;&nbsp;&nbsp;{Attribute name = " + atr.Name + "&nbsp;&nbsp;&nbsp;&nbsp;Attribute value = " + atr.Value + "}";
                }
            }

            str += "</pre>";

            if (node.HasChildNodes)
            {
                XmlNodeList children = node.ChildNodes;
                foreach (XmlNode child in children)
                {
                    preOrder(child);
                }
            }
        }

        void postOrder(XmlNode node)
        {
            if (node == null)
            {
                System.Environment.Exit(1);
            }

            if (node.HasChildNodes)
            {
                XmlNodeList children = node.ChildNodes;
                foreach (XmlNode child in children)
                {
                    postOrder(child);
                }
            }

            str += ("<pre>Node type = " + node.NodeType + "&nbsp;&nbsp;&nbsp;&nbsp;Node name = " + node.Name + "&nbsp;&nbsp;&nbsp;&nbsp;Node text = " + node.Value);

            if (node.Attributes != null)
            {
                XmlAttributeCollection attrs = node.Attributes;

                bool ranOnce = false;
                foreach (XmlAttribute atr in attrs)
                {
                    if (!ranOnce)
                    {
                        str += "<br />Attributes:";
                        ranOnce = true;
                    }
                    str += "&nbsp;&nbsp;&nbsp;&nbsp;{Attribute name = " + atr.Name + "&nbsp;&nbsp;&nbsp;&nbsp;Attribute value = " + atr.Value + "}";
                }
            }

            str += "</pre>";
        }
    }
}