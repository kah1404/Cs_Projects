using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGroups.Category
{
    class Child : Human
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine();
        }
    }
}
