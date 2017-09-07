using System;
using System.Collections.Generic;

namespace ComparerKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            //supplying a parameter to the dictionary contructor
            //and giving it an initialization list to set elements
            var primeMinisters = new Dictionary<string, PrimeMinister>
                (StringComparer.OrdinalIgnoreCase)
            {
                {"JC", new PrimeMinister("James Callaghan", 1974) },
                {"MT", new PrimeMinister("Margaret Thatcher", 1979) },
                {"TB", new PrimeMinister("Tony Blair", 1997) }
            };

            Console.WriteLine(primeMinisters["tb"]);
        }
    }
}
