using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGroups
{
    class Elder : Adult
    {
        public Elder()
        {
            LowestPossibleAge = 65;
            HighestPossibleAge = 110;
            Name = "Elder";
        }
    }
}
