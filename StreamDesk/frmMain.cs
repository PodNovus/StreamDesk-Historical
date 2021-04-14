#region License Header
// KtecK Lab's StreamDesk
// Code (C) NasuTek-Alliant Enterprises, 2010; David Kellaway, 2008.
// StreamDesk and the StreamDesk logo are copyright (C) KtecK 2007-2010.
// Licensed under the NasuTek Restrictive Development License Version 1.00
#endregion

#region Using Directives
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using FireIRC.Resources.Forms;
using StreamDesk.Framework;
using StreamDesk.Framework.WinForms;
using StreamDesk.AppTools;
using StreamDesk.Properties;
using Skybound.Gecko;
using System.Threading;

#endregion

namespace StreamDesk {
    public partial class frmMain : Form {
        private string AppName = "StreamDesk";
        private IContainer components;
        private SplitContainer sContainer;
        private string streamHTML = "O_O";
        private string title, provider, description, url, windowTitle;
        private bool chat, info;
        private ToolTip ttChat;
        private TreeView tvStreams;
        private GeckoWebBrowser webBrowser = new GeckoWebBrowser ();
        private bool newWindow;
        public frmMain (bool _newWindow) {
            InitializeComponent ();
            newWindow = _newWindow;
            webBrowser.Dock = DockStyle.Fill;
            wbStream.Controls.Add (webBrowser);
        }

        private void aboutToolStripMenuItem_Click (object sender, EventArgs e) {
            new frmAbout ().ShowDialog ();
        }

        private void frmMain_FormClosing (object sender, FormClosingEventArgs e) {
            Program.isQuitting = true;
/*
            Settings.Default.LastTop = base.Top;
            Settings.Default.LastLeft = base.Left;*/
            if (sContainer.SplitterDistance > 100) {
                StreamDesk.Properties.Settings.Default.LastSidebar = sContainer.SplitterDistance;
            } else {
                StreamDesk.Properties.Settings.Default.LastSidebar = 100;
            }
            StreamDesk.Properties.Settings.Default.Save ();
        }

        private void frmMain_Load (object sender, EventArgs e) {
            GenerateFavMenu();
            sContainer.Panel1Collapsed = Reverse (StreamDesk.Properties.Settings.Default.ShowTreeView);
            treeMenuToolStripMenuItem.Checked = StreamDesk.Properties.Settings.Default.ShowTreeView;

            Text = AppName;
            sContainer.SplitterDistance = StreamDesk.Properties.Settings.Default.LastSidebar;
            /*
            Rectangle workingArea = Screen.GetWorkingArea(this);
            if (Settings.Default.LastTop < (workingArea.Height - base.Height))
            {
                base.Top = Settings.Default.LastTop;
            }
            if (Settings.Default.LastLeft < (workingArea.Width - base.Width))
            {
                base.Left = Settings.Default.LastLeft;
            }
             */
            sContainer.SplitterWidth = 3;
            if (!newWindow)
            {
                if (StreamDesk.Properties.Settings.Default.GetStreamsAtStartup)
                {
                    new Updator().ShowDialog();
                }
            }
            base.TopMost = StreamDesk.Properties.Settings.Default.VideoTopMost;
            toolStripDropDownButton1.Visible = false;
            ReadStreams ();
            if (!newWindow)
            {
                var un = new UpdateNotifier();
                un.ImageIcon = Resources._64;
                un.UpdateXMLURL = "http://streamdesk.ca/update.xml";
                un.CheckForUpdates("StreamDesk", "Windows");
            }
        }

        private void kComputerZoneToolStripMenuItem1_Click (object sender, EventArgs e) {
            SystemBrowser ("http://streamdesk.ca/");
        }

        private void OpenChat (object senderTag, int chatMode) {
            var strArray = (string[]) senderTag;
            if (strArray != null) {
                switch (chatMode)
                {
                    case 0:
                        new frmChat(strArray[0], strArray[1]).Show();
                        break;
                    case 1:
                        try
                        {
                            SystemBrowser("irc://" + strArray[2] + "/" + strArray[1]);
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(
                                "Your system does not appear to have a program associated with the irc:// protocol.");
                        }
                        break;
                    case 2:
                        //TODO: For Future IRC Client Mode
                        break;
                }
            }
        }

