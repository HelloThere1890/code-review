//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text

            List<int> parameters = new List<int>();

            //Create 'Input' object
            var input = new Input();

            //Create an 'Analyse' object
            var analyse = new Analyse();

            //create 'Report' object
            var report = new Report();

            //Get either manually entered text, or text from a file  
            Console.WriteLine("Input '1' to enter text manually.");
            Console.WriteLine("Input '2' to use text through another file.");

            string userInput = "";
            //string textchoice = Console.ReadLine();
            bool wrongInput = true;


            //loop while input does not equal 1 or 2

            do
            {
                try
                {
                    string textchoice = (Console.ReadLine());

                    if (textchoice == "1")
                    {
                        //pass to input method
                        wrongInput = false;
                        userInput = input.manualTextInput();
                        break;

                        //pass values back to 'analyseText' method
                        //analyse.analyseText(userInput);
                    }
                    else if (textchoice == "2")
                    {
                        //wrongInput = false;
                        //@"C:\Users\Molli\Desktop\code pls work\CMP1903M Assessment 1 Base Code\CMP1903M Assessment 1 Base Code\testfile.txt"
                        userInput = input.fileTextInput();
                        analyse.analyseText(userInput);
                        wrongInput = false;
                        break;
                    }
                    else
                    {
                        //wrongInput = true;
                        Console.WriteLine("Please insert either 1 or 2");
                    }

                }
                catch
                {
                    //Console.WriteLine("Please enter a valid input.");
                }
            } while (wrongInput == true);


            //Receive a list of integers back
            parameters = analyse.analyseText(userInput);

            //Report the results of the analysis
            report.outputResults(parameters);

            //TO ADD: Get the frequency of individual letters?


        }



    }
}