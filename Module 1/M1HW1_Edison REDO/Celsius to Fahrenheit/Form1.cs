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
* 8/24/21
* CSC 253
* Brandon Edison
* This program is going to take the celsius temperature 0-20 and convert it into fahrenheit in a list box format using windows form
*/
namespace Celsius_to_Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Welcome to Celsius to Fahrenheit Converter!\n" +
                "This program is going to convert 0-20 degrees \ncelsius into fahrenheit. With just the click of a button!";


            lbConversionTable.MultiColumn = true;
            lbConversionTable.SelectionMode = SelectionMode.MultiExtended;

            lbConversionTable.BeginUpdate();

            for (int counter = 0; counter <= 20; counter++)
            {

                //display the celsius first
                lbConversionTable.Items.Add(counter.ToString("0° C"));

                //convert the counter degree to fahrenheit
                double fahrenheit = ((1.8) * counter) + 32;
                lbConversionTable.Items.Add(fahrenheit.ToString(".0° F"));

            }

            lbConversionTable.EndUpdate();

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConversionTable_SelectedIndexChanged(object sender, EventArgs e)
        {

 
        }
    }
}
