#region License Header
// KtecK Lab's StreamDesk
// Code (C) NasuTek-Alliant Enterprises, 2010; David Kellaway, 2008.
// StreamDesk and the StreamDesk logo are copyright (C) KtecK 2007-2010.
#endregion

#region Using Directives
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Xml;
#endregion

namespace StreamDesk.Framework
{
    /// <summary>
    /// Contains searching functions for StreamDesk Clients
    /// </summary>
    public class SDSearch
    {
        /// <summary>
        /// Searches the StreamDesk DB for specific streams
        /// </summary>
        /// <param name="searchParms">The stream to find.</param>
        /// <returns>A Stream Dictionary</returns>
        /// <example>
        /// You can get the following data out of it like so
        /// 
        /// foreach(KeyValuePair&lt;string, Dictionary&lt;string, string&gt;&gt; i in returnedDictVar) {
        ///     i.Value["Name"]; // Returns the streams Name
        ///     i.Value["Description"]; // Returns the streams Description
        ///     i.Value["Provider"]; // Returns the streams Provider
        /// }
        /// </example>
        public static Dictionary<string, Dictionary<string, string>> GetSearchParms(string searchParms)
        {
            if (Licence.Licencee != null)
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
            else throw new LicenceException();
        }
    }
}
