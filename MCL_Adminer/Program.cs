using System;
using System.Windows.Forms;

namespace MCL_Adminer
{
	// Token: 0x0200000E RID: 14
	internal static class Program
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00006BB1 File Offset: 0x00004DB1
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(FormProvider.MainMenu);
		}
	}
}