        private void pbChat_Click (object sender, EventArgs e) {
            if (pbChat.Text != "Justin.TV") { OpenChat(pbChat.Tag, 0); }
            else { OpenChat(pbChat.Tag, 0); }
        }

        private void pbToggleStreams_Click (object sender, EventArgs e) {
            if (sContainer.SplitterDistance != 5) {
                sContainer.SplitterDistance = 5;
                sContainer.SplitterWidth = 1;
                sContainer.Panel1.Hide ();
            } else {
                sContainer.SplitterDistance = 170;
                sContainer.SplitterWidth = 3;
                sContainer.Panel1.Show ();
            }
        }

        private void preferencesToolStripMenuItem_Click (object sender, EventArgs e) {
            base.TopMost = false;
            new frmSettings ().ShowDialog ();
            if (StreamDesk.Properties.Settings.Default.VideoTopMost) {
                base.TopMost = true;
            }
        }

        private void ReadStreams () {
            try {
                tvStreams.Nodes.Clear ();
                streamsToolStripMenuItem.DropDownItems.Clear ();
                tvStreams.Nodes.AddRange (SDStreams.GetStreamList_TreeView ().ToArray ());
                streamsToolStripMenuItem.DropDownItems.AddRange (
                    SDStreams.GetStreamList_Menu(streamClick).ToArray());
            } catch (Exception exception) {}
        }

        private void SystemBrowser (string url) {
            Process.Start (url.ToString ());
        }

        public void streamClick(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                webBrowser.Visible = true;
                panel1.Visible = false;
                AcceptButton = null;
            }
            toolStripButton3.Visible = true;
            var menu = (ToolStripMenuItem)sender;
            var tag = (string[])menu.Tag;
            var wc = new WebClient();

            if (tag[0] != "DELETE")
            {
                title = menu.Text;
                url = tag[1];
                description = tag[8];
                provider = tag[10];

                if (wc.DownloadString(String.Format("http://127.0.0.1:9898/+is_stream_type/{0}", tag[3])) == "True")
                {
                    webBrowser.Navigate(String.Format("http://127.0.0.1:9898/+stream/{0}/{1}", tag[3], tag[4]));
                    Text = tag[0] + " > " + menu.Text + " - " + AppName;
                }
                else
                {
                    MessageBox.Show("Unrecognized stream type " + tag[3] + "!", "Stream error", MessageBoxButtons.OK,
                                     MessageBoxIcon.Hand);
                    Text = AppName;
                }

                if (tag[6] != "none")
                {
                    var strArray2 = new string[] {
                                                 tag[6], tag[7], tag[9]
                                             };
                    if (tag[8] == null) chatViaIRCClientToolStripMenuItem.Visible = false;
                    else chatViaIRCClientToolStripMenuItem.Visible = true;

                    pbChat.Tag = strArray2;
                    pbChat.Visible = true;
                    if (strArray2[0] == "chat_justintv")
                    {
                        pbChat.Text = "Justin.TV";
                        chatViaIRCClientToolStripMenuItem.Visible = false;
                    }
                    else
                    {
                        pbChat.Text = "Web Chat";
                        chatViaIRCClientToolStripMenuItem.Visible = true;
                    }
                    toolStripDropDownButton1.Visible = true;
                }
                else
                {
                    toolStripDropDownButton1.Visible = false;
                }
                if (StreamDesk.Properties.Settings.Default.VideoResize)
                {
                    int getWebBoundsWidth;
                    if (sContainer.Panel1Collapsed == true)
                    {
                        getWebBoundsWidth = 0;
                    }
                    else
                    {
                        getWebBoundsWidth = tvStreams.Width + 3;
                    }
                    int getWidth = int.Parse(tag[2].Split('x')[0]);
                    int getHeight = int.Parse(tag[2].Split('x')[1]);
                    Height = (getHeight + 46) + 36;
                    Width = (getWidth + getWebBoundsWidth) + 16;
                }
            }
            else
            {
                MessageBox.Show(String.Format("The stream {0} of provider {1} is no longer available.", tag[2], tag[1]), "StreamDesk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Framework.AppCore.Settings.Instance.FavsDB.DeleteStream(tag[1], tag[2]);
                GenerateFavMenu();
            }
        }

