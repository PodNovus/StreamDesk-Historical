using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace StreamDesk.Framework.SDSettings
{
    public class FavStreamDB
    {
        public List<FavStream> FavStreams = new List<FavStream>();

        public void DeleteStream(string provider, string name)
        {
            if (Licence.GetLicencee() != null)
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
            if (Licence.GetLicencee() != null)
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
