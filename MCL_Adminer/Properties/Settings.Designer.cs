using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MCL_Adminer.Properties
{
	// Token: 0x02000011 RID: 17
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00006EE8 File Offset: 0x000050E8
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00006F00 File Offset: 0x00005100
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("server=localhost;user id=mcl_db;password=MidlakesDB1.;persistsecurityinfo=True;database=mcl_db;allowuservariables=True")]
		public string mcl_dbConnectionString
		{
			get
			{
				return (string)this["mcl_dbConnectionString"];
			}
		}

		// Token: 0x04000074 RID: 116
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
