using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinUI
{
    public partial class RandomNumFileWriterForm : Form
    {
        public RandomNumFileWriterForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateFileButton_Click(object sender, EventArgs e)
        {
            int userInput; // hold the user input

            //create an if else to determine if the input was an integer or not
            if (int.TryParse(userInputTextBox.Text, out userInput))
            {
                //use the class to write the file
                WriteFileClass.WriteFile(userInput);


            }
            //catch anything that isnt an integer and display an error message
            else 
            {
                MessageBox.Show("Error, invalid number. Enter a whole integer.");
            
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //close the application
            this.Close();
        }
    }
}
