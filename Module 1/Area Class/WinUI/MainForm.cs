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
* 9/9/21
* CSC 253
* Brandon Edison
* This program is going to use winforms and classes to calculate the area of certain shapes
*/
namespace WinUI
{
    public partial class AreaForm : Form
    {
        public AreaForm()
        {
            InitializeComponent();
        }

        private void CalculateCircleButton_Click(object sender, EventArgs e)
        {

            double radius; //hold the radius amount
            double total; //hold the total amount to display 

            //convert the radius to a double
            if (double.TryParse(CircleRadiusTextBox.Text, out radius))
            {
                //use the method in the class
                total = AreaClass.circleArea(radius);
                //display in the label
                CircleAreaTotalLabel.Text = total.ToString("");
            }
            
            else {

                MessageBox.Show("Enter a valid Number");
            }

        }

        private void CalculateRectangleButton_Click(object sender, EventArgs e)
        {
            double length; //hold the length 
            double width;
            double total; //hold the total to display 

            //convert the radius to a double
            if (double.TryParse(EnterLengthTextBox.Text, out length))
            {
                if (double.TryParse(EnterWidthTextBox.Text, out width))
                {
                    //use the method in the class
                    total = AreaClass.rectangleArea(length, width);
                    //display in the label
                    RectangleAreaTotalLabel.Text = total.ToString("");
                }
                else
                {

                    MessageBox.Show("Enter a valid Number");
                }
            }

            else
            {

                MessageBox.Show("Enter a valid Number");
            }


        }

        private void CalculateCylinderButton_Click(object sender, EventArgs e)
        {
            double radius; //hold the radius 
            double height; //hold the height 
            double total; //hold the total to display 

            //convert the radius to a double
            if (double.TryParse(EnterCylinderRadiusTextBox.Text, out radius))
            {
                if (double.TryParse(EnterCylinderHeightTextBox.Text, out height))
                {
                    //use the method in the class
                    total = AreaClass.cylinderArea(radius, height);
                    //display in the label
                    CylinderAreaTotalLabel.Text = total.ToString("");
                }
                else
                {

                    MessageBox.Show("Enter a valid Number");
                }

            }

            else
            {

                MessageBox.Show("Enter a valid Number");
            }


        }
    }
}
