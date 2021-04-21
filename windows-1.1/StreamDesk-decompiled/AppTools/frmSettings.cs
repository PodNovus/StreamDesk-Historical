// Decompiled with JetBrains decompiler
// Type: KCZWidgetPack.AppTools.frmSettings
// Assembly: StreamDesk, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8B09EE6A-FD7F-4C1A-9420-AB0346F1CF78
// Assembly location: C:\Users\mjmanley\Downloads\Telegram Desktop\Source\Source - svn\Source - svn\branches\1.1\StreamDesk.exe

using KCZWidgetPack.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KCZWidgetPack.AppTools
{
  public class frmSettings : Form
  {
    private IContainer components;
    private CheckBox cbUpdateOnStartup;
    private Label label1;
    private CheckBox cbSystemIRC;
    private Label label2;
    private Button btnOK;
    private Button btnAdvanced;
    private Label label3;
    private TextBox tbCustomDirectory;
    private CheckBox cbAlwaysOnTop;
    private Label label4;
    private CheckBox cbResize;
    private Label label5;
    private Button btnResetDict;
    private CheckBox cbMinSize;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.cbUpdateOnStartup = new CheckBox();
      this.label1 = new Label();
      this.cbSystemIRC = new CheckBox();
      this.label2 = new Label();
      this.btnOK = new Button();
      this.btnAdvanced = new Button();
      this.label3 = new Label();
      this.tbCustomDirectory = new TextBox();
      this.cbAlwaysOnTop = new CheckBox();
      this.label4 = new Label();
      this.cbResize = new CheckBox();
      this.label5 = new Label();
      this.btnResetDict = new Button();
      this.cbMinSize = new CheckBox();
      this.SuspendLayout();
      this.cbUpdateOnStartup.AutoSize = true;
      this.cbUpdateOnStartup.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cbUpdateOnStartup.Location = new Point(13, 13);
      this.cbUpdateOnStartup.Margin = new Padding(4, 3, 4, 3);
      this.cbUpdateOnStartup.Name = "cbUpdateOnStartup";
      this.cbUpdateOnStartup.Size = new Size(173, 19);
      this.cbUpdateOnStartup.TabIndex = 0;
      this.cbUpdateOnStartup.Text = "Update streams on startup";
      this.cbUpdateOnStartup.UseVisualStyleBackColor = true;
      this.cbUpdateOnStartup.CheckedChanged += new EventHandler(this.cbUpdateOnStartup_CheckedChanged);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(28, 30);
      this.label1.Name = "label1";
      this.label1.Size = new Size(312, 30);
      this.label1.TabIndex = 1;
      this.label1.Text = "If you enable this setting, the application will download\r\na new list of streams every time it starts.";
      this.cbSystemIRC.AutoSize = true;
      this.cbSystemIRC.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cbSystemIRC.Location = new Point(12, 71);
      this.cbSystemIRC.Name = "cbSystemIRC";
      this.cbSystemIRC.Size = new Size(119, 19);
      this.cbSystemIRC.TabIndex = 2;
      this.cbSystemIRC.Text = "Use my IRC client";
      this.cbSystemIRC.UseVisualStyleBackColor = true;
      this.cbSystemIRC.CheckedChanged += new EventHandler(this.cbSystemIRC_CheckedChanged);
      this.label2.AutoSize = true;
      this.label2.Location = new Point(28, 88);
      this.label2.Name = "label2";
      this.label2.Size = new Size(297, 30);
      this.label2.TabIndex = 3;
      this.label2.Text = "Opens IRC-based chat using your preferred IRC client\r\ninstead of the web chat window.";
      this.btnOK.Location = new Point(274, 227);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new Size(75, 23);
      this.btnOK.TabIndex = 4;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new EventHandler(this.button1_Click);
      this.btnAdvanced.Location = new Point(12, 227);
      this.btnAdvanced.Name = "btnAdvanced";
      this.btnAdvanced.Size = new Size(95, 23);
      this.btnAdvanced.TabIndex = 5;
      this.btnAdvanced.Text = "Advanced >";
      this.btnAdvanced.UseVisualStyleBackColor = true;
      this.btnAdvanced.Click += new EventHandler(this.btnAdvanced_Click);
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(11, 265);
      this.label3.Name = "label3";
      this.label3.Size = new Size(152, 15);
      this.label3.TabIndex = 6;
      this.label3.Text = "Custom stream dictionary:";
      this.tbCustomDirectory.Location = new Point(12, 283);
      this.tbCustomDirectory.Name = "tbCustomDirectory";
      this.tbCustomDirectory.Size = new Size(259, 23);
      this.tbCustomDirectory.TabIndex = 7;
      this.cbAlwaysOnTop.AutoSize = true;
      this.cbAlwaysOnTop.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cbAlwaysOnTop.Location = new Point(13, 131);
      this.cbAlwaysOnTop.Name = "cbAlwaysOnTop";
      this.cbAlwaysOnTop.Size = new Size(173, 19);
      this.cbAlwaysOnTop.TabIndex = 8;
      this.cbAlwaysOnTop.Text = "Keep video window on top";
      this.cbAlwaysOnTop.UseVisualStyleBackColor = true;
      this.cbAlwaysOnTop.CheckedChanged += new EventHandler(this.cbAlwaysOnTop_CheckedChanged);
      this.label4.AutoSize = true;
      this.label4.Location = new Point(28, 148);
      this.label4.Name = "label4";
      this.label4.Size = new Size(269, 15);
      this.label4.TabIndex = 9;
      this.label4.Text = "Keeps the video player on top of other windows.";
      this.cbResize.AutoSize = true;
      this.cbResize.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cbResize.Location = new Point(14, 175);
      this.cbResize.Name = "cbResize";
      this.cbResize.Size = new Size(157, 19);
      this.cbResize.TabIndex = 10;
      this.cbResize.Text = "Auto-size video window";
      this.cbResize.UseVisualStyleBackColor = true;
      this.cbResize.CheckedChanged += new EventHandler(this.cbResize_CheckedChanged);
      this.label5.AutoSize = true;
      this.label5.Location = new Point(28, 193);
      this.label5.Name = "label5";
      this.label5.Size = new Size(324, 15);
      this.label5.TabIndex = 11;
      this.label5.Text = "Automatically grow the video window to fit high-res video.";
      this.btnResetDict.Location = new Point(277, 283);
      this.btnResetDict.Name = "btnResetDict";
      this.btnResetDict.Size = new Size(72, 23);
      this.btnResetDict.TabIndex = 12;
      this.btnResetDict.Text = "Default";
      this.btnResetDict.UseVisualStyleBackColor = true;
      this.btnResetDict.Click += new EventHandler(this.btnResetDict_Click);
      this.cbMinSize.AutoSize = true;
      this.cbMinSize.Location = new Point(12, 316);
      this.cbMinSize.Name = "cbMinSize";
      this.cbMinSize.Size = new Size(265, 19);
      this.cbMinSize.TabIndex = 13;
      this.cbMinSize.Text = "Limit the minimum size of the video window";
      this.cbMinSize.UseVisualStyleBackColor = true;
      this.cbMinSize.CheckedChanged += new EventHandler(this.cbMinSize_CheckedChanged);
      this.AutoScaleDimensions = new SizeF(7f, 15f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(361, 346);
      this.Controls.Add((Control) this.cbMinSize);
      this.Controls.Add((Control) this.btnResetDict);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.cbResize);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.cbAlwaysOnTop);
      this.Controls.Add((Control) this.tbCustomDirectory);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.btnAdvanced);
      this.Controls.Add((Control) this.btnOK);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.cbSystemIRC);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.cbUpdateOnStartup);
      this.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Margin = new Padding(4, 3, 4, 3);
      this.Name = nameof (frmSettings);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "StreamDesk Setup";
      this.Load += new EventHandler(this.frmSettings_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public frmSettings() => this.InitializeComponent();

    private void btnAdvanced_Click(object sender, EventArgs e)
    {
      if (this.Height == 370)
      {
        this.Height = 285;
        this.btnAdvanced.Text = "Advanced >";
      }
      else
      {
        this.Height = 370;
        this.btnAdvanced.Text = "Advanced <";
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Settings.Default.StreamUpdateURL = this.tbCustomDirectory.Text;
      Settings.Default.Save();
      this.Close();
    }

    private void frmSettings_Load(object sender, EventArgs e)
    {
      this.cbUpdateOnStartup.Checked = Settings.Default.GetStreamsAtStartup;
      this.cbSystemIRC.Checked = Settings.Default.UseSystemIRC;
      this.tbCustomDirectory.Text = Settings.Default.StreamUpdateURL;
      this.cbAlwaysOnTop.Checked = Settings.Default.VideoTopMost;
      this.cbResize.Checked = Settings.Default.VideoResize;
      this.cbMinSize.Checked = Settings.Default.MinSize;
      this.Height = 285;
    }

    private void cbUpdateOnStartup_CheckedChanged(object sender, EventArgs e) => Settings.Default.GetStreamsAtStartup = this.cbUpdateOnStartup.Checked;

    private void cbSystemIRC_CheckedChanged(object sender, EventArgs e) => Settings.Default.UseSystemIRC = this.cbSystemIRC.Checked;

    private void btnResetDict_Click(object sender, EventArgs e) => this.tbCustomDirectory.Text = "http://kcomputerzone.ca/streams.xml";

    private void cbMinSize_CheckedChanged(object sender, EventArgs e) => Settings.Default.MinSize = this.cbMinSize.Checked;

    private void cbResize_CheckedChanged(object sender, EventArgs e) => Settings.Default.VideoResize = this.cbResize.Checked;

    private void cbAlwaysOnTop_CheckedChanged(object sender, EventArgs e) => Settings.Default.VideoTopMost = this.cbAlwaysOnTop.Checked;
  }
}
