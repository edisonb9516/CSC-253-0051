using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class CarClassSim : Form
    {
        public CarClassSim()
        {
            InitializeComponent();
        }

        private void CarClassSim_Load(object sender, EventArgs e)
        {

        }
        
        //create the object
        CarCreationClass userCar = new CarCreationClass();

        //create a method to accept the users information on the car 
        private void GetCarSpecs(CarCreationClass car) {

            //get the user car specifications from the boxes
            car.Make = CarMakeTextBox.Text;
            car.Model = CarModelTextBox.Text;
            car.Year = CarYearTextBox.Text;
            

        
        }

        private void AcceptCarSpecsButton_Click(object sender, EventArgs e)
        {


            //call the method
            GetCarSpecs(userCar);

            //Display in the label boxes 
            DisplayCarMakeLabel.Text = userCar.Make;
            DisplayCarModelLabel.Text = userCar.Model;
            DisplayCarYearLabel.Text = userCar.Year;
            CarSpeedLabel.Text = userCar.Speed.ToString("");



        }

        
        private void AccelerationButton_Click(object sender, EventArgs e)
        {
            //call the increase method so the speed increases when the button is clicked
            userCar.Increase();
            //display the speed
            CarSpeedLabel.Text = userCar.Speed.ToString("");

        }


        private void BrakeButton_Click(object sender, EventArgs e)
        {
            //call the decrease method to decrease speed when the button is clicked
            userCar.Decrease();
            //display the speed
            CarSpeedLabel.Text = userCar.Speed.ToString("");
        }

        private void CarMakeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarModelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarYearTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();

        }
    }
}
