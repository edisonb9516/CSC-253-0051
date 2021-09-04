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
* 9/3/21
* CSC 253
* Brandon Edison
* This program is going to use win forms to creat a list box that will display temperature conversions from 0-20 degree celsius to fahrenheit.
*/

namespace WinUI
{
    public partial class formForCtoF : Form
    {

        public formForCtoF()
        {
            InitializeComponent();
        }

        private void buttonToDisplayMessage_Click(object sender, EventArgs e)
        {
            //creating listbox
            ListBox listBoxTemp = new ListBox();
            this.Controls.Add(listBoxTemp);
            listBoxTemp.MultiColumn = true;
            listBoxTemp.SelectionMode = SelectionMode.MultiExtended;
            listBoxTemp.Location = new System.Drawing.Point(100, 50);
            listBoxTemp.Size = new System.Drawing.Size(100, 200);

            //start updating and looping through the temps and apply to listbox
            listBoxTemp.BeginUpdate();

            for (int count = 0; count <= 20; count++) {
                double Fahrenheit = ((1.8) * count + 32);
                listBoxTemp.Items.Add(count.ToString() + "°C = " + Fahrenheit.ToString() + "°F \n");

                


            
            }

            //end the updating of the list box
            listBoxTemp.EndUpdate();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }



    }
}
