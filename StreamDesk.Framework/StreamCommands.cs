using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml;

namespace StreamDesk.Framework
{
    public class StreamCommands
    {
        public static string[] GetStreamTag(string name, string provider)
        {
            if (Licence.Licencee != null)
            {
                var wc = new WebClient();
                string data = wc.DownloadString("http://localhost:9898/+gettree");
                string[] ret = null;
                var doc = new XmlDocument();
                doc.LoadXml(data);

                foreach (XmlNode i in doc.SelectNodes("/xmlrpc/provider"))
                {
                    if (i.Attributes["name"].Value == provider)
                    {
                        foreach (XmlNode j in i.ChildNodes)
                        {
                            if (j.Attributes["Name"].Value == name)
                            {
                                ret = new[] {
                                          i.Attributes["name"].Value, j.Attributes["Web"].Value,
                                          j.Attributes["Size"].Value, j.Attributes["StreamEmbed"].Value,
                                          j.Attributes["StreamEmbedData"].Value, j.Attributes["UseShion"].Value,
                                          j.Attributes["ChatEmbed"].Value, j.Attributes["ChatEmbedData"].Value,
                                          j.Attributes["Description"].Value, j.Attributes["IRCServer"].Value,
                                          i.Attributes["name"].Value
                                      };
                                break;
                            }
                        }
                        break;
                    }
                }
                return ret;
            }
            else throw new LicenceException();
        }
    }
}
