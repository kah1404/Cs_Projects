using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGroups
{
    class AddElementToPrinter : AddElements
    {
        internal List<string> Output = new List<string>();
        public void AddElement(string element)
        {
            Output.Add(element);
        }
    }
}
