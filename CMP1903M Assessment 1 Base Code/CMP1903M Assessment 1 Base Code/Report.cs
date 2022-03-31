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
            Console.WriteLine("Number of sentences: {0}", parameters[0]);
            Console.WriteLine("Number of vowels: {0}", parameters[1]);
            Console.WriteLine("Number of consonants: {0}", parameters[2]);
            Console.WriteLine("Number of lower case characters: {0}", parameters[3]);
            Console.WriteLine("Number of upper case characters: {0}", parameters[4]);
        }
    }
}
