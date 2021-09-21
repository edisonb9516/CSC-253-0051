using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/**
* 9/19/21
* CSC 253
* Brandon Edison
* This program is going to accept the random number file from the previous assignment and then create the total of those
* numbers and also display the number of items in the file. 
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
            Application.Run(new RandomFileReaderForm());
        }
    }
}
