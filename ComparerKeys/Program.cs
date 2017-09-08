using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ComparerKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            //previously this was a "Dictionary<string, PrimeMinister>"
            //SortedList stores the list sorted by the key
            //SortedDictionary stores the list sorted by "balancedtree" hierarchy
            var primeMinisters = new SortedDictionary<string, PrimeMinister>
                //supplying parameter to dictionary contructor
                (new UncasedStringComparer())
                //initialization list to set elements
            {
                {"JC", new PrimeMinister("James Callaghan", 1974) },
                {"MT", new PrimeMinister("Margaret Thatcher", 1979) },
                {"TB", new PrimeMinister("Tony Blair", 1997) }
            };
            primeMinisters.Add("AM", new PrimeMinister("Andrei Mungiu", 2017));
            //due to additional parameter from above, case sensitivity is ignored
            Console.WriteLine(primeMinisters["tb"]);


            ///creating read only Dictionary from the above Dictionary
            var pmsReadOnly = new ReadOnlyDictionary
                <string, PrimeMinister>(primeMinisters);
            foreach (var pm in pmsReadOnly)
            {
                Console.WriteLine(pm);
            }
        }

        //hash code is irrelevant -> sorted list doesn't have hash table
        class UncasedStringComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                //Microsoft default string comparer with ignore case overload
                return string.Compare
                    (x, y, StringComparison.CurrentCultureIgnoreCase);
            }
        }
    }
}
