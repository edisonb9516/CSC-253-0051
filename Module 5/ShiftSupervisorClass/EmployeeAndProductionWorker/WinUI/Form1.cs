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
    public partial class EmployeeAndProductionWorkerForm : Form
    {
        public EmployeeAndProductionWorkerForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //close the program when this button is clicked
            this.Close();
        }

        //create a list to hold the employee object
        List<WorkerClassLib.ProductionWorker> employees = new List<WorkerClassLib.ProductionWorker>();

        private void CreateEmployeeButton_Click(object sender, EventArgs e)
        {
            //This button will retrieve the user input and create the object. 

            //create a new employee when this button is clicked and accept the user info
            WorkerClassLib.ProductionWorker newEmployee = new WorkerClassLib.ProductionWorker(nameTextBox.Text, employeeIDTextBox.Text, int.Parse(shiftNumTextBox.Text), double.Parse(payRateTextBox.Text));

            ////add to the list           
            listBox1.Items.Add(newEmployee.Name);
            listBox1.Items.Add(newEmployee.ID);
            listBox1.Items.Add(newEmployee.ShiftNumber);
            listBox1.Items.Add(newEmployee.PayRate);
            listBox1.Items.Add("__________________________");
        }



        //create a list to hold the supervisors object
        List<WorkerClassLib.Supervisor> supervisors = new List<WorkerClassLib.Supervisor>();
        private void createSupervisorButton_Click(object sender, EventArgs e)
        {   
            //This button will retrieve the user input and create the object. 

            //create a new supervisor when this button is clicked and accept the user info
            WorkerClassLib.Supervisor newSupervisor = new WorkerClassLib.Supervisor(supervisorNameTextbox.Text, supervisorIDNumTextBox.Text, int.Parse(salaryTextBox.Text), int.Parse(bonusesTextBox.Text));

            ////add to the list
            

            listBox2.Items.Add(newSupervisor.Name);
            listBox2.Items.Add(newSupervisor.ID);
            listBox2.Items.Add(newSupervisor.Salary);
            listBox2.Items.Add(newSupervisor.Bonuses);
            listBox2.Items.Add("__________________________");

        }
    }
}
