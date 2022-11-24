using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Program
{
    public class PrimeNumber
    {
        public void CheckPrimeNumber(int start,int end)
        {
            int count = 0;
            for(int i=start;i<=end;i++)
            {
                bool flag=false;
                for(int j=2;j<=i/2;j++)
                {
                    if(i%j==0)
                    {
                        flag=true;
                        break;
                    }
                }
                if(!flag && i!=1)
                {
                    Console.WriteLine("{0}",i);
                    count++;
                }
            }
            Console.WriteLine($"Total Prime Numbers from {start} to {end } are {count}");
        }
    }
}
