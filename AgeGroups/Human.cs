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
        public string Name { get; set; }
        public string IsFemale = "Female";
        public string IsMale = "Male";
    }
}