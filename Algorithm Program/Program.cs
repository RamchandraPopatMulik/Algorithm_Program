using System.Threading.Tasks;
using static Algorithm_Program.BinarySearch<string>;

namespace Algorithm_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number of Tasks : ");
            int tasks = Convert.ToInt32(Console.ReadLine());
            Task task = new Task();
            task.TaskSceduleing(tasks);
        }
    }
}
