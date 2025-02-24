using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
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
            mutex.ReleaseMutex();
            if (!createdNew) return;

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Bomb());
        }
    }
}
