using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
* 9/19/21
* CSC 253
* Brandon Edison
* This program is going to accept a user integer and use that integer to write to a file with a random number. 
*/
namespace WinUI
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
            Application.Run(new RandomNumFileWriterForm());
        }
    }
}
