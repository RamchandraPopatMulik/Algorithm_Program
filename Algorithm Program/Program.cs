namespace Algorithm_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] names = {"Ram", "Sachin","Rahul","Mahesh","Shrikant","Sanjiv","Sourabh","Mohan","Sandip"};
            InsertionSortMethod insertionSortMethod = new InsertionSortMethod();
            Console.WriteLine("Before Sorting Element are :");
            insertionSortMethod.Display(names);

            insertionSortMethod.sort(names);
            Console.WriteLine("After Sorting Elements are :");
            insertionSortMethod.Display(names);
            Console.ReadLine();
        }
    }
}