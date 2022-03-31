using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        //string text = "nothing";

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            bool userHasFinished = false;

            //create list to hold user input
            List<string> userInputList = new List<string>();

            Console.WriteLine("Please type your line(s) of text here. Insert '*' on new line when finished: ");

            //check for * to see if user has finished typing, else continues letting user type
            do
            {
                string usertext = Console.ReadLine();
                if (usertext == "*")
                {
                    //userHasFinished = true;
                    break;
                }
                else
                {
                    //add user input to list of strings
                    userInputList.Add(usertext);
                }
            } while (userHasFinished == false);

            //create text string to return list to analyse
            string text = string.Join(" ", userInputList);
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput()
        {
            try
            {
                //attemt to add user input to choose file
                //Console.WriteLine("Enter file path location: ");
                //string fileName = (Console.ReadLine());
                string text = File.ReadAllText(@"C:\Users\Molli\Desktop\code pls work\CMP1903M Assessment 1 Base Code\CMP1903M Assessment 1 Base Code\testfile.txt");
                return text;
            }
            catch
            {
                Console.WriteLine("Cannot Find file.");
                Environment.Exit(0);
                return null;
            }
        }

    }
}