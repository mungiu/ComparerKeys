using System;
using System.Collections.Generic;
using System.Text;

namespace ComparerKeys
{
    class PrimeMinister
    {
        public string Name { get; private set; }
        public int YearElected { get; private set; }

        public PrimeMinister(string name, int yearElected)
        {
            this.Name = name;
            this.YearElected = yearElected;
        }

        //overriding ToString() affects Console.WriteLine();
        //because "cw" inplements ToString() to display the elements
        public override string ToString()
        {
            return string.Format($"{Name}, elected: {YearElected}");
        }
    }
}
