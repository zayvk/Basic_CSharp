using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day4.Collections
{
    class HashTables
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("#1", "BalBasaur");
            ht.Add("#2", "Pikachu");
            ht.Add("#3", "Squirtle");
            ht.Add("#4", "Charmander");

            foreach (DictionaryEntry dictionaryEntry in ht)
            {
                Console.WriteLine(dictionaryEntry.Key + " " + dictionaryEntry.Value);
            }

            Console.WriteLine("\nEnter key to search");
            string key = Console.ReadLine();
            string value = ht[key].ToString();
            Console.WriteLine("Value is " + value);

            IDictionaryEnumerator enumerator = ht.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Key + " " + enumerator.Value);
            }

            Console.ReadLine();
        }
    }
}
