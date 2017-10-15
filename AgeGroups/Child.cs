using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGroups
{
   public class Child : Human
    {
        public Child()
        {
            LowestPossibleAge = 0;
            HighestPossibleAge = 12;
            Name = "Child";
        }
    }
}
