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
* 9/28/21
* CSC 253
* Brandon Edison
* This program is going to accept a users string and count the words in the string with a method that will be held in the class library AND it 
* is going to take the average number of letters in each word that the user enters. (this is the modified version for Homework 2)
*/

namespace WinUI
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //close the program with this button
            this.Close();

        }

        private void CountWordButton_Click(object sender, EventArgs e)
        {
            //when this button is clicked, it will accept the users string and pass it to the method in the class library
            
            string userInput = UserPhraseTextBox.Text; //takes the user input and puts it into the variable
            
            string NumOfWords; //this will hold the total number of words in the string once it returns from method
            string avgNumOfLetters; //this will hold the average number of letters in each word 

            //call the method in the library passing the user string and accepting the total words
            NumOfWords =  WordCountLib.WordCount.countWord(userInput);

            //call the method that will average the num of lettes in each word of the string
            avgNumOfLetters = WordCountLib.WordCount.averageWord(userInput);

            //display the total num of words and average num of letters in each word
            MessageBox.Show("Number of words is " + NumOfWords + ". The Average Number of letters of each word is " + avgNumOfLetters);

        }
    }
}
