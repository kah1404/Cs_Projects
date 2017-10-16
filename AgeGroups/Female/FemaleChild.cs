using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgeGroups.Category;

namespace AgeGroups.Female
{
    class FemaleChild : HumanFemale
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine();
        }
    }
}
