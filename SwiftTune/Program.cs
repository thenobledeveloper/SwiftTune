using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftTune
{
    internal static class Program
    {
        [DllImport("shcore.dll")]
        private static extern int SetProcessDpiAwareness(int value);

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        [STAThread]
        static void Main()
        {
            try
            {
                SetProcessDpiAwareness(2);
            }
            catch
            {
                try
                {
                    SetProcessDPIAware();
                }
                catch
                {
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigurationManager.EnsureConfigExists();

            string showHello = ConfigurationManager.ReadSetting("ShowHelloScreen");

            if (showHello != null && showHello.Equals("True", StringComparison.OrdinalIgnoreCase))
            {
                Application.Run(new FirstHelloScreen());
            }
            else
            {
                Application.Run(new OptimizationLevelsScreen());
            }
        }
    }
}