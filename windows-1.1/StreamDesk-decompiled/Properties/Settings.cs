// Decompiled with JetBrains decompiler
// Type: KCZWidgetPack.Properties.Settings
// Assembly: StreamDesk, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8B09EE6A-FD7F-4C1A-9420-AB0346F1CF78
// Assembly location: C:\Users\mjmanley\Downloads\Telegram Desktop\Source\Source - svn\Source - svn\branches\1.1\StreamDesk.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KCZWidgetPack.Properties
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
  [CompilerGenerated]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default => Settings.defaultInstance;

    [DefaultSettingValue("http://kcomputerzone.ca/streams.xml")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public string StreamUpdateURL
    {
      get => (string) this[nameof (StreamUpdateURL)];
      set => this[nameof (StreamUpdateURL)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("True")]
    [DebuggerNonUserCode]
    public bool GetStreamsAtStartup
    {
      get => (bool) this[nameof (GetStreamsAtStartup)];
      set => this[nameof (GetStreamsAtStartup)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    public bool UseSystemIRC
    {
      get => (bool) this[nameof (UseSystemIRC)];
      set => this[nameof (UseSystemIRC)] = (object) value;
    }

    [DefaultSettingValue("False")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool VideoTopMost
    {
      get => (bool) this[nameof (VideoTopMost)];
      set => this[nameof (VideoTopMost)] = (object) value;
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("True")]
    [UserScopedSetting]
    public bool VideoResize
    {
      get => (bool) this[nameof (VideoResize)];
      set => this[nameof (VideoResize)] = (object) value;
    }

    [DefaultSettingValue("True")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool MinSize
    {
      get => (bool) this[nameof (MinSize)];
      set => this[nameof (MinSize)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("703")]
    public int LastWidth
    {
      get => (int) this[nameof (LastWidth)];
      set => this[nameof (LastWidth)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("492")]
    public int LastHeight
    {
      get => (int) this[nameof (LastHeight)];
      set => this[nameof (LastHeight)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("170")]
    public int LastSidebar
    {
      get => (int) this[nameof (LastSidebar)];
      set => this[nameof (LastSidebar)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("32")]
    public int LastTop
    {
      get => (int) this[nameof (LastTop)];
      set => this[nameof (LastTop)] = (object) value;
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("32")]
    [UserScopedSetting]
    public int LastLeft
    {
      get => (int) this[nameof (LastLeft)];
      set => this[nameof (LastLeft)] = (object) value;
    }
  }
}
