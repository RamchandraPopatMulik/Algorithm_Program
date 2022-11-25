using static Algorithm_Program.BinarySearch<string>;

namespace Algorithm_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Highest value : ");
            int high = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Guess the Number between 0 and {high} : ");
            Console.ReadLine();
            FindNumber find = new FindNumber();
            find.findnumber(high);
        }
    }
}
