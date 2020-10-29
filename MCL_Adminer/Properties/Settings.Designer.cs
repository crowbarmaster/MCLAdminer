using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MCL_Adminer.Properties
{
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

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

		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
