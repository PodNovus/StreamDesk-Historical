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

#endregion

namespace StreamDesk
{
    internal static class Program
    {
        internal static bool isQuitting;

        [STAThread]
        private static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Xpcom.Initialize("xulrunner");
            Process sdCore = Process.Start("StreamDesk.Core.exe"); 
            Application.Run(new frmMain());
            //TODO: For later purposes sdCore.Kill();
        }
    }
}