        private void tvStreams_NodeMouseClick (object sender, TreeNodeMouseClickEventArgs e) {
            if (panel1.Visible)
            {
                webBrowser.Visible = true;
                panel1.Visible = false;
                AcceptButton = null;
            }
            toolStripButton3.Visible = true;
            var tag = (string[]) e.Node.Tag;
            if (tag.Length == 11) {
                if (tag[10] == "STREAM") {
                    var wc = new WebClient ();

                    title = e.Node.Text;
                    url = tag[1];
                    description = tag[8];
                    provider = tag[11];

                    if (wc.DownloadString (String.Format ("http://127.0.0.1:9898/+is_stream_type/{0}", tag[3])) ==
                        "True") {
                        webBrowser.Navigate (String.Format ("http://127.0.0.1:9898/+stream/{0}/{1}", tag[3], tag[4]));
                        Text = tag[0] + " > " + e.Node.Text + " - " + AppName;
                    } else {
                        MessageBox.Show ("Unrecognized stream type " + tag[3] + "!", "Stream error",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Hand);
                        Text = AppName;
                    }

                    if (tag[6] != "none") {
                        var strArray2 = new string[] {
                                                         tag[6], tag[7], tag[9]
                                                     };
                        if (tag[8] == null) chatViaIRCClientToolStripMenuItem.Visible = false;
                        else chatViaIRCClientToolStripMenuItem.Visible = true;

                        pbChat.Tag = strArray2;
                        pbChat.Visible = true;
                        if (strArray2[0] == "chat_justintv") {
                            pbChat.Text = "Justin.TV";
                            chatViaIRCClientToolStripMenuItem.Visible = false;
                        } else {
                            pbChat.Text = "Web Chat";
                            chatViaIRCClientToolStripMenuItem.Visible = true;
                        }
                        toolStripDropDownButton1.Visible = true;
                    } else {
                        toolStripDropDownButton1.Visible = false;
                    }
                    if (StreamDesk.Properties.Settings.Default.VideoResize) {
                        int getWebBoundsWidth;
                        if (sContainer.Panel1Collapsed == true) {
                            getWebBoundsWidth = 0;
                        } else {
                            getWebBoundsWidth = tvStreams.Width + 3;
                        }
                        int getWidth = int.Parse (tag[2].Split ('x')[0]);
                        int getHeight = int.Parse (tag[2].Split ('x')[1]);
                        Height = (getHeight + 46) + 36;
                        Width = (getWidth + getWebBoundsWidth) + 16;
                    }
                }
            }
        }

        private void updateStreamListToolStripMenuItem_Click (object sender, EventArgs e) {
            new Updator ().ShowDialog ();
            ReadStreams ();
        }

        private void quitToolStripMenuItem_Click (object sender, EventArgs e) {
            Application.Exit ();
        }

        private void treeMenuToolStripMenuItem_Click (object sender, EventArgs e) {
            if (treeMenuToolStripMenuItem.Checked == false) treeMenuToolStripMenuItem.Checked = true;
            else treeMenuToolStripMenuItem.Checked = false;
            sContainer.Panel1Collapsed = Reverse (treeMenuToolStripMenuItem.Checked);
            StreamDesk.Properties.Settings.Default.ShowTreeView = treeMenuToolStripMenuItem.Checked;
            if (treeMenuToolStripMenuItem.Checked == true) Width += tvStreams.Width + 3;
            else Width -= tvStreams.Width + 3;
        }

        private bool Reverse (bool p) {
            if (p) {
                return false;
            } else {
                return true;
            }
        }

        private void tvStreams_AfterSelect (object sender, TreeViewEventArgs e) {}

        private void pbChat_MouseEnter (object sender, EventArgs e) {}

        private void refreshStreamListToolStripMenuItem_Click (object sender, EventArgs e) {
            ReadStreams ();
        }

        private void lblActiveDesc_Click (object sender, EventArgs e) {}

        private void lblChatType_Click (object sender, EventArgs e) {}

        private void toolStripButton3_Click (object sender, EventArgs e) {}

