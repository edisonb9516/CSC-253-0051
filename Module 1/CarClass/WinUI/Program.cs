using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
* 9/5/21
* CSC 253
* Brandon Edison
* This program is going to use window forms to create a car object and allow the user to "drive" by accelerating and braking by pushing buttons.    
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
            Application.Run(new CarClassSim());
        }
    }
}
