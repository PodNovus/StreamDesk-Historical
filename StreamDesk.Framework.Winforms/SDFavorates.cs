using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using StreamDesk.Framework.SDSettings;

namespace StreamDesk.Framework.WinForms
{
   public class SDFavorates
    {
        public static List<ToolStripMenuItem> GetFavStreams(EventHandler clickhandle)
        {
            if (Licence.GetLicencee() != null)
            {
                Dictionary<string, List<string>> favStreams = new Dictionary<string, List<string>>();
                List<ToolStripMenuItem> menu = new List<ToolStripMenuItem>();

                foreach (FavStream i in Settings.Instance.FavsDB.FavStreams)
                {
                    if (!favStreams.ContainsKey(i.Provider)) favStreams.Add(i.Provider, new List<string>());
                    favStreams[i.Provider].Add(i.Name);
                }

                foreach (KeyValuePair<string, List<string>> i in favStreams)
                {
                    ToolStripMenuItem item = new ToolStripMenuItem(i.Key);
                    foreach (string j in i.Value)
                    {
                        ToolStripMenuItem streamItem = new ToolStripMenuItem(j);
                        streamItem.Click += new EventHandler(clickhandle);
                        streamItem.Tag = StreamCommands.GetStreamTag(j, i.Key);
                        if (streamItem.Tag == null)
                        {
                            streamItem.Tag = new string[] { "DELETE", i.Key, j };
                            item.DropDownItems.Add(streamItem);
                        }
                        else
                            item.DropDownItems.Add(streamItem);
                    }
                    menu.Add(item);
                }

                return menu;
            }
            else throw new LicenceException();
        }
    }
}
