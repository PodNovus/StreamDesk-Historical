using System;
using System.Collections.Generic;
using System.Text;
using StreamDesk.Framework.Properties;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace StreamDesk.Framework
{
    public class Licence
    {
        internal static string Licencee;

        public static void InitLicence(string ExePath)
        {
/*#if DEBUG
            //Sence were debugging we obviously dont want to have to recreate the
            //Licence every time we debug so we just disable on debug build
            Licencee = "Debugging License";
#else*/
            var licVerifier = new NasuTek.LicenseSystem.LicenseVerifier(Path.Combine(Application.StartupPath, "SD.crt"));

            if (licVerifier.VerifyLicense(Path.Combine(Application.StartupPath,"Licencee.xml")) == true)
            {
                Licencee = "OPEN";
            }
            else
            {
                throw new LicenceException();
            }
        }
//#endif

        public static string GetLicencee() { return Licencee; }
    }

    public class LicenceException : Exception
    {
        public LicenceException() : base("Either the Licence is Invalid or you didnt even Initialize a licence") { }
    }
}
