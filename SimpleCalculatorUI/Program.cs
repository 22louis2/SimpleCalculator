using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCalcLibrary;

namespace SimpleCalcUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DIAdapter.PlugAdapter();
            ISimpleCalcRepository res = DIAdapter.IAdapter;

            Application.Run(new CalculatorUI(res));
        }
    }
}
