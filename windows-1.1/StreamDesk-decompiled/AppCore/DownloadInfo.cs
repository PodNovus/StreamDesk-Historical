// Decompiled with JetBrains decompiler
// Type: KCZWidgetPack.AppCore.DownloadInfo
// Assembly: StreamDesk, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8B09EE6A-FD7F-4C1A-9420-AB0346F1CF78
// Assembly location: C:\Users\mjmanley\Downloads\Telegram Desktop\Source\Source - svn\Source - svn\branches\1.1\StreamDesk.exe

using System.Collections;
using System.IO;
using System.Net;

namespace KCZWidgetPack.AppCore
{
  public class DownloadInfo
  {
    private const int BufferSize = 1024;
    public byte[] BufferRead;
    public bool useFastBuffers;
    public byte[] dataBufferFast;
    public ArrayList dataBufferSlow;
    public int dataLength;
    public int bytesProcessed;
    public WebRequest Request;
    public Stream ResponseStream;
    public DownloadProgressHandler ProgressCallback;

    public DownloadInfo()
    {
      this.BufferRead = new byte[1024];
      this.Request = (WebRequest) null;
      this.dataLength = -1;
      this.bytesProcessed = 0;
      this.useFastBuffers = true;
    }
  }
}
