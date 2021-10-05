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
    public partial class PersonnelDBForm : Form
    {
        public PersonnelDBForm()
        {
            InitializeComponent();

            //greet user when program is started
            MessageBox.Show(PersonnelDBClassLib.greetUser.helloThere());
        }

        private void PersonnelDBForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personnelDBDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.personnelDBDataSet.Employee);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
