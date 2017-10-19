using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGroups
{
    abstract class Printer
    {
        public List<string> Output = new List<string>();

        public virtual void Print()
        {
            
        }


        public void AddElement(string element)
        {
            Output.Add(element);
        }

    }
}
