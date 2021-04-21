// Decompiled with JetBrains decompiler
// Type: KCZWidgetPack.frmMain
// Assembly: StreamDesk, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8B09EE6A-FD7F-4C1A-9420-AB0346F1CF78
// Assembly location: C:\Users\mjmanley\Downloads\Telegram Desktop\Source\Source - svn\Source - svn\branches\1.1\StreamDesk.exe

using KCZWidgetPack.AppTools;
using KCZWidgetPack.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace KCZWidgetPack
{
  public class frmMain : Form
  {
    private string AppName = "StreamDesk";
    private IContainer components;
    private TreeView tvStreams;
    private WebBrowser wbStream;
    private Label lblActiveDesc;
    private LinkLabel lblActiveTitle;
    private Panel pnlInfo;
    private ContextMenuStrip cmStreamList;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem kComputerZoneToolStripMenuItem1;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private ToolTip ttChat;
    private SplitContainer sContainer;
    private Button pbChat;
    private Label lblChatType;
    private ToolStripMenuItem updateStreamListToolStripMenuItem;
    private ToolStripMenuItem preferencesToolStripMenuItem;
    private PictureBox pbToggleStreams;

    public frmMain() => this.InitializeComponent();

    private void frmMain_Load(object sender, EventArgs e)
    {
      this.Text = this.AppName;
      this.sContainer.SplitterDistance = Settings.Default.LastSidebar;
      this.Width = Settings.Default.LastWidth;
      this.Height = Settings.Default.LastHeight;
      Rectangle workingArea = Screen.GetWorkingArea((Control) this);
      if (Settings.Default.LastTop < workingArea.Height - this.Height)
        this.Top = Settings.Default.LastTop;
      if (Settings.Default.LastLeft < workingArea.Width - this.Width)
        this.Left = Settings.Default.LastLeft;
      this.sContainer.SplitterWidth = 3;
      if (Settings.Default.GetStreamsAtStartup)
      {
        int num = (int) new frmUpdateStreamList(true).ShowDialog();
      }
      if (Settings.Default.MinSize)
        this.MinimumSize = new Size(550, 400);
      else
        this.MinimumSize = new Size(1, 1);
      this.TopMost = Settings.Default.VideoTopMost;
      this.pbChat.Visible = false;
      this.lblChatType.Visible = false;
      this.tvStreams.Height = this.sContainer.Panel1.Height;
      this.ReadStreams();
    }

    private void ReadStreams()
    {
      try
      {
        this.tvStreams.Nodes.Clear();
        XmlDocument xmlDocument = new XmlDocument();
        string filename = Application.UserAppDataPath + "\\streamlist.xml";
        xmlDocument.Load(filename);
        foreach (XmlNode selectNode in xmlDocument.SelectNodes("/streams/provider"))
        {
          TreeNode node1 = new TreeNode(selectNode.Attributes["name"].Value);
          node1.Name = selectNode.Attributes["name"].Value;
          string[] strArray1 = new string[9];
          strArray1[0] = "PROVIDER";
          strArray1[1] = selectNode.Attributes["desc"].Value;
          strArray1[2] = selectNode.Attributes["url"].Value;
          node1.Tag = (object) strArray1;
          this.tvStreams.Nodes.Add(node1);
          foreach (XmlNode childNode in selectNode.ChildNodes)
          {
            TreeNode node2 = new TreeNode(childNode.Attributes["name"].Value);
            node2.Name = childNode.Attributes["name"].Value;
            string[] strArray2 = new string[9]
            {
              "STREAM",
              childNode.ChildNodes[0].InnerText,
              childNode.ChildNodes[0].Attributes[0].Value,
              childNode.ChildNodes[1].InnerText,
              childNode.ChildNodes[2].InnerText,
              childNode.ChildNodes[3].InnerText,
              childNode.ChildNodes[4].InnerText,
              childNode.ChildNodes[5].Attributes[0].Value,
              childNode.ChildNodes[5].InnerText
            };
            node2.Tag = (object) strArray2;
            this.tvStreams.Nodes[selectNode.Attributes["name"].Value].Nodes.Add(node2);
          }
        }
        this.tvStreams.Focus();
      }
      catch (Exception ex)
      {
        if (MessageBox.Show("There is a problem with the stream dictionary: " + Environment.NewLine + Environment.NewLine + ex.Message + Environment.NewLine + Environment.NewLine + "Would you like to download a fresh copy?", "Stream Dictionary Parse Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
          return;
        int num = (int) new frmUpdateStreamList(true).ShowDialog();
        this.ReadStreams();
      }
    }

    private void tvStreams_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      string[] tag = (string[]) e.Node.Tag;
      if (!(tag[0] == "STREAM"))
        return;
      this.lblActiveTitle.Text = e.Node.Text;
      this.lblActiveTitle.Tag = (object) tag[4];
      this.lblActiveDesc.Text = tag[3];
      if (tag[2] == "embed_ustream")
      {
        this.wbStream.DocumentText = "<html><body style=\"padding: 0px; margin: 0px;\"><embed src=\"" + tag[1] + "\" width=\"100%\" height=\"100%\" flashvars=\"autoplay=true\" allowfullscreen=\"true\" pluginspage=\"http://www.macromedia.com/shockwave/download/index.cgi?P1_Prod_Version=ShockwaveFlash\" type=\"application/x-shockwave-flash\" bgcolor=\"#000000\" ></embed></body></html>";
        this.Text = this.AppName + " > " + e.Node.Parent.Text + " > " + e.Node.Text;
      }
      else if (tag[2] == "embed_justintv")
      {
        this.wbStream.DocumentText = "<html><body style=\"padding: 0px; margin: 0px;\"><object type=\"application/x-shockwave-flash\" height=\"100%\" width=\"100%\" id=\"jtv_player_flash\" data=\"http://www.justin.tv/widgets/jtv_player.swf?channel=" + tag[1] + "\" bgcolor=\"#000000\"><param name=\"allowFullScreen\" value=\"true\" /><param name=\"movie\" value=\"http://www.justin.tv/widgets/jtv_player.swf\" /><param name=\"flashvars\" value=\"channel=" + tag[1] + "&auto_play=false&start_volume=25\" /></object></body></html>";
        this.Text = this.AppName + " > " + e.Node.Parent.Text + " > " + e.Node.Text;
      }
      else if (tag[2] == "embed_generic")
      {
        this.wbStream.DocumentText = "";
        this.Text = this.AppName + " > " + e.Node.Parent.Text + " > " + e.Node.Text;
      }
      else if (tag[2] == "embed_stickam")
      {
        this.wbStream.DocumentText = "<html><body style=\"padding: 0px; margin: 0px;\"><embed src=\"" + tag[1] + "\" type=\"application/x-shockwave-flash\" width=\"100%\" height=\"100%\" scale=\"noscale\" allowScriptAccess=\"always\" allowFullScreen=\"true\"></embed></body></html>";
        this.Text = this.AppName + " > " + e.Node.Parent.Text + " > " + e.Node.Text;
      }
      else if (tag[2] == "url")
      {
        this.wbStream.Navigate(tag[1]);
        this.Text = this.AppName + " > " + e.Node.Parent.Text + " > " + e.Node.Text;
      }
      else
      {
        int num = (int) MessageBox.Show("Unrecognized stream type " + tag[2] + "!", "Stream error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.Text = this.AppName;
      }
      if (tag[7] != "none")
      {
        string[] strArray = new string[2]{ tag[7], tag[8] };
        this.pbChat.Tag = (object) strArray;
        this.pbChat.Visible = true;
        if (strArray[0] == "justintv")
          this.lblChatType.Text = "via Justin.TV";
        else if (Settings.Default.UseSystemIRC)
          this.lblChatType.Text = "via IRC";
        else
          this.lblChatType.Text = "via Web IRC";
        this.lblChatType.Visible = true;
        this.tvStreams.Height = this.sContainer.Panel1.Height - 33;
      }
      else
      {
        this.tvStreams.Height = this.sContainer.Panel1.Height;
        this.pbChat.Visible = false;
        this.lblChatType.Visible = false;
      }
      if (!Settings.Default.VideoResize)
        return;
      int num1 = this.tvStreams.Width + 20 + int.Parse(tag[5]);
      int num2 = this.pnlInfo.Height + 34 + int.Parse(tag[6]);
      if (this.Width < num1)
        this.Width = num1;
      if (this.Height >= num2)
        return;
      this.Height = num2;
    }

    private void lblActiveTitle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (!(this.lblActiveTitle.Tag.ToString() != "about:blank"))
        return;
      this.SystemBrowser(this.lblActiveTitle.Tag.ToString());
    }

    private void SystemBrowser(string url) => Process.Start(url.ToString());

    private void updateStreamListToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new frmUpdateStreamList(false).ShowDialog();
      this.ReadStreams();
    }

    private void kComputerZoneToolStripMenuItem1_Click(object sender, EventArgs e) => this.SystemBrowser("http://www.kcomputerzone.ca/");

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("      StreamDesk for Windows" + Environment.NewLine + "      http://kcomputerzone.ca/" + Environment.NewLine + Environment.NewLine + "      Version " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + Environment.NewLine + Environment.NewLine + "      Developed by David Kellaway" + Environment.NewLine + "      http://antiweasel.org/", "About", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void pbChat_MouseEnter(object sender, EventArgs e) => this.ttChat.SetToolTip((Control) this.pbChat, "Chat to other people watching this stream");

    private void OpenChat(object senderTag)
    {
      string[] strArray = (string[]) senderTag;
      if (strArray == null)
        return;
      if (strArray[0] == "justintv")
        new frmChat(strArray[0], strArray[1]).Show();
      else if (Settings.Default.UseSystemIRC)
      {
        try
        {
          if (strArray[0] != "wyldryde")
            this.SystemBrowser("irc://" + strArray[0] + "/" + strArray[1]);
          else
            this.SystemBrowser("irc://irc.wyldryde.org/" + strArray[1]);
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("      Your system does not appear to have a program" + Environment.NewLine + "      associated with the irc:// protocol." + Environment.NewLine + Environment.NewLine + "      The error given was:" + Environment.NewLine + "      " + ex.Message + Environment.NewLine + Environment.NewLine + "      You can use Web IRC by unchecking the \"use my " + Environment.NewLine + "      IRC client\" option in the preferences window.", "IRC Client Not Found");
        }
      }
      else
        new frmChat(strArray[0], strArray[1]).Show();
    }

    private void pbChat_Click(object sender, EventArgs e) => this.OpenChat(this.pbChat.Tag);

    private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.TopMost = false;
      int num = (int) new frmSettings().ShowDialog();
      if (Settings.Default.UseSystemIRC && this.lblChatType.Text == "via Web IRC")
        this.lblChatType.Text = "via IRC";
      else if (!Settings.Default.UseSystemIRC && this.lblChatType.Text == "via IRC")
        this.lblChatType.Text = "via Web IRC";
      if (Settings.Default.VideoTopMost)
        this.TopMost = true;
      if (Settings.Default.MinSize)
        this.MinimumSize = new Size(550, 400);
      else
        this.MinimumSize = new Size(1, 1);
    }

    private void pbToggleStreams_Click(object sender, EventArgs e)
    {
      if (this.sContainer.SplitterDistance != 5)
      {
        this.sContainer.SplitterDistance = 5;
        this.sContainer.SplitterWidth = 1;
        this.sContainer.Panel1.Hide();
      }
      else
      {
        this.sContainer.SplitterDistance = 170;
        this.sContainer.SplitterWidth = 3;
        this.sContainer.Panel1.Show();
      }
    }

    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.LastWidth = this.Width;
      Settings.Default.LastHeight = this.Height;
      Settings.Default.LastTop = this.Top;
      Settings.Default.LastLeft = this.Left;
      Settings.Default.LastSidebar = this.sContainer.SplitterDistance <= 100 ? 100 : this.sContainer.SplitterDistance;
      Settings.Default.Save();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMain));
      this.tvStreams = new TreeView();
      this.cmStreamList = new ContextMenuStrip(this.components);
      this.updateStreamListToolStripMenuItem = new ToolStripMenuItem();
      this.preferencesToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.kComputerZoneToolStripMenuItem1 = new ToolStripMenuItem();
      this.aboutToolStripMenuItem = new ToolStripMenuItem();
      this.wbStream = new WebBrowser();
      this.lblActiveDesc = new Label();
      this.lblActiveTitle = new LinkLabel();
      this.pnlInfo = new Panel();
      this.pbToggleStreams = new PictureBox();
      this.ttChat = new ToolTip(this.components);
      this.sContainer = new SplitContainer();
      this.lblChatType = new Label();
      this.pbChat = new Button();
      this.cmStreamList.SuspendLayout();
      this.pnlInfo.SuspendLayout();
      ((ISupportInitialize) this.pbToggleStreams).BeginInit();
      this.sContainer.Panel1.SuspendLayout();
      this.sContainer.Panel2.SuspendLayout();
      this.sContainer.SuspendLayout();
      this.SuspendLayout();
      this.tvStreams.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.tvStreams.ContextMenuStrip = this.cmStreamList;
      this.tvStreams.Location = new Point(0, 0);
      this.tvStreams.Name = "tvStreams";
      this.tvStreams.Size = new Size(181, 423);
      this.tvStreams.TabIndex = 0;
      this.tvStreams.NodeMouseClick += new TreeNodeMouseClickEventHandler(this.tvStreams_NodeMouseClick);
      this.cmStreamList.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.updateStreamListToolStripMenuItem,
        (ToolStripItem) this.preferencesToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.kComputerZoneToolStripMenuItem1,
        (ToolStripItem) this.aboutToolStripMenuItem
      });
      this.cmStreamList.Name = "cmStreamList";
      this.cmStreamList.Size = new Size(179, 98);
      this.updateStreamListToolStripMenuItem.Name = "updateStreamListToolStripMenuItem";
      this.updateStreamListToolStripMenuItem.Size = new Size(178, 22);
      this.updateStreamListToolStripMenuItem.Text = "Update stream list...";
      this.updateStreamListToolStripMenuItem.Click += new EventHandler(this.updateStreamListToolStripMenuItem_Click);
      this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
      this.preferencesToolStripMenuItem.Size = new Size(178, 22);
      this.preferencesToolStripMenuItem.Text = "Settings";
      this.preferencesToolStripMenuItem.Click += new EventHandler(this.preferencesToolStripMenuItem_Click);
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new Size(175, 6);
      this.kComputerZoneToolStripMenuItem1.Name = "kComputerZoneToolStripMenuItem1";
      this.kComputerZoneToolStripMenuItem1.Size = new Size(178, 22);
      this.kComputerZoneToolStripMenuItem1.Text = "KComputer Zone";
      this.kComputerZoneToolStripMenuItem1.Click += new EventHandler(this.kComputerZoneToolStripMenuItem1_Click);
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new Size(178, 22);
      this.aboutToolStripMenuItem.Text = "About StreamDesk";
      this.aboutToolStripMenuItem.Click += new EventHandler(this.aboutToolStripMenuItem_Click);
      this.wbStream.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.wbStream.Location = new Point(0, -1);
      this.wbStream.MinimumSize = new Size(20, 20);
      this.wbStream.Name = "wbStream";
      this.wbStream.ScriptErrorsSuppressed = true;
      this.wbStream.ScrollBarsEnabled = false;
      this.wbStream.Size = new Size(500, 412);
      this.wbStream.TabIndex = 1;
      this.lblActiveDesc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.lblActiveDesc.Font = new Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblActiveDesc.Location = new Point(42, 23);
      this.lblActiveDesc.Name = "lblActiveDesc";
      this.lblActiveDesc.Size = new Size(446, 18);
      this.lblActiveDesc.TabIndex = 3;
      this.lblActiveDesc.Text = "Nothing is playing. Select a stream from the list to the left.";
      this.lblActiveTitle.ActiveLinkColor = Color.Maroon;
      this.lblActiveTitle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.lblActiveTitle.Font = new Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblActiveTitle.LinkColor = Color.Navy;
      this.lblActiveTitle.Location = new Point(41, 6);
      this.lblActiveTitle.Name = "lblActiveTitle";
      this.lblActiveTitle.Size = new Size(449, 19);
      this.lblActiveTitle.TabIndex = 4;
      this.lblActiveTitle.TabStop = true;
      this.lblActiveTitle.Tag = (object) "about:blank";
      this.lblActiveTitle.Text = "No Stream";
      this.lblActiveTitle.VisitedLinkColor = Color.Navy;
      this.lblActiveTitle.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lblActiveTitle_LinkClicked);
      this.pnlInfo.Controls.Add((Control) this.pbToggleStreams);
      this.pnlInfo.Controls.Add((Control) this.lblActiveTitle);
      this.pnlInfo.Controls.Add((Control) this.lblActiveDesc);
      this.pnlInfo.Dock = DockStyle.Bottom;
      this.pnlInfo.Location = new Point(0, 409);
      this.pnlInfo.Name = "pnlInfo";
      this.pnlInfo.Size = new Size(500, 47);
      this.pnlInfo.TabIndex = 5;
      this.pbToggleStreams.Image = (Image) Resources.camera_video1;
      this.pbToggleStreams.Location = new Point(9, 14);
      this.pbToggleStreams.Name = "pbToggleStreams";
      this.pbToggleStreams.Size = new Size(22, 22);
      this.pbToggleStreams.TabIndex = 5;
      this.pbToggleStreams.TabStop = false;
      this.ttChat.SetToolTip((Control) this.pbToggleStreams, "Show/hide the stream list");
      this.pbToggleStreams.Click += new EventHandler(this.pbToggleStreams_Click);
      this.sContainer.Dock = DockStyle.Fill;
      this.sContainer.FixedPanel = FixedPanel.Panel1;
      this.sContainer.Location = new Point(0, 0);
      this.sContainer.Name = "sContainer";
      this.sContainer.Panel1.Controls.Add((Control) this.lblChatType);
      this.sContainer.Panel1.Controls.Add((Control) this.pbChat);
      this.sContainer.Panel1.Controls.Add((Control) this.tvStreams);
      this.sContainer.Panel1MinSize = 5;
      this.sContainer.Panel2.Controls.Add((Control) this.wbStream);
      this.sContainer.Panel2.Controls.Add((Control) this.pnlInfo);
      this.sContainer.Panel2MinSize = 5;
      this.sContainer.Size = new Size(687, 456);
      this.sContainer.SplitterDistance = 183;
      this.sContainer.TabIndex = 6;
      this.lblChatType.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.lblChatType.AutoSize = true;
      this.lblChatType.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblChatType.Location = new Point(63, 432);
      this.lblChatType.Name = "lblChatType";
      this.lblChatType.Size = new Size(73, 15);
      this.lblChatType.TabIndex = 2;
      this.lblChatType.Text = "via Web IRC";
      this.pbChat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.pbChat.Image = (Image) Resources.comment;
      this.pbChat.ImageAlign = ContentAlignment.MiddleLeft;
      this.pbChat.Location = new Point(5, 428);
      this.pbChat.Name = "pbChat";
      this.pbChat.Size = new Size(54, 23);
      this.pbChat.TabIndex = 1;
      this.pbChat.Text = "Chat";
      this.pbChat.TextAlign = ContentAlignment.MiddleRight;
      this.pbChat.UseVisualStyleBackColor = true;
      this.pbChat.Click += new EventHandler(this.pbChat_Click);
      this.pbChat.MouseEnter += new EventHandler(this.pbChat_MouseEnter);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(687, 456);
      this.Controls.Add((Control) this.sContainer);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MinimumSize = new Size(550, 400);
      this.Name = nameof (frmMain);
      this.Text = "Stream Player";
      this.Load += new EventHandler(this.frmMain_Load);
      this.FormClosing += new FormClosingEventHandler(this.frmMain_FormClosing);
      this.cmStreamList.ResumeLayout(false);
      this.pnlInfo.ResumeLayout(false);
      ((ISupportInitialize) this.pbToggleStreams).EndInit();
      this.sContainer.Panel1.ResumeLayout(false);
      this.sContainer.Panel1.PerformLayout();
      this.sContainer.Panel2.ResumeLayout(false);
      this.sContainer.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
