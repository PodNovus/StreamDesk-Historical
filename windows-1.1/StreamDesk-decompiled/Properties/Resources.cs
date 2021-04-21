// Decompiled with JetBrains decompiler
// Type: KCZWidgetPack.Properties.Resources
// Assembly: StreamDesk, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8B09EE6A-FD7F-4C1A-9420-AB0346F1CF78
// Assembly location: C:\Users\mjmanley\Downloads\Telegram Desktop\Source\Source - svn\Source - svn\branches\1.1\StreamDesk.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace KCZWidgetPack.Properties
{
  [CompilerGenerated]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
  [DebuggerNonUserCode]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) KCZWidgetPack.Properties.Resources.resourceMan, (object) null))
          KCZWidgetPack.Properties.Resources.resourceMan = new ResourceManager("KCZWidgetPack.Properties.Resources", typeof (KCZWidgetPack.Properties.Resources).Assembly);
        return KCZWidgetPack.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => KCZWidgetPack.Properties.Resources.resourceCulture;
      set => KCZWidgetPack.Properties.Resources.resourceCulture = value;
    }

    internal static Bitmap camera_video => (Bitmap) KCZWidgetPack.Properties.Resources.ResourceManager.GetObject("camera-video", KCZWidgetPack.Properties.Resources.resourceCulture);

    internal static Bitmap camera_video1 => (Bitmap) KCZWidgetPack.Properties.Resources.ResourceManager.GetObject("camera-video1", KCZWidgetPack.Properties.Resources.resourceCulture);

    internal static Bitmap comment => (Bitmap) KCZWidgetPack.Properties.Resources.ResourceManager.GetObject(nameof (comment), KCZWidgetPack.Properties.Resources.resourceCulture);

    internal static Bitmap internet_group_chat => (Bitmap) KCZWidgetPack.Properties.Resources.ResourceManager.GetObject("internet-group-chat", KCZWidgetPack.Properties.Resources.resourceCulture);
  }
}
