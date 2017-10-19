//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//
//namespace AgeGroups
//{
//    class PrinterFile : Printer
//    {
//        public override void Print()
//        {
//            base.Print();
//            PrintToFile();
//        }
//
//        public void PrintToFile()
//        {
//            var path = @"C:\Users\kevin\Source\Repos\Cs_Projects\AgeGroups\PrinterFile.cs";
//            File.WriteAllText(path, "");
//            foreach (var element in Output)
//            {
//                File.AppendAllText(path, element + "\n");
//            }
//        }
//    }
//}
