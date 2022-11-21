namespace Algorithm_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] array = {51,56,9,565,6,32,57,36,78,35,26,65};
            InsertionSortMethod insertionSortMethod = new InsertionSortMethod();
            Console.WriteLine("Before Sorting Element are :");
            insertionSortMethod.Display(array);

            insertionSortMethod.sort(array);
            Console.WriteLine("After Sorting Elements are :");
            insertionSortMethod.Display(array);
            Console.ReadLine();
        }
    }
}