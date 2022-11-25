using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algorithm_Program
{
    public class MessageDemonstration
    {
        public string FirstAndLast(string Name)
        {
            Regex name = new Regex(@"^([A-Z]{1}[a-z]{2,})$");
            bool matches = name.IsMatch(Name);
            if(matches == true)
            {
                return Name;
            }
            else
            {
                Console.WriteLine($"Please Enter Name{Name}");
                return "";
            }
        }
        public string Mobile(string mobilenumber)
        {
            Regex Number = new Regex(@"^*[1-9]{1,3}[-][1-9]{1}[0-9]{9}$");
            bool matches = Number.IsMatch(mobilenumber);
            if (matches == true)
            {
                return mobilenumber;
            }
            else
            {
                Console.WriteLine($"Please Enter Mobile{mobilenumber}");
                return "";
            }
        }
        public string Date(string date)
        {
            Regex Date1 = new Regex(@"^*[1-9]{1,3}[-][1-9]{1}[0-9]{9}$");
            bool matches = Date1.IsMatch(date);
            if (matches == true)
            {
                return date;
            }
            else
            {
                Console.WriteLine($"Please Enter Date{date}");
                return "";
            }
        }

    }
}
