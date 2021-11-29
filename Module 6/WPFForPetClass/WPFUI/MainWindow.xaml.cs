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
using PetClassLib;
/**
* 11/28/21
* CSC 253
* Brandon Edison
* This program is going to take user input about a pet in WPF and display the information in list box. 
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

        //create a list for the pets
        List<Pet> petList = new List<Pet>();

        private void EnterPetButton_Click(object sender, RoutedEventArgs e)
        {
            //create the employee as an object
            Pet newPet = new Pet(PetNameTextBox.Text, PetTypeTextBox.Text, int.Parse(PetAgeTextBox.Text));

            //add to the list box control
            PetListBox.Items.Add(newPet.Name);
            PetListBox.Items.Add(newPet.Type);
            PetListBox.Items.Add(newPet.Age);

            //give a message box to show that they created the pet
            MessageBox.Show("Pet has been created!");
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            //close the form
            this.Close();

        }
    }
}
