using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EmployeeClass;

/**
* 11/28/21
* CSC 253
* Brandon Edison
* This program is going to use WPF UI and create employees using the employee class. They will then be stored in the listbox on the app
*/

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //close this form one the user is done
            this.Close();
        }

        //create list for the employees
        List<Employee> employeeList = new List<Employee>();

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //create the employee as an object
            Employee newEmployee = new Employee(EmployeeNameTextBox.Text, EmployeeID.Text, EmployeeDept.Text, EmployeePosition.Text);

            //add to the list box control
            ListBoxForEmployee.Items.Add(newEmployee.Name);
            ListBoxForEmployee.Items.Add(newEmployee.ID);
            ListBoxForEmployee.Items.Add(newEmployee.Dept);
            ListBoxForEmployee.Items.Add(newEmployee.Position);

            //give a message box to show that they created the employee
            MessageBox.Show("Employee has been created!");
        }

 
    }
}
