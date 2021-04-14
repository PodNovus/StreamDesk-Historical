#region License Header
// KtecK Lab's StreamDesk
// Code (C) NasuTek-Alliant Enterprises, 2010; David Kellaway, 2008.
// StreamDesk and the StreamDesk logo are copyright (C) KtecK 2007-2010.
#endregion

#region Using Directives
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using System;
#endregion

namespace StreamDesk.Framework.WinForms
{
    /// <summary>
    /// Contains streaming functions for StreamDesk Clients
    /// </summary>
    public class SDStreams
    {
        /// <summary>
        /// Gets together the streams and puts them into a TreeNode List
        /// </summary>
        /// <returns>A list of TreeNodes representing the streams in this hiearchy Provider &gt; Stream</returns>
        public static List<TreeNode> GetStreamList_TreeView()
        {
            if (Licence.GetLicencee() != null)
            {
                var wc = new WebClient();
                string data = wc.DownloadString("http://localhost:9898/+gettree");
                var ret = new List<TreeNode>();
                var doc = new XmlDocument();
                doc.LoadXml(data);

                foreach (XmlNode i in doc.SelectNodes("/xmlrpc/provider"))
                {
                    var node = new TreeNode(i.Attributes["name"].Value);
                    node.Name = i.Attributes["name"].Value;
                    var strArray = new string[9];
                    strArray[0] = "PROVIDER";
                    strArray[1] = i.Attributes["description"].Value;
                    strArray[2] = i.Attributes["url"].Value;
                    node.Tag = strArray;
                    foreach (XmlNode j in i.ChildNodes)
                    {
                        var node2 = new TreeNode(j.Attributes["Name"].Value);
                        node2.Name = j.Attributes["Name"].Value;
                        node2.Tag = new[] {
                                          i.Attributes["name"].Value, j.Attributes["Web"].Value,
                                          j.Attributes["Size"].Value, j.Attributes["StreamEmbed"].Value,
                                          j.Attributes["StreamEmbedData"].Value, j.Attributes["UseShion"].Value,
                                          j.Attributes["ChatEmbed"].Value, j.Attributes["ChatEmbedData"].Value,
                                          j.Attributes["Description"].Value, j.Attributes["IRCServer"].Value, "STREAM",
                                          i.Attributes["name"].Value
                                      };
                        node.Nodes.Add(node2);
                    }

                    ret.Add(node);
                }
                return ret;
            }
            else throw new LicenceException();
        }

        /// <summary>
        /// Gets together the streams and puts them into a ToolStripMenuItem List
        /// </summary>
        /// <param name="streamClick">The onClick EventHandler for stream onClicks</param>
        /// <returns>A list of ToolStripMenuItems representing the streams in this hiearchy Provider &gt; Stream</returns>
        public static List<ToolStripMenuItem> GetStreamList_Menu(EventHandler streamClick)
        {
            if (Licence.GetLicencee() != null)
            {
                var wc = new WebClient();
                string data = wc.DownloadString("http://localhost:9898/+gettree");
                var ret = new List<ToolStripMenuItem>();
                var doc = new XmlDocument();
                doc.LoadXml(data);

                foreach (XmlNode i in doc.SelectNodes("/xmlrpc/provider"))
                {
                    var node = new ToolStripMenuItem(i.Attributes["name"].Value);
                    node.Name = i.Attributes["name"].Value;
                    var strArray = new string[9];
                    strArray[0] = "PROVIDER";
                    strArray[1] = i.Attributes["description"].Value;
                    strArray[2] = i.Attributes["url"].Value;
                    node.Tag = strArray;
                    foreach (XmlNode j in i.ChildNodes)
                    {
                        var node2 = new ToolStripMenuItem(j.Attributes["Name"].Value);
                        node2.Name = j.Attributes["Name"].Value;
                        node2.Tag = new[] {
                                          i.Attributes["name"].Value, j.Attributes["Web"].Value,
                                          j.Attributes["Size"].Value, j.Attributes["StreamEmbed"].Value,
                                          j.Attributes["StreamEmbedData"].Value, j.Attributes["UseShion"].Value,
                                          j.Attributes["ChatEmbed"].Value, j.Attributes["ChatEmbedData"].Value,
                                          j.Attributes["Description"].Value, j.Attributes["IRCServer"].Value,
                                          i.Attributes["name"].Value
                                      };
                        node2.Click += streamClick;
                        node.DropDownItems.Add(node2);
                    }

                    ret.Add(node);
                }
                return ret;
            }
            else throw new LicenceException();
        }
    }
}