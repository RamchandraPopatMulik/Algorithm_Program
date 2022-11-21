using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Program
{
    public class BinarySearch
    {
        public string filepath = @"E:\Basic Core Program\Algorithm Program\Algorithm_Program\Algorithm Program\BinarySearchData.json";

        public void BinarySearchWordCheck()
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
    }
}
