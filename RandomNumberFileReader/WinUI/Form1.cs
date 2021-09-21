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
    public partial class RandomFileReaderForm : Form
    {
        public RandomFileReaderForm()
        {
            InitializeComponent();
        }

        private void DisplayFileTotalButton_Click(object sender, EventArgs e)
        {
            //have vars to hold total and counter
            int total = 0;
            int counter = 0;

            //call the methods in the class
            total = ReadFileClass.GetTotal();
            counter = ReadFileClass.GetItemCount();


            //display the totals to the labels on the form
            RunningTotalLabel.Text = total.ToString("");

            TotalItemsLabel.Text = total.ToString("");


        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();

        }
    }
}
