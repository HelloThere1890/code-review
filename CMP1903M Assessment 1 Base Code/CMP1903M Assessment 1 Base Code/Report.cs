using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>

        public void outputResults(List<int> parameters)
        {
            //output results to user
            Console.WriteLine("Number of sentences: {0}", parameters[0]);
            Console.WriteLine("Number of vowels: {0}", parameters[1]);
            Console.WriteLine("Number of consonants: {0}", parameters[2]);
            Console.WriteLine("Number of lower case characters: {0}", parameters[3]);
            Console.WriteLine("Number of upper case characters: {0}", parameters[4]);
        }


        //compares results from test file with ones output in code
        public void compareResults(List<int> parameters)
        {
            //establish variables from test file
            int sentenceExample = 6;
            int vowelExample = 189;
            int consonantExample = 317;
            int lowerExample = 497;
            int upperExample = 9;
            
            //compares sentence count in file with program output
            if (sentenceExample == parameters[0])
            {
                Console.WriteLine("Results match");
            }
            //compares vowel count in file with program output
            if (vowelExample == parameters[1])
            {
                Console.WriteLine("Results match");
            }
            //compares consonant count in file with program output
            if (consonantExample == parameters[2])
            {
                Console.WriteLine("Results match");
            }
            //compares lower case count in file with program output
            if (lowerExample == parameters[3])
            {
                Console.WriteLine("Results match");
            }
            //compares upper case count in file with program output
            if (upperExample == parameters[4])
            {
                Console.WriteLine("Results match");
            }
        }
    }
}
