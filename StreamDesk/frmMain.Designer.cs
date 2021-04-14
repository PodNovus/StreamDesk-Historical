namespace StreamDesk
{
    using StreamDesk.AppTools;
    using StreamDesk.Properties;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Reflection;
    using System.Windows.Forms;
    using System.Xml;

    partial class frmMain
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tvStreams = new System.Windows.Forms.TreeView();
            this.ttChat = new System.Windows.Forms.ToolTip(this.components);
            this.sContainer = new System.Windows.Forms.SplitContainer();
            this.wbStream = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchParm = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.streamsToolStripMenuItem = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.pbChat = new System.Windows.Forms.ToolStripMenuItem();
            this.chatViaIRCClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.standardSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.treeMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.updateStreamDeskStreamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.liveHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iRCChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutStreamDeskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.sContainer)).BeginInit();
            this.sContainer.Panel1.SuspendLayout();
            this.sContainer.Panel2.SuspendLayout();
            this.sContainer.SuspendLayout();
            this.wbStream.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvStreams
            // 
            this.tvStreams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvStreams.Location = new System.Drawing.Point(0, 0);
            this.tvStreams.Name = "tvStreams";
            this.tvStreams.Size = new System.Drawing.Size(183, 431);
            this.tvStreams.TabIndex = 0;
            this.tvStreams.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvStreams_AfterSelect_1);
            this.tvStreams.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvStreams_NodeMouseClick);
            // 
            // sContainer
            // 
            this.sContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sContainer.Location = new System.Drawing.Point(0, 25);
            this.sContainer.Name = "sContainer";
            // 
            // sContainer.Panel1
            // 
            this.sContainer.Panel1.Controls.Add(this.tvStreams);
            this.sContainer.Panel1MinSize = 5;
            // 
            // sContainer.Panel2
            // 
            this.sContainer.Panel2.Controls.Add(this.wbStream);
            this.sContainer.Panel2MinSize = 5;
            this.sContainer.Size = new System.Drawing.Size(687, 431);
            this.sContainer.SplitterDistance = 183;
            this.sContainer.TabIndex = 6;
            // 
            // wbStream
            // 
            this.wbStream.Controls.Add(this.panel1);
            this.wbStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbStream.Location = new System.Drawing.Point(0, 0);
            this.wbStream.Name = "wbStream";
            this.wbStream.Size = new System.Drawing.Size(500, 431);
            this.wbStream.TabIndex = 6;
            this.wbStream.Paint += new System.Windows.Forms.PaintEventHandler(this.wbStream_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 431);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(500, 406);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 172;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 236;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Provider";
            this.columnHeader3.Width = 174;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.searchParm,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(500, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Search";
            // 
            // searchParm
            // 
            this.searchParm.Name = "searchParm";
            this.searchParm.Size = new System.Drawing.Size(300, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::StreamDesk.Properties.Resources.find;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Search";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::StreamDesk.Properties.Resources.cross;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Close Search";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.streamsToolStripMenuItem,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton4,
            this.toolStripButton3,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(687, 25);
            this.toolStrip2.TabIndex = 11;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // streamsToolStripMenuItem
            // 
            this.streamsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.streamsToolStripMenuItem.Image = global::StreamDesk.Properties.Resources.webcam;
            this.streamsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.streamsToolStripMenuItem.Name = "streamsToolStripMenuItem";
            this.streamsToolStripMenuItem.Size = new System.Drawing.Size(29, 22);
            this.streamsToolStripMenuItem.Text = "Streams";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbChat,
            this.chatViaIRCClientToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::StreamDesk.Properties.Resources.comment;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "Chat";
            // 
            // pbChat
            // 
            this.pbChat.Image = global::StreamDesk.Properties.Resources.internet_group_chat;
            this.pbChat.Name = "pbChat";
            this.pbChat.Size = new System.Drawing.Size(152, 22);
            this.pbChat.Text = "pbChat";
            this.pbChat.Click += new System.EventHandler(this.pbChat_Click);
            // 
            // chatViaIRCClientToolStripMenuItem
            // 
            this.chatViaIRCClientToolStripMenuItem.Image = global::StreamDesk.Properties.Resources.internet_group_chat;
            this.chatViaIRCClientToolStripMenuItem.Name = "chatViaIRCClientToolStripMenuItem";
            this.chatViaIRCClientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chatViaIRCClientToolStripMenuItem.Text = "IRC Client";
            this.chatViaIRCClientToolStripMenuItem.Click += new System.EventHandler(this.chatViaIRCClientToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardSearchToolStripMenuItem});
            this.toolStripDropDownButton4.Image = global::StreamDesk.Properties.Resources.find;
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton4.Text = "Search";
            // 
            // standardSearchToolStripMenuItem
            // 
            this.standardSearchToolStripMenuItem.Image = global::StreamDesk.Properties.Resources.page_white_find;
            this.standardSearchToolStripMenuItem.Name = "standardSearchToolStripMenuItem";
            this.standardSearchToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.standardSearchToolStripMenuItem.Text = "Standard Search";
            this.standardSearchToolStripMenuItem.Click += new System.EventHandler(this.standardSearchToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::StreamDesk.Properties.Resources.information;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Stream Information";
            this.toolStripButton3.Visible = false;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click_1);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treeMenuToolStripMenuItem});
            this.toolStripDropDownButton2.Image = global::StreamDesk.Properties.Resources.wrench_orange;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton2.Text = "Settings";
            // 
            // treeMenuToolStripMenuItem
            // 
            this.treeMenuToolStripMenuItem.Name = "treeMenuToolStripMenuItem";
            this.treeMenuToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.treeMenuToolStripMenuItem.Text = "Show Tree Menu";
            this.treeMenuToolStripMenuItem.Click += new System.EventHandler(this.treeMenuToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateStreamDeskStreamsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.liveHelpToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutStreamDeskToolStripMenuItem});
            this.toolStripDropDownButton3.Image = global::StreamDesk.Properties.Resources.help;
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton3.Text = "Help";
            // 
            // updateStreamDeskStreamsToolStripMenuItem
            // 
            this.updateStreamDeskStreamsToolStripMenuItem.Name = "updateStreamDeskStreamsToolStripMenuItem";
            this.updateStreamDeskStreamsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.updateStreamDeskStreamsToolStripMenuItem.Text = "Update Stream List";
            this.updateStreamDeskStreamsToolStripMenuItem.Click += new System.EventHandler(this.updateStreamDeskStreamsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // liveHelpToolStripMenuItem
            // 
            this.liveHelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.webChatToolStripMenuItem,
            this.iRCChatToolStripMenuItem});
            this.liveHelpToolStripMenuItem.Name = "liveHelpToolStripMenuItem";
            this.liveHelpToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.liveHelpToolStripMenuItem.Text = "Live Help";
            // 
            // webChatToolStripMenuItem
            // 
            this.webChatToolStripMenuItem.Image = global::StreamDesk.Properties.Resources.internet_group_chat;
            this.webChatToolStripMenuItem.Name = "webChatToolStripMenuItem";
            this.webChatToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.webChatToolStripMenuItem.Text = "Web Chat";
            this.webChatToolStripMenuItem.Click += new System.EventHandler(this.webChatToolStripMenuItem_Click);
            // 
            // iRCChatToolStripMenuItem
            // 
            this.iRCChatToolStripMenuItem.Image = global::StreamDesk.Properties.Resources.internet_group_chat;
            this.iRCChatToolStripMenuItem.Name = "iRCChatToolStripMenuItem";
            this.iRCChatToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.iRCChatToolStripMenuItem.Text = "IRC Chat";
            this.iRCChatToolStripMenuItem.Click += new System.EventHandler(this.iRCChatToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 6);
            // 
            // aboutStreamDeskToolStripMenuItem
            // 
            this.aboutStreamDeskToolStripMenuItem.Name = "aboutStreamDeskToolStripMenuItem";
            this.aboutStreamDeskToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.aboutStreamDeskToolStripMenuItem.Text = "About StreamDesk...";
            this.aboutStreamDeskToolStripMenuItem.Click += new System.EventHandler(this.aboutStreamDeskToolStripMenuItem_Click_1);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(687, 456);
            this.Controls.Add(this.sContainer);
            this.Controls.Add(this.toolStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Stream Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.sContainer.Panel1.ResumeLayout(false);
            this.sContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sContainer)).EndInit();
            this.sContainer.ResumeLayout(false);
            this.wbStream.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Panel wbStream;
        private Panel panel1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox searchParm;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStrip toolStrip2;
        private ToolStripDropDownButton streamsToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem pbChat;
        private ToolStripMenuItem chatViaIRCClientToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton4;
        private ToolStripMenuItem standardSearchToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem treeMenuToolStripMenuItem;
        private ToolStripButton toolStripButton3;
        private Button button1;
        private ToolStripDropDownButton toolStripDropDownButton3;
        private ToolStripMenuItem aboutStreamDeskToolStripMenuItem;
        private ToolStripMenuItem updateStreamDeskStreamsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem liveHelpToolStripMenuItem;
        private ToolStripMenuItem webChatToolStripMenuItem;
        private ToolStripMenuItem iRCChatToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
    }
}

