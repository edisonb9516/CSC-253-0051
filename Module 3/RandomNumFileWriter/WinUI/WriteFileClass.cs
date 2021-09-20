using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinUI
{
    class WriteFileClass
    {
        public static int WriteFile(int userInput) 
        {


            
            //create the file writer and hardcode the file name
            StreamWriter outputfile;
            outputfile = File.CreateText("RandomNumbers.txt");
            //create the random number generator
            var randomNum = new Random();
            for (int counter = 0; counter <= userInput; counter++)
            {

                int randomInt = randomNum.Next(0, 100); //the random number between 0-100
                
                //write the number to the file
                outputfile.WriteLine(randomInt);

            }

            outputfile.Close();
           
 
            return 0;
        
        }
           

    }
}
