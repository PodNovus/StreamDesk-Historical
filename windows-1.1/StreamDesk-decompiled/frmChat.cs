// Decompiled with JetBrains decompiler
// Type: KCZWidgetPack.frmChat
// Assembly: StreamDesk, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8B09EE6A-FD7F-4C1A-9420-AB0346F1CF78
// Assembly location: C:\Users\mjmanley\Downloads\Telegram Desktop\Source\Source - svn\Source - svn\branches\1.1\StreamDesk.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KCZWidgetPack
{
  public class frmChat : Form
  {
    private IContainer components;
    private WebBrowser wbWebIRC;
    private string chatHTML = "<strong>Please wait...</strong>";

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmChat));
      this.wbWebIRC = new WebBrowser();
      this.SuspendLayout();
      this.wbWebIRC.Dock = DockStyle.Fill;
      this.wbWebIRC.Location = new Point(0, 0);
      this.wbWebIRC.MinimumSize = new Size(20, 20);
      this.wbWebIRC.Name = "wbWebIRC";
      this.wbWebIRC.Size = new Size(601, 326);
      this.wbWebIRC.TabIndex = 1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(601, 326);
      this.Controls.Add((Control) this.wbWebIRC);
      this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmChat);
      this.Text = "StreamDesk Chat";
      this.Load += new EventHandler(this.frmChat_Load);
      this.ResumeLayout(false);
    }

    public frmChat(string chatServer, string chatChannel)
    {
      this.InitializeComponent();
      if (chatServer == "wyldryde")
        this.chatHTML = "<html><body style=\"padding: 0px; margin: 0px;\"><iframe scrolling=\"no\" frameborder=\"0\" height=\"100%\" width=\"100%\" name=\"flashchat\" src=\"http://flashirc.wyldryde.org/getchat.php?channel=" + chatChannel + "\"></iframe></body></html>";
      else if (chatServer == "justintv")
        this.chatHTML = "<html><body style=\"padding: 0px; margin: 0px;\"><object type=\"application/x-shockwave-flash\" height=\"100%\" width=\"100%\" id=\"jtv_chat_flash\" data=\"http://www.justin.tv/widgets/jtv_chat.swf?channel=" + chatChannel + "\" bgcolor=\"#000000\"><param name=\"allowFullScreen\" value=\"true\" /><param name=\"movie\" value=\"http://www.justin.tv/widgets/jtv_chat.swf\" /><param name=\"flashvars\" value=\"channel=" + chatChannel + "\" /></object></body></html>";
      else
        this.chatHTML = "<html><body style=\"padding: 0px; margin: 0px;\"><embed width=\"100%\" height=\"100%\" type=\"application/x-shockwave-flash\" flashvars=\"channel=#" + chatChannel + "&server=" + chatServer + "\" pluginspage=\"http://www.adobe.com/go/getflashplayer\" src=\"http://www.ustream.tv/IrcClient.swf\" allowfullscreen=\"true\" /></body></html>";
    }

    private void frmChat_Load(object sender, EventArgs e) => this.wbWebIRC.DocumentText = this.chatHTML;
  }
}
