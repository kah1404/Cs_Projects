using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGroups
{
   public class Teenager : Child
    {
        public Teenager()
        {
            LowestPossibleAge = 13;
            HighestPossibleAge = 19;
            Name = "Teenager";
        }
    }
}
