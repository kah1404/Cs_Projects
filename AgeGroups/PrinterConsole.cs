using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGroups
{
    class PrinterConsole : Printer
    {
        public override void Print()
        {
            base.Print();
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
