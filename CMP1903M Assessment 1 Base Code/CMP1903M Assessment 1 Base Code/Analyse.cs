using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters


            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }

            //calculate number of sentences
            //split text into array based on sentences
            string[] textBreak = input.Split(".");
            int sentences = textBreak.Length;
            int sentenceCount = 0;


            for (int i=0; i<sentenceCount; i++)
            {
                sentenceCount++;
            }


            //convert to lower case to analyse vowels and consonants
            string lowerCaseText = input.ToLower();

            //remove special characters - stop counters breaking when input by user
            var specialChars = new String[] { "!", "£", "$", "%", "&", "*", "(", ")", "?", "@", ",", ":", "'", "/", "#" };
            foreach (var i in specialChars)
            {
                lowerCaseText = lowerCaseText.Replace(i, "");
            }





            //check vowels and consonants
            int vowels = 0;
            int consonants = 0;
            for (int i = 0; i < lowerCaseText.Length; i++)
            {
                if (lowerCaseText[i] == 'a' || lowerCaseText[i] == 'e' || lowerCaseText[i] == 'i' || lowerCaseText[i] == 'o' || lowerCaseText[i] == 'u')
                {
                    vowels++;
                }
                else if ((lowerCaseText[i] >= 'a' && lowerCaseText[i] <= 'z') ||
                 (lowerCaseText[i] >= 'A' && lowerCaseText[i] <= 'Z'))
                {
                    consonants++;
                }
            }

            //upper case letters
            int lowerCaseChars = 0;
            int upperCaseChars = 0;

            for (int i=0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]))
                {
                    lowerCaseChars++;
                }
                else if (char.IsLower(input[i]))
                {
                    upperCaseChars++;
                }
            }

            //make class inserting all variables into values
            values.Insert(0, sentenceCount);
            values.Insert(1, vowels);
            values.Insert(2, consonants);
            values.Insert(3, lowerCaseChars);
            values.Insert(4, upperCaseChars);






            //returns value back to 'Program'
            return values;
        }
    }
}
