#region License Header
// KtecK Lab's StreamDesk
// Code (C) NasuTek-Alliant Enterprises, 2010; David Kellaway, 2008.
// StreamDesk and the StreamDesk logo are copyright (C) KtecK 2007-2010.
// Licensed under the NasuTek Restrictive Development License Version 1.00
#endregion

#region Using Directives
using System;
using StreamDesk.Framework;
using System.Net;
using StreamDesk.Framework.AppCore;
#endregion

namespace StreamDesk
{
    internal static class Program
    {
        internal static bool isQuitting;
        internal static readonly string license = "2441B4BB1545D95A5B156DFBFDCA932BC3C085B7";

        [STAThread]
        private static void Main(string[] args)
        {
            Licence.InitLicence(license);

            try
            {
                var wc = new WebClient();
                wc.DownloadString(new Uri("http://localhost:9898/+check"));
            }
            catch
            {
                ServerControl.Start();
            }
        }
    }
}