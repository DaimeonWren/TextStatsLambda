using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda
{
    class Program
    {
        static void Main(string[] args)
        {
       /// TextStats Lambda
            TextStats("Code is getting so damn hard on this thrid week, then a full time job after class is breaking me. Second thoughs consume my mind.\n\n");
            
            
            
            //declare a list of test strings
            List<string> myList = new List<string>() { "tyler", "kiwi", "strawberry", "boisionberry", "blueberry","dragonfruit","bananas","mangos" };
            OrderByEx(myList);
            // call the where
            WhereEx(myList);
            // call the Distinct
            DistinctEx();
            // 1st and last ex
            FirstandLastEx(myList);
            // call the Skip and Tizake
            SkipandTakeEx(myList);


            Console.ReadKey();
        }
        static void OrderByEx(IEnumerable<string> list) 
        { 
        //Order the list by length, and print them out to the console.
            //Order by sorts by length of word, then by sort alphabetically
            List<string> orderedList = list.OrderBy(x => x.Length).ThenBy(x=>x.Length).ToList();
            Console.WriteLine(string.Join(", ", orderedList));

        }
        static void WhereEx(IEnumerable<string> list) 
        {
        // print to the console all items in the list that contain the text "berrty"
            List<string>berryList = list.Where(x => x.Contains("berry")).ToList();
            Console.WriteLine(string.Join(", ", berryList));
           //print to the console all items in the list that DO NOT contain the text "berry"
            List<string> notberrylist = list.Where(x => !x.Contains("berry")).ToList();
            //one line ex
            //Console.WriteLine(string.Join(", ",list.Where(x=>x.Contains("berry")))
        }
        static void DistinctEx()
        { 
        //declare a new list of integers with a bunch of duplicate values
            List<int> intList = new List<int>() { 1, 1, 2, 2, 3, 4, 4, 4, 5, 7, 7, 8 };
            Console.Write(string.Join(", ", intList.Distinct()));
            
        }
        static void FirstandLastEx(IEnumerable<string>list)
        {
        // we are going to sort the list alphabetically and print the first and last items to the console
            List<string>sorted = list.OrderBy(x =>x).ToList();
            Console.WriteLine(sorted.First());
            Console.WriteLine(sorted.Last());
           
        }
        static void SkipandTakeEx(IEnumerable<string> list) 
        {
        //we want to print out the thrid item from our list ordeed by length
            List<string>sorted = list.OrderBy(x => x.Length).ToList();
            // skip 2 items, print the 3rd.
            Console.WriteLine(sorted.Skip(2).Take(1).First());
            //skip two and then take two
            Console.WriteLine(string.Join(", ", sorted.Skip(2).Take(2)));
            

        }
        static void TextStats(string input) 
        {
            input = input.ToLower();
            Console.WriteLine("# of letters: {0}", input.Length);
            //print out the number of letters
            Console.WriteLine("# of words: {0}", input.Split(' ').Count());
            // vowels
            Console.WriteLine("# of vowels: {0}", input.Where(x => "aeiou".Contains(x.ToString())).Count());

            Console.WriteLine("# of consonants {0}", input.Count(x != "aeiou".Contains(x.ToString())).Count());

                Console.WriteLine(" # of Special Characaters: {0}" , input.Count(x => )

                    Console.WriteLine("Shortest Word: {0}" , input.Split(
        
        
        }
    }
}
