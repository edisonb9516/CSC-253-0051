using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinUI
{
    class ReadFileClass
    {
        public static int GetTotal() 
        {
            //create the reader
            StreamReader inputFile;
            inputFile = File.OpenText("RandomNumbers.txt");

            //create var to hold the total
            int total = 0;
            //create the loop to get every line of the text
            while (inputFile.EndOfStream == false)
            {
                //read the line into the variable
                int number = int.Parse(inputFile.ReadLine());

                //add to the running total
                total += number;
            
            }           
            //close the file
            inputFile.Close();


            return total;
        
        }
        public static int GetItemCount()
        {
            //create the reader
            StreamReader inputFile;
            inputFile = File.OpenText("RandomNumbers.txt");

            //create the counter to hold the number of items in the file
            int counter = 0;

            //create the loop to get every line of the text
            while (inputFile.EndOfStream == false)
            {

                //add to the running total for each item in the file
                counter += 1;

            }
            //close the file
            inputFile.Close();


            return counter;

        }

    }
}
