using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
* 9/3//21
* CSC 253
* Brandon Edison
* This program is going to calculate kinetic energy based on user input. it will ask the user to enter mass and velocity
* and then pass those variables to a method and return the result using winforms.
*/
namespace WinUI
{
    public partial class KineticEnergyForm : Form
    {
        public KineticEnergyForm()
        {
            InitializeComponent();
        }

        //create the method to create the kinetic energy total
        private double Total(double weight, double speed) {
            
            return (.5) * weight * (speed * speed);

        }
        private void ButtonToCalculateKineticEnergyTotal_Click(object sender, EventArgs e)
        {
            //declare variables
            double mass, velocity, total;

            //get the mass from user
            if (double.TryParse(MassTextBox.Text, out mass))
            {
                //get the velocity from the user
                if (double.TryParse(VelocityTextBox.Text, out velocity))
                {

                    //call the method to do the calculations
                    total = Total(mass, velocity);

                    //display the total in the label
                    KineticEnergyTotalLabel.Text = total.ToString() + " Joules";
                }

                else
                {
                    //error message
                    MessageBox.Show("Please enter integers!");

                }
            }
            else {
                //error message
                MessageBox.Show("Please enter integers!");
            
            }


        }
    }
}
