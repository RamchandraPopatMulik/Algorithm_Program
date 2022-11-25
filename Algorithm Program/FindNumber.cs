using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Program
{
    public class FindNumber
    {
        public void findnumber(int high)
        {
              int low = 0,value = 0;
            int[]array=new int[high+1];
            for(int i=0;i<=high;i++)
            {
                array[i]=value;
                value++;
            }
            while(low !=high)
            {
                int mid = (low + high) / 2;
                Console.WriteLine("Please Enter 1 for Number between"+low+"and"+mid+"Please Enter 2 for Number between"+(mid+1)+"and"+high);
                int c=Convert.ToInt32(Console.ReadLine());
                mid = Array.BinarySearch(array,mid);
                if(c==1)
                {
                    high=array[mid];
                }
                else if(c==2)
                {
                    low = array[mid]+1;
                }
            }
            Console.WriteLine("Number is : "+low);
        }
    }
}
