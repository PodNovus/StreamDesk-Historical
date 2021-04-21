// Decompiled with JetBrains decompiler
// Type: KCZWidgetPack.AppCore.DownloadThread
// Assembly: StreamDesk, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8B09EE6A-FD7F-4C1A-9420-AB0346F1CF78
// Assembly location: C:\Users\mjmanley\Downloads\Telegram Desktop\Source\Source - svn\Source - svn\branches\1.1\StreamDesk.exe

using System.IO;
using System.Windows.Forms;

namespace KCZWidgetPack.AppCore
{
  public class DownloadThread
  {
    public string _downloadUrl = "";

    public event DownloadCompleteHandler CompleteCallback;

    public event DownloadProgressHandler ProgressCallback;

    public string DownloadUrl
    {
      get => this._downloadUrl;
      set => this._downloadUrl = value;
    }

    public void Download()
    {
      if (this.CompleteCallback == null || !(this.DownloadUrl != ""))
        return;
      byte[] numArray = new WebDownload().Download(this.DownloadUrl, this.ProgressCallback);
      this.CompleteCallback(numArray);
      FileStream fileStream = File.Create(Application.UserAppDataPath + "\\streamlist.xml");
      new BinaryWriter((Stream) fileStream).Write(numArray);
      fileStream.Close();
    }
  }
}
