using System.IO;

namespace AgeGroups
{
    class PrinterFile : Printer
    {
        internal override void Print()
        {
            PrintToFile();
        }

        public void PrintToFile()
        {
            var path = @"C:\Users\kevin\Source\Repos\Cs_Projects\AgeGroups\Output.txt";

            //File.WriteAllText(path, "\n");
            foreach (var element in Output)
            {
                File.AppendAllText(path, element + "\n");
            }
        }
    }
}
