using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGroups
{
    internal abstract class Human
    {
        public int LowestPossibleAge { get; set; }
        public int HighestPossibleAge { get; set; }
        public string Category { get; set; }
        public string Sex { get; set; }

        public abstract string Show();

    }
}