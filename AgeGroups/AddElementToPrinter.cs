using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGroups
{
    class AddElementToPrinter : AddElements
    {
        internal List<string> _output = new List<string>();
        public void AddElement(string element)
        {
            _output.Add(element);
        }
    }
}
