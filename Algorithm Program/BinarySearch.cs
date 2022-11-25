using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Program
{
    public class BinarySearch<T>
    {
        public string filepath = @"E:\Basic Core Program\Algorithm Program\Algorithm_Program\Algorithm Program\BinarySearchData.json";

        public void BinarySearchWordCheck<T>()
        {
            string wordsdata = "BMW,TataSafari,TataNano,Jaguar,Swift,Suzuki,Nexon,Honda,Mahindra,RangeRover";
            File.WriteAllText(filepath, JsonConvert.SerializeObject(wordsdata));

            string wordData = File.ReadAllText(filepath);
            string word = JsonConvert.DeserializeObject<string>(wordData);
            List<string> wordList = word.Split(',').ToList<string>();
            wordList.Sort();

            Console.WriteLine("Enter a Word to Search: ");
            string wordToSearch = Console.ReadLine();

            int index = wordList.BinarySearch(wordToSearch);

            if (index < 0)
            {
                Console.WriteLine($"{wordToSearch} does not exist");
            }
            else
            {
                Console.WriteLine($"{wordToSearch} exists");
            }

        }
        public class InsertionSort<T>
        {
            public void Sort<T>(T[] array) where T : IComparable
            {
                int index;
                for (int i = 1; i < array.Length; i++)
                {
                    T word = array[i];
                    index = i - 1;
                    while ((index >= 0) && (array[index].CompareTo(word) > 0))
                    {
                        array[index + 1] = array[index];
                        index--;
                    }
                    array[index + 1] = word;
                }
            }
            public void Display<T>(T[] array) where T : IComparable
            {
                int n = array.Length;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(array[i] + " ");
                }
            }
        }
        public class Bubble<T>
        {
            public void Sort<T>(int[]array)
            {
                int n = array.Length;
                for (int i=0;i<=n;i++)
                {
                    for (int index = 0; index < n - i - 1; index++)
                    {
                        if (array[index] > array[index+1])
                        {
                            int temp=array[index];
                            array[index]=array[index+1];
                            array[index+1]=temp;
                        }
                    }
                }
            }
            public void Display<T>(T[] array) where T : IComparable
            {
                int n = array.Length;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(array[i] + " ");
                }
            }
        }
        public class MergeSort<T>
        {
            public void Merge<T>(int[]array,int left,int mid,int right)
            {
                int sizeOfArray1=mid-left+1;
                int sizeOfArray2=right-left;
                int[] templeft=new int[sizeOfArray1];   
                int[] tempright=new int[sizeOfArray2];
                int i, j;
                for (i = 0; i < sizeOfArray1; ++i)
                    templeft[i] = array[left + i];

                for (j = 0; j < sizeOfArray1; ++j)
                    tempright[j] = array[mid +1+ j];

                i = 0;
                j = 0;
                int k = left;
                while(i<sizeOfArray1 && j<sizeOfArray2)
                {
                    if (templeft[i] <= tempright[j])
                    {
                        array[k] = templeft[i];
                        i++;
                    }
                    else
                    {
                        array[k] = tempright[j];
                        j++;
                    }
                    k++;
                }
            }
            public void Sort<T>(int[]array,int left,int right)
            {
                if(left <right)
                {
                    int mid = left + (right - left) / 2;
                    Sort<int>(array, left, mid);
                    Sort<int>(array, mid+1, right);

                    Merge<int>(array,left,mid,right);
                }
            }
            public void Display<T>(T[] array) where T : IComparable
            {
                int n = array.Length;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(array[i] + " ");
                }
            }
        } 
    }
}
