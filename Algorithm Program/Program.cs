using System.Threading.Tasks;
using static Algorithm_Program.BinarySearch<string>;

namespace Algorithm_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageDemonstration messageDemonstration = new MessageDemonstration();
            Console.WriteLine("Please Enter First Name : ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Please Enter Last Name : ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Please Enter Mobile Number with Country Code  : ");
            string mobilenumber = Console.ReadLine();
            Console.WriteLine("Please Enter Date : ");
            string date = Console.ReadLine();
            messageDemonstration.FirstAndLast(firstname);
            messageDemonstration.FirstAndLast(lastname);
            messageDemonstration.Mobile(mobilenumber);
            messageDemonstration.Date(date);
            Console.WriteLine(firstname);
            Console.WriteLine(lastname);
            Console.WriteLine(mobilenumber);
            Console.WriteLine(date);
        }
    }
}
