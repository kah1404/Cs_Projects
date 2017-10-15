using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGroups
{
   public class Adult : Teenager
    {
        public Adult()
        {
            LowestPossibleAge = 20;
            HighestPossibleAge = 64;
            Name = "Adult";
        }

    }
}
