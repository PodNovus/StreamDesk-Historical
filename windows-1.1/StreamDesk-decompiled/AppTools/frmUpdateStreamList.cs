// Decompiled with JetBrains decompiler
// Type: KCZWidgetPack.AppTools.frmUpdateStreamList
// Assembly: StreamDesk, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8B09EE6A-FD7F-4C1A-9420-AB0346F1CF78
// Assembly location: C:\Users\mjmanley\Downloads\Telegram Desktop\Source\Source - svn\Source - svn\branches\1.1\StreamDesk.exe

using KCZWidgetPack.AppCore;
using KCZWidgetPack.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace KCZWidgetPack.AppTools
{
  public class frmUpdateStreamList : Form
  {
    private IContainer components;
    private Label lblTitle;
    private ProgressBar pbDownload;
    private Button btnClose;
    private CheckBox cbDoStartup;
    private bool isSilent;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.lblTitle = new Label();
      this.pbDownload = new ProgressBar();
      this.btnClose = new Button();
      this.cbDoStartup = new CheckBox();
      this.SuspendLayout();
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTitle.Location = new Point(7, 10);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new Size(214, 19);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "Updating the stream directory...";
      this.pbDownload.Location = new Point(12, 66);
      this.pbDownload.Name = "pbDownload";
      this.pbDownload.Size = new Size(209, 23);
      this.pbDownload.TabIndex = 1;
      this.btnClose.Enabled = false;
      this.btnClose.Location = new Point(233, 66);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(75, 23);
      this.btnClose.TabIndex = 2;
      this.btnClose.Text = "OK";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.cbDoStartup.AutoSize = true;
      this.cbDoStartup.Font = new Font("Calibri", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cbDoStartup.Location = new Point(13, 38);
      this.cbDoStartup.Name = "cbDoStartup";
      this.cbDoStartup.Size = new Size(201, 18);
      this.cbDoStartup.TabIndex = 3;
      this.cbDoStartup.Text = "Do this automatically on startup";
      this.cbDoStartup.UseVisualStyleBackColor = true;
      this.cbDoStartup.CheckedChanged += new EventHandler(this.cbDoStartup_CheckedChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(320, 100);
      this.ControlBox = false;
      this.Controls.Add((Control) this.cbDoStartup);
      this.Controls.Add((Control) this.btnClose);
      this.Controls.Add((Control) this.pbDownload);
      this.Controls.Add((Control) this.lblTitle);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (frmUpdateStreamList);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Stream directory update";
      this.Load += new EventHandler(this.frmUpdateStreamList_Load);
      this.Shown += new EventHandler(this.frmUpdateStreamList_Shown);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public frmUpdateStreamList(bool silent)
    {
      this.InitializeComponent();
      Control.CheckForIllegalCrossThreadCalls = false;
      this.isSilent = silent;
    }

    private void frmUpdateStreamList_Load(object sender, EventArgs e)
    {
      this.pbDownload.Minimum = 0;
      this.pbDownload.Maximum = 0;
      this.pbDownload.Value = 0;
      this.cbDoStartup.Checked = Settings.Default.GetStreamsAtStartup;
      DownloadThread downloadThread = new DownloadThread();
      downloadThread.DownloadUrl = Settings.Default.StreamUpdateURL;
      downloadThread.CompleteCallback += new DownloadCompleteHandler(this.DownloadCompleteCallback);
      downloadThread.ProgressCallback += new DownloadProgressHandler(this.DownloadProgressCallback);
      try
      {
        new Thread(new ThreadStart(downloadThread.Download)).Start();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Update failed: " + Environment.NewLine + Environment.NewLine + ex.Message, "Stream dictionary update error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void DownloadProgressCallback(int bytesSoFar, int totalBytes)
    {
      if (totalBytes != -1)
      {
        this.pbDownload.Style = ProgressBarStyle.Blocks;
        this.pbDownload.Minimum = 0;
        this.pbDownload.Maximum = totalBytes;
        this.pbDownload.Value = bytesSoFar;
      }
      else
        this.pbDownload.Style = ProgressBarStyle.Marquee;
    }

    private void DownloadCompleteCallback(byte[] dataDownloaded)
    {
      if (!this.pbDownload.Visible)
      {
        this.pbDownload.Minimum = 0;
        this.pbDownload.Value = this.pbDownload.Maximum = 1;
      }
      this.lblTitle.Text = "Stream directory updated.";
      if (this.isSilent)
        this.Close();
      else
        this.btnClose.Enabled = true;
    }

    private void frmUpdateStreamList_Shown(object sender, EventArgs e)
    {
      int num = this.isSilent ? 1 : 0;
    }

    private void btnClose_Click(object sender, EventArgs e) => this.Close();

    private void cbDoStartup_CheckedChanged(object sender, EventArgs e) => Settings.Default.GetStreamsAtStartup = this.cbDoStartup.Checked;
  }
}
