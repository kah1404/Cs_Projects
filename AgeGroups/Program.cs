using System;
using AgeGroups.Category;

namespace AgeGroups
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var printToConsole = new PrinterConsole();
            var printToFile = new PrinterFile();

            var femaleChild = new Child
            {
                Category = "Child",
                Sex = "Female",
                LowestPossibleAge = 0,
                HighestPossibleAge = 12
                
            };
            printToConsole.AddElement(femaleChild.Show());
            printToFile.AddElement(femaleChild.Show());

            var femaleTeenager = new Teenager
            {
                Category = "Teenager",
                Sex = "Female",
                LowestPossibleAge = 13,
                HighestPossibleAge = 19
            };
            printToConsole.AddElement(femaleTeenager.Show());
            printToFile.AddElement(femaleTeenager.Show());

            var femaleAdult = new Adult
            {
                Category = "Adult",
                Sex = "Female",
                LowestPossibleAge = 20,
                HighestPossibleAge = 64
            };
            printToConsole.AddElement(femaleAdult.Show());
            printToFile.AddElement(femaleAdult.Show());

            var femaleElder = new Elder
            {
                Category = "Elder",
                Sex = "Female",
                LowestPossibleAge = 65,
                HighestPossibleAge = 110
            };
            printToConsole.AddElement(femaleElder.Show());
            printToFile.AddElement(femaleElder.Show());

            var maleChild = new Child
            {
                Category = "Child",
                Sex = "Male",
                LowestPossibleAge = 0,
                HighestPossibleAge = 12
            };
            printToConsole.AddElement(maleChild.Show());
            printToFile.AddElement(maleChild.Show());

            var maleTeenager = new Teenager
            {
                Category = "Teenager",
                Sex = "Male",
                LowestPossibleAge = 13,
                HighestPossibleAge = 19
            };
            printToConsole.AddElement(maleTeenager.Show());
            printToFile.AddElement(maleTeenager.Show());

            var maleAdult = new Adult
            {
                Category = "Adult",
                Sex = "Male",
                LowestPossibleAge = 20,
                HighestPossibleAge = 64
            };
            printToConsole.AddElement(maleAdult.Show());
            printToFile.AddElement(maleAdult.Show());

            var maleElder = new Elder
            {
                Category = "Elder",
                Sex = "Male",
                LowestPossibleAge = 65,
                HighestPossibleAge = 110
            };
            printToConsole.AddElement(maleElder.Show());
            printToFile.AddElement(maleElder.Show());

            printToConsole.Print();
            printToFile.Print();

        }

 
    }
}