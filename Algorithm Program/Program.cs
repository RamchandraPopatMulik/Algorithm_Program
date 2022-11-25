using static Algorithm_Program.BinarySearch<string>;

namespace Algorithm_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Search Which You Want to Do");
            int value = Convert.ToInt32(Console.ReadLine());

            switch(value)
            {
                case 1:
                    BinarySearch<string>obj = new BinarySearch<string>();
                    obj.BinarySearchWordCheck<string>();
                    Console.ReadLine();
                    break;
                case 2:
                    string[] names = {"BMW","TataSafari","TataNano","Jaguar","Swift","Suzuki","Nexon","Honda","Mahindra","RangeRover"};
                    InsertionSort<string> objInsertion = new InsertionSort<string>();
                    Console.WriteLine("Before Sorting :");
                    objInsertion.Display<string>(names);
                    objInsertion.Sort<string>(names);
                    Console.WriteLine("After Sorting :");
                    objInsertion.Display<string>(names);
                    break;

                case 3:
                    int[] array = { 51, 12, 49, 26, 85, 153, 4 };
                    Bubble<int> bubble = new Bubble<int>();
                    Console.WriteLine("Before Sorting :");
                    bubble.Display<int>(array);
                    bubble.Sort<int>(array);
                    Console.WriteLine("After Sorting :");
                    bubble.Display<int>(array);
                    break;

                case 4:
                    int[] array1 = { 51, 12, 49, 26, 85, 153, 4 };
                    MergeSort<int> merge = new MergeSort<int>();
                    Console.WriteLine("Before Sorting :");
                    merge.Display<int>(array1);
                    merge.Sort<int>(array1,0,array1.Length-1);
                    Console.WriteLine("After Sorting :");
                    merge.Display<int>(array1);
                    Console.ReadLine();
                    break;
            }
        }
    }
}