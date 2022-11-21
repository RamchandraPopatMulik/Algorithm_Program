using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Program
{
    public class MergeSortMethod
    {
        public void merge(int[]array,int left,int mid,int right)
        {
            int sizeOfArray1=mid-left+1;
            int sizeOfArray2=right-mid;
            int[]tempLeft=new int[sizeOfArray1];
            int[]tempRight=new int[sizeOfArray2];
            int i, j;

            for(i=0;i<sizeOfArray1;++i)
               tempLeft[i]= array[left + i];
            for (j = 0; j < sizeOfArray2; ++j)
                tempRight[j] = array[mid + 1+j];
            i = 0;
            j= 0;
            int k=left;
            while(i<sizeOfArray1 && j<sizeOfArray2)
            {
                if (tempLeft[i] <= tempRight[j])
                {
                    array[k]= array[i];
                    i++;
                }
                else
                {
                    array[k]= array[j];
                    j++;
                }
                k++;
            }
            while(i< sizeOfArray1)
            {
                array[k]=tempLeft[i];
                i++;
                k++;
            }
            while (j < sizeOfArray2)
            {
                array[k] = tempLeft[j];
                j++;
                k++;
            }
        }
        public void Sort(int[]array,int left,int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                Sort(array, left, mid);
                Sort(array, mid + 1, right);
                merge(array, left, mid, right);
            }
        }
        public void Display(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            Console.Write(array[i] + "  ");
        }
    }
}
