#region License Header
// KtecK Lab's StreamDesk
// Code (C) NasuTek-Alliant Enterprises, 2010; David Kellaway, 2008.
// StreamDesk and the StreamDesk logo are copyright (C) KtecK 2007-2010.
// Licensed under the NasuTek Restrictive Development License Version 1.00
#endregion

#region Using Directives
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using System.Xml;

#endregion

namespace StreamDesk.AppCore {
    public class StreamDeskDBControl {
        public static List<TreeNode> GetStreamList () {
            var wc = new WebClient ();
            string data = wc.DownloadString ("http://localhost:9898/+gettree");
            var ret = new List<TreeNode> ();
            var doc = new XmlDocument ();
            doc.LoadXml (data);

            foreach (XmlNode i in doc.SelectNodes ("/xmlrpc/provider")) {
                var node = new TreeNode (i.Attributes["name"].Value);
                node.Name = i.Attributes["name"].Value;
                var strArray = new string[9];
                strArray[0] = "PROVIDER";
                strArray[1] = i.Attributes["description"].Value;
                strArray[2] = i.Attributes["url"].Value;
                node.Tag = strArray;
                foreach (XmlNode j in i.ChildNodes) {
                    var node2 = new TreeNode (j.Attributes["Name"].Value);
                    node2.Name = j.Attributes["Name"].Value;
                    node2.Tag = new[] {
                                          i.Attributes["name"].Value, j.Attributes["Web"].Value,
                                          j.Attributes["Size"].Value, j.Attributes["StreamEmbed"].Value,
                                          j.Attributes["StreamEmbedData"].Value, j.Attributes["UseShion"].Value,
                                          j.Attributes["ChatEmbed"].Value, j.Attributes["ChatEmbedData"].Value,
                                          j.Attributes["Description"].Value, j.Attributes["IRCServer"].Value, "STREAM"
                                      };
                    node.Nodes.Add (node2);
                }

                ret.Add (node);
            }

            return ret;
        }

        public static List<ToolStripMenuItem> GetStreamList_Menu (frmMain main) {
            var wc = new WebClient ();
            string data = wc.DownloadString ("http://localhost:9898/+gettree");
            var ret = new List<ToolStripMenuItem> ();
            var doc = new XmlDocument ();
            doc.LoadXml (data);

            foreach (XmlNode i in doc.SelectNodes ("/xmlrpc/provider")) {
                var node = new ToolStripMenuItem (i.Attributes["name"].Value);
                node.Name = i.Attributes["name"].Value;
                var strArray = new string[9];
                strArray[0] = "PROVIDER";
                strArray[1] = i.Attributes["description"].Value;
                strArray[2] = i.Attributes["url"].Value;
                node.Tag = strArray;
                foreach (XmlNode j in i.ChildNodes) {
                    var node2 = new ToolStripMenuItem (j.Attributes["Name"].Value);
                    node2.Name = j.Attributes["Name"].Value;
                    node2.Tag = new[] {
                                          i.Attributes["name"].Value, j.Attributes["Web"].Value,
                                          j.Attributes["Size"].Value, j.Attributes["StreamEmbed"].Value,
                                          j.Attributes["StreamEmbedData"].Value, j.Attributes["UseShion"].Value,
                                          j.Attributes["ChatEmbed"].Value, j.Attributes["ChatEmbedData"].Value,
                                          j.Attributes["Description"].Value, j.Attributes["IRCServer"].Value
                                      };
                    node2.Click += main.streamClick;
                    node.DropDownItems.Add (node2);
                }

                ret.Add (node);
            }

            return ret;
        }

        public static Dictionary<string, Dictionary<string, string>> GetSearchParms(string searchParms)
        {
            var ret = new Dictionary<string, Dictionary<string, string>>();
            var wc = new WebClient();
            string data = wc.DownloadString(string.Format("http://localhost:9898/+search/{0}", searchParms));
            var doc = new XmlDocument();
            doc.LoadXml(data);

            foreach (XmlNode i in doc.SelectNodes("/searchresults/stream"))
            {
                ret.Add(i.Attributes["Name"].Value + "-" + i.Attributes["Provider"].Value, new Dictionary<string, string>());
                ret[i.Attributes["Name"].Value + "-" + i.Attributes["Provider"].Value].Add("Name", i.Attributes["Name"].Value);
                ret[i.Attributes["Name"].Value + "-" + i.Attributes["Provider"].Value].Add("Description", i.Attributes["Description"].Value);
                ret[i.Attributes["Name"].Value + "-" + i.Attributes["Provider"].Value].Add("Provider", i.Attributes["Provider"].Value);
            }

            return ret;
        }
    }
}