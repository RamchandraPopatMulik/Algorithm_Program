using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Program
{
    public class Anagram
    {
        public void AnagramDetectionProgram()
        {
            Console.WriteLine("Please Enter Your 1st Value :");
            string firstname = Console.ReadLine();
            Console.WriteLine("Please Enter Your 2st Value :");
            string secondname = Console.ReadLine();
            char[] character1 = firstname.ToLower().ToCharArray();
            char[] character2 = secondname.ToLower().ToCharArray();
            Array.Sort(character1);
            Array.Sort(character2);
            string val1 = new string(character1);
            string val2 = new string(character2);
            if(val1==val2)
            {
                Console.WriteLine("Both Strings are Anagram");
            }
            else
            {
                Console.WriteLine("Both Strings are Not Anagram");
            }
        }
       
    }
}
