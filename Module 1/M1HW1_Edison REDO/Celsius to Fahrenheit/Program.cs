using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
* 8/24/21
* CSC 253
* Brandon Edison
* This program is going to take the celsius temperature 0-20 and convert it into fahrenheit in a list box format using windows form
*/
namespace Celsius_to_Fahrenheit
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
            Application.Run(new Form1());
        }
    }
}
