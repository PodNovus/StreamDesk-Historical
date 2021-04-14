using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace StreamDesk.Framework.SDSettings
{
    public class Settings
    {
        public static Settings Instance = new Settings();
        public FavStreamDB FavsDB = new FavStreamDB();

        public static void OpenSettings(string AppName)
        {
            if (Licence.GetLicencee() != null)
            {
                var settpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "StreamDesk Settings");
                var userfile = Path.Combine(settpath, AppName + ".xml");

                if (!Directory.Exists(settpath))
                    Directory.CreateDirectory(settpath);

                XmlSerializer xml = new XmlSerializer(typeof(Settings));
                try { Instance = (Settings)xml.Deserialize(File.OpenRead(userfile)); }
                catch (FileNotFoundException) { }
            }
            else throw new LicenceException();
        }

        public static void SaveSettings(string AppName)
        {
            if (Licence.GetLicencee() != null)
            {
                var settpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "StreamDesk Settings");
                var userfile = Path.Combine(settpath, AppName + ".xml");

                if (!Directory.Exists(settpath))
                    Directory.CreateDirectory(settpath);

                XmlSerializer xml = new XmlSerializer(typeof(Settings));
                xml.Serialize(File.Create(userfile), Instance);
            }
            else throw new LicenceException();
        }
    }
}
