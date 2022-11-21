using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Program
{
    public class Input
    {
        public void UserInput()
        {
            Console.WriteLine("Please Enetr Your -1 Permutation");
            Console.WriteLine("Enter Selected Number");
            int userInput=int.Parse(Console.ReadLine());

            switch(userInput)
            {
                case 1:
                    Console.Write("\nEnter String for Permutation : ");
                    string str = Console.ReadLine();
                    int Length = str.Length;
                    Console.WriteLine("Using Recursion Method Permutations are :: ");
                    Permutations.Recursion(str, 0, Length - 1); 
                    Console.WriteLine("Using Iterative Method Permutations are :: ");
                    Permutations.iteration(str); 
                    break;
            }
        }

    }
}
