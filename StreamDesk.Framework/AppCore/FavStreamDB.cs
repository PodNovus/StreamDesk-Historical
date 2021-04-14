using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using StreamDesk.Framework.WinForms;

namespace StreamDesk.Framework.AppCore
{
    public class FavStreamDB
    {
        public List<FavStream> FavStreams = new List<FavStream>();

        public List<ToolStripMenuItem> GetFavStreams(EventHandler clickhandle)
        {
            if (Licence.Licencee != null)
            {
                Dictionary<string, List<string>> favStreams = new Dictionary<string, List<string>>();
                List<ToolStripMenuItem> menu = new List<ToolStripMenuItem>();

                foreach (FavStream i in FavStreams)
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
                        streamItem.Tag = SDStreams.GetStreamTag(j, i.Key);
                        item.DropDownItems.Add(streamItem);
                    }
                    menu.Add(item);
                }

                return menu;
            }
            else throw new LicenceException();
        }

        public void DeleteStream(string provider, string name)
        {
            if (Licence.Licencee != null)
            {
                foreach (FavStream i in FavStreams)
                {
                    if (i.Provider == provider)
                        if (i.Name == name)
                        {
                            FavStreams.Remove(i);
                            break;
                        }
                }
            }
            else throw new LicenceException();
        }

        public bool StreamExist(string provider, string name)
        {
            if (Licence.Licencee != null)
            {
                foreach (FavStream i in FavStreams)
                {
                    if (i.Provider == provider)
                        if (i.Name == name)
                        {
                            return true;
                        }
                }
                return false;
            }
            else throw new LicenceException();
        }
    }

    public class FavStream 
    {
        public string Name, Provider;
    }
}
