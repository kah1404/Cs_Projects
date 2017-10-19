using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGroups
{
    class Printer
    {
        private List<string> _output = new List<string>();

        public void Print()
        {
            PrintToConsole();
            PrintToFile();
        }

        public void PrintToConsole()
        {
            foreach (var element in _output)
            {
                Console.WriteLine(element + "\n");
            }
        }

        public void PrintToFile()
        {
            var path = @"C:\Users\kevin\Source\Repos\Cs_Projects\AgeGroups\PrinterFile.cs";
            File.WriteAllText(path, "");
            foreach (var element in _output)
            {
                File.AppendAllText(path, element + "\n");
            }
        }

        public void AddElement(string element)
        {
            _output.Add(element);
        }
    }
}