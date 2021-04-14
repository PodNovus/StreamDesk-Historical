#region License Header
// KtecK Lab's StreamDesk
// Code (C) NasuTek-Alliant Enterprises, 2010; David Kellaway, 2008.
// StreamDesk and the StreamDesk logo are copyright (C) KtecK 2007-2010.
// Licensed under the NasuTek Restrictive Development License Version 1.00
#endregion

#region Using Directives
using System;
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;
using System.Windows.Forms;
using Skybound.Gecko;
using System.Collections.Generic;
using FireIRC;
using System.Threading;
using StreamDesk.Framework;
using System.Net;
using StreamDesk.Framework.AppCore;
using StreamDesk.Framework.SDSettings;

#endregion

namespace StreamDesk
{
    internal static class Program
    {
        internal static bool isQuitting;
        internal static readonly string license = @"<StreamDeskLicense><Issuer>KtecK Labs</Issuer><IssuedTo>KtecK Labs</IssuedTo><Signature xmlns=""http://www.w3.org/2000/09/xmldsig#""><SignedInfo><CanonicalizationMethod Algorithm=""http://www.w3.org/TR/2001/REC-xml-c14n-20010315"" /><SignatureMethod Algorithm=""http://www.w3.org/2000/09/xmldsig#rsa-sha1"" /><Reference URI=""""><Transforms><Transform Algorithm=""http://www.w3.org/2000/09/xmldsig#enveloped-signature"" /></Transforms><DigestMethod Algorithm=""http://www.w3.org/2000/09/xmldsig#sha1"" /><DigestValue>tpoantCxqi4gga+ZHuDFThi2aMk=</DigestValue></Reference></SignedInfo><SignatureValue>mgTTLdkcUjLU1UOD/6EvPublwi5w2bcT5ngZU/aPntqe55jMJiFZfCXKYyBrmYd/pWp/OxPB+C7JfnATV42j/VVIWVGeiQUxBC5IPoqidQbB/oLucgKl4YdTGjrlEExwg+Ltjc/PPY7OLYL7aet82SvY0k6OTmzpfCcAHzwRV0Y=</SignatureValue></Signature></StreamDeskLicense>";

        [STAThread]
        private static void Main(string[] args)
        {
            Licence.InitLicence(Application.ExecutablePath);
            Settings.OpenSettings("StreamDeskOfficial");

            try
            {
                var wc = new WebClient();
                wc.DownloadString(new Uri("http://localhost:9898/+check"));
            }
            catch
            {
                ServerControl.Start();
                Starter();
            }
        }

        private static void Starter()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Xpcom.Initialize("xulrunner");
            Application.Run(new frmMain(false));

            ServerControl.Stop();
            Settings.SaveSettings("StreamDeskOfficial");
        }
    }
}