using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Program
{
    public class PrimeNumber
    {
        public void CheckPrimeNumber(int start, int end)
        {
            int count = 0;
            List<int> numbers = new List<int>();
            for (int i = start; i <= end; i++)
            {
                bool flag = false;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag && i != 1)
                {
                    Console.WriteLine("{0}", i);
                    count++;
                }
            }
            Console.WriteLine($"Total Prime Numbers from {start} to {end} are {count}");

            bool[] visited = new bool[numbers.Count];
            for (int j = 0; j < numbers.Count; j++)
            {
                if (visited[j] == true)
                {
                    continue;
                }
                for (int k = 1; k < numbers.Count; k++)
                {
                    CheckAnagram(numbers[j], numbers[k], visited, k);
                }
            }
        }
        public void CheckAnagram(int num1, int num2, bool[] visited, int j)
        {

            char[] ch1 = Convert.ToString(num1).ToCharArray();
            char[] ch2 = Convert.ToString(num2).ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2 && num1 != num2)
            {
                visited[j] = true;
                Console.WriteLine($"{num1} and {num2} are Anagrams");
            }
        }
        public void CheckPalindrome(int num1)
        {
            int reverse = 0;
            int num2 = num1;
            while (num1 != 0)
            {
                int reminder = num1 % 10;
                reverse = reverse * 10;
                reverse = reminder + reverse;
                num1 = num1 / 10;
            }
            if (num2 == reverse)
            {
                Console.Write($"********** {num2} is Palindrome Number **********");
            }
        }
    }
}

