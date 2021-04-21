// Decompiled with JetBrains decompiler
// Type: KCZWidgetPack.AppCore.WebDownload
// Assembly: StreamDesk, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8B09EE6A-FD7F-4C1A-9420-AB0346F1CF78
// Assembly location: C:\Users\mjmanley\Downloads\Telegram Desktop\Source\Source - svn\Source - svn\branches\1.1\StreamDesk.exe

using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Threading;

namespace KCZWidgetPack.AppCore
{
  public class WebDownload
  {
    private const int BUFFER_SIZE = 1024;
    public ManualResetEvent allDone = new ManualResetEvent(false);

    public byte[] Download(string url, DownloadProgressHandler progressCB)
    {
      this.allDone.Reset();
      WebRequest webRequest = WebRequest.Create(new Uri(url));
      DownloadInfo downloadInfo = new DownloadInfo();
      downloadInfo.Request = webRequest;
      downloadInfo.ProgressCallback += progressCB;
      webRequest.BeginGetResponse(new AsyncCallback(this.ResponseCallback), (object) downloadInfo);
      this.allDone.WaitOne();
      if (downloadInfo.useFastBuffers)
        return downloadInfo.dataBufferFast;
      byte[] numArray = new byte[downloadInfo.dataBufferSlow.Count];
      for (int index = 0; index < downloadInfo.dataBufferSlow.Count; ++index)
        numArray[index] = (byte) downloadInfo.dataBufferSlow[index];
      return numArray;
    }

    private void ResponseCallback(IAsyncResult ar)
    {
      DownloadInfo asyncState = (DownloadInfo) ar.AsyncState;
      WebResponse response = asyncState.Request.EndGetResponse(ar);
      string header = response.Headers["Content-Length"];
      if (header != null)
      {
        asyncState.dataLength = Convert.ToInt32(header);
        asyncState.dataBufferFast = new byte[asyncState.dataLength];
      }
      else
      {
        asyncState.useFastBuffers = false;
        asyncState.dataBufferSlow = new ArrayList(1024);
      }
      Stream responseStream = response.GetResponseStream();
      asyncState.ResponseStream = responseStream;
      responseStream.BeginRead(asyncState.BufferRead, 0, 1024, new AsyncCallback(this.ReadCallBack), (object) asyncState);
    }

    private void ReadCallBack(IAsyncResult asyncResult)
    {
      DownloadInfo asyncState = (DownloadInfo) asyncResult.AsyncState;
      Stream responseStream = asyncState.ResponseStream;
      int length = responseStream.EndRead(asyncResult);
      if (length > 0)
      {
        if (asyncState.useFastBuffers)
        {
          Array.Copy((Array) asyncState.BufferRead, 0, (Array) asyncState.dataBufferFast, asyncState.bytesProcessed, length);
        }
        else
        {
          for (int index = 0; index < length; ++index)
            asyncState.dataBufferSlow.Add((object) asyncState.BufferRead[index]);
        }
        asyncState.bytesProcessed += length;
        if (asyncState.ProgressCallback != null)
          asyncState.ProgressCallback(asyncState.bytesProcessed, asyncState.dataLength);
        responseStream.BeginRead(asyncState.BufferRead, 0, 1024, new AsyncCallback(this.ReadCallBack), (object) asyncState);
      }
      else
      {
        responseStream.Close();
        this.allDone.Set();
      }
    }
  }
}
