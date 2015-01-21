using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternsTemplate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 formMain = new Form1();
            Requests requests = new Requests();
            Controller controller = new Controller(formMain, requests);
            Application.Run(formMain);
        }
    }
}
