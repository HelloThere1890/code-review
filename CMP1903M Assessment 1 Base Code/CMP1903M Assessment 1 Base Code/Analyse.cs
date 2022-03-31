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
            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }

            //delete words after * - for file analysis
            if (input.Contains('*'))
            {
                input = input.Substring(0, input.IndexOf("*"));
            }

            //calculate number of sentences
            //split text into list based on sentences
            string[] textBreak = input.Split(".");
            int sentenceCount = 0;


            for (int i = 0; i < textBreak.Length; i++)
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

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]))
                {
                    lowerCaseChars++;
                }
                else if (char.IsUpper(input[i]))
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

            //create long words file
            string longWords = ("longWordsFile.txt");
            //empties file every time program is run
            File.Delete(longWords);

            //list to add words greather than 7 to
            List<string> finalWords = new List<string>();

            //split input into list of words
            string[] listOfWords = input.Split(" ");
            //checks for words greater than 7
            for (int i = 0; i < listOfWords.Length; i++)
            {
                if (listOfWords[i].Length > 7)
                {
                    //add words to list
                    finalWords.Add(listOfWords[i]);
                    //add to longWordsFile
                    File.WriteAllLines(longWords, finalWords);
                }
            }

            //returns value back to 'Program'
            return values;
        }
    }
}
