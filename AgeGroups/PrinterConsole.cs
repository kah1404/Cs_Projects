using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGroups
{
    class PrinterConsole : Printer
    {
        internal override void Print()
        {
            PrintToConsole();
        }

        public void PrintToConsole()
        {
            foreach (var element in Output)
            {
                Console.WriteLine(element + "\n");
            }
        }
    }
}
