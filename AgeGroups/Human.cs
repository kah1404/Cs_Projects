using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGroups
{
    public abstract class Human
    {
        public int LowestPossibleAge { get; set; }
        public int HighestPossibleAge { get; set; }
        public string Category { get; set; }
        public string Sex { get; set; }

        public virtual string Show()
        {
            return $"Category: {Category}" +
                   $"Sex: {Sex}" +
                   $"Lowest possible age: {LowestPossibleAge}" +
                   $"Highest possible age: {HighestPossibleAge}";
        }


    }
}