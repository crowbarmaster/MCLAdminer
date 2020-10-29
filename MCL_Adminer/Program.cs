using System;
using System.Windows.Forms;

namespace MCL_Adminer
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FormProvider.MainMenu);
        }
    }
}