        private void chatViaIRCClientToolStripMenuItem_Click (object sender, EventArgs e) {
            OpenChat (pbChat.Tag, 1);
        }

        private void webChatToolStripMenuItem_Click (object sender, EventArgs e) {
            OpenChat(new string[] { "chat_gatenetirc", "streamdesk", "irc.gatenetirc.com" }, 0);
        }

        private void iRCChatToolStripMenuItem_Click (object sender, EventArgs e) {
            OpenChat(new string[] { "chat_gatenetirc", "streamdesk", "irc.gatenetirc.com" }, 1);
        }

        private void newWindowToolStripMenuItem_Click (object sender, EventArgs e) {
            Process.Start (Application.ExecutablePath);
        }

        private void tvStreams_AfterSelect_1 (object sender, TreeViewEventArgs e) {}

        private void wbStream_Paint (object sender, PaintEventArgs e) {}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var searchResults = SDSearch.GetSearchParms(searchParm.Text);
            foreach (var i in searchResults)
            {
                ListViewItem item = new ListViewItem(new string[] { i.Value["Name"], i.Value["Description"], i.Value["Provider"] });
                listView1.Items.Add(item);
            }
        }

        int curHeight;
        int curWidth;

        private void standardSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowTitle = Text;
            Text = "Search - StreamDesk";
            curHeight = Height;
            curWidth = Width;
            chat = toolStripDropDownButton1.Visible;
            info = toolStripButton3.Visible;

            toolStripButton3.Visible = false;
            toolStripDropDownButton1.Visible = false;
            Height = 500;
            Width = 650;
            webBrowser.Visible = false;
            panel1.Visible = true;
            listView1.Items.Clear();
            searchParm.Text = "";
            AcceptButton = button1;
            searchParm.Focus();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Height = curHeight;
            Width = curWidth;
            Text = windowTitle;
            toolStripButton3.Visible = info;
            toolStripDropDownButton1.Visible = chat;

            webBrowser.Visible = true;
            panel1.Visible = false;
            AcceptButton = null;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)streamsToolStripMenuItem.DropDownItems[listView1.SelectedItems[0].SubItems[2].Text]).DropDownItems[listView1.SelectedItems[0].Text].PerformClick();
            webBrowser.Visible = true;
            panel1.Visible = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aboutStreamDeskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            new frmInfo(title, url, description, provider).ShowDialog();
        }

        private void aboutStreamDeskToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }

        private void updateStreamDeskStreamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Updator().ShowDialog();
            GenerateFavMenu();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            new frmMain(true).Show();
        }

        private void GenerateFavMenu()
        {
            toolStripDropDownButton5.DropDownItems.Clear();

            ToolStripMenuItem addFav = new ToolStripMenuItem("Add");
            addFav.Click += new EventHandler(addFav_Click);
            addFav.Image = Resources.add;
            toolStripDropDownButton5.DropDownItems.Add(addFav);
            ToolStripMenuItem orgFav = new ToolStripMenuItem("Delete");
            orgFav.Click += new EventHandler(orgFav_Click);
            orgFav.Image = Resources.delete;
            toolStripDropDownButton5.DropDownItems.Add(orgFav);
            toolStripDropDownButton5.DropDownItems.Add(new ToolStripSeparator());
            foreach (ToolStripMenuItem i in StreamDesk.Framework.AppCore.Settings.Instance.FavsDB.GetFavStreams(streamClick))
            {              
                toolStripDropDownButton5.DropDownItems.Add(i);
            }
        }

        void orgFav_Click(object sender, EventArgs e)
        {
            if (title != null && provider != null)
            {
                StreamDesk.Framework.AppCore.Settings.Instance.FavsDB.DeleteStream(provider, title);
                GenerateFavMenu();
            }
        }

        void addFav_Click(object sender, EventArgs e)
        {
            if (title != null && provider != null)
            {
                if (!StreamDesk.Framework.AppCore.Settings.Instance.FavsDB.StreamExist(provider, title))
                {
                    StreamDesk.Framework.AppCore.Settings.Instance.FavsDB.FavStreams.Add(new StreamDesk.Framework.AppCore.FavStream { Name = title, Provider = provider });
                    GenerateFavMenu();
                }
            }
        }
    }
}