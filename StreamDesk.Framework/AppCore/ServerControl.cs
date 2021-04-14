using System;
using System.Collections.Generic;
using System.Text;
using StreamDesk.Framework;
using System.Threading;

namespace StreamDesk.Framework.AppCore
{
    public class ServerControl
    {
        static Server serverInstance;

        public static void Start()
        {
            if (Licence.GetLicencee() != null)
            {
                if (serverInstance == null) serverInstance = new Server();
                new Thread(serverInstance.Start).Start();
            }
            else throw new LicenceException();
        }

        public static void Stop()
        {
            if (Licence.GetLicencee() != null)
            {
                serverInstance.Stop();
            }
            else throw new LicenceException();
        }
    }
}
