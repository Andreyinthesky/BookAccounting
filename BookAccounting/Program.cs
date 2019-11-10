using System;
using System.Threading;
using System.Windows.Forms;
using BookAccounting.Forms;

namespace BookAccounting
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var mutex = new Mutex(true, "BookAccounting", out bool createdNew);

            if (!createdNew)
            {
                MessageBox.Show("You can run only one copy of the app");
                return;
            }

            mutex.WaitOne();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
            mutex.ReleaseMutex();
        }
    }
}
