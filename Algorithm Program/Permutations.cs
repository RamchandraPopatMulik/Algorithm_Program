using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Program
{
    public class Permutations
    {
        public static void Recursion(string str,int initialPosition,int Lengthstr)
        {
            if(initialPosition==Lengthstr)
            {
                Console.WriteLine(str);
            }
            else
            {
                for(int i=initialPosition;i<=Lengthstr;i++)
                {
                    str = Swap(str,initialPosition,i);
                    Recursion(str, initialPosition + 1,Lengthstr);
                    str = Swap(str, initialPosition, i);
                }
            }
        }
        public static string Swap(string str,int position1,int position2)
        {
            char temp;
            char[]charArray= str.ToCharArray();
            temp=charArray[position1];
            charArray[position1]=charArray[position2];
            charArray[position2]=temp;
            string s = new string(charArray);
            return s;
        }
        public static void iteration(string str)
        {
            int number = str.Length;
            int fact = Factorial(number);
            for(int i=0;i<fact;i++)
            {
                StringBuilder stringBuilder = new StringBuilder(str);
                int temp = i;
                for(int div=number;div>=1;div--)
                {
                    int quotient = temp / div;
                    int reminder = temp % div;
                    Console.Write(stringBuilder[reminder]);
                    stringBuilder.Remove(reminder,1);
                    temp = quotient;
                }
                Console.WriteLine();
            }
        }
        public static int Factorial(int number)
        {
            int val = 1;
            for(int i=2;i<=number;i++)
            {
                val *= i;
            }
            return val;
        }
    }
}
