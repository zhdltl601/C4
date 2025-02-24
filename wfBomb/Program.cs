using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace wfBomb
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            string currentProcessName = Process.GetCurrentProcess().ProcessName;
            Mutex mutex = new Mutex(true, currentProcessName, out bool createdNew);
            if (!createdNew) return;

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Bomb());
            mutex.Dispose();
        }
    }
}
