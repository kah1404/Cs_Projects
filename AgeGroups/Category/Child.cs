using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGroups.Category
{
   internal class Child : Human
    {
        public override string Show()
        {
            return $"Category: {Category}" +
                   $"\nSex: {Sex}" +
                   $"\nLowest possible age: {LowestPossibleAge}" +
                   $"\nHighest possible age: {HighestPossibleAge}";
        }
    }
}
