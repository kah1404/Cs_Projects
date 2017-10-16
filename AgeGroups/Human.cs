using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGroups
{
    public class Human
    {
        public int LowestPossibleAge { get; set; }
        public int HighestPossibleAge { get; set; }
        public string Category { get; set; }
        public string Sex { get; set; }

        public virtual void Show()
        {
            Console.WriteLine("Category: " + Category);
            Console.WriteLine("Sex: " + Sex);
            Console.WriteLine("Lowest possible age: " + LowestPossibleAge);
            Console.WriteLine("Hihest possible age: " + HighestPossibleAge);
        }


    }
}