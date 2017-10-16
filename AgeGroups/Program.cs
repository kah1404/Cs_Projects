using System;
using AgeGroups.Category;

namespace AgeGroups
{
    public class Program
    {
        static void Main(string[] args)
        {
            var femaleChild = new Child
            {
                Category = "Child",
                Sex = "Female",
                LowestPossibleAge = 0,
                HighestPossibleAge = 12
            };
            femaleChild.Show();

            var femaleTeenager = new Teenager
            {
                Category = "Teenager",
                Sex = "Female",
                LowestPossibleAge = 13,
                HighestPossibleAge = 19
            };
            femaleTeenager.Show();

            var femaleAdult = new Adult
            {
                Category = "Adult",
                Sex = "Female",
                LowestPossibleAge = 20,
                HighestPossibleAge = 64
            };
            femaleAdult.Show();

            var femaleElder = new Elder
            {
                Category = "Elder",
                Sex = "Female",
                LowestPossibleAge = 65,
                HighestPossibleAge = 110
            };
            femaleElder.Show();

            var maleChild = new Child
            {
                Category = "Child",
                Sex = "Male",
                LowestPossibleAge = 0,
                HighestPossibleAge = 12
            };
            maleChild.Show();

            var maleTeenager = new Teenager
            {
                Category = "Teenager",
                Sex = "Male",
                LowestPossibleAge = 13,
                HighestPossibleAge = 19
            };
            maleTeenager.Show();

            var maleAdult = new Adult
            {
                Category = "Adult",
                Sex = "Male",
                LowestPossibleAge = 20,
                HighestPossibleAge = 64
            };
            maleAdult.Show();

            var maleElder = new Elder
            {
                Category = "Elder",
                Sex = "Male",
                LowestPossibleAge = 65,
                HighestPossibleAge = 110
            };
            maleElder.Show();
            SplitLines();
            UserInputSex(femaleChild, maleChild);
            SplitLines();
            UserInputAge(maleChild, maleTeenager, maleAdult, maleElder);
            SplitLines();
        }

        private static void UserInputSex(Child femaleChild, Child maleChild)
        {
            Console.WriteLine("Are you a male or female?");
            while (true)
            {
                string userInputSex = Console.ReadLine()?.ToLower();
                if (userInputSex == "female")
                {
                    Console.WriteLine("you are a " + femaleChild.Sex);
                    return;
                }

                else if (userInputSex == "male")
                {
                    Console.WriteLine("you are a " + maleChild.Sex);
                    return;
                }
                else
                {
                    Console.WriteLine("Try again!");
                    Console.WriteLine("Type \"female\" if you are a female");
                    Console.WriteLine("Type \"male\" if you are a male");
                }
            }
        }


        private static void UserInputAge(Child child, Teenager teenager, Adult adult, Elder elder)
        {
            Console.WriteLine();
            Console.WriteLine("How old are you?");
            Console.WriteLine("Example: 22");
            SplitLines();
            while (true)
            {
                string userInputAge = Console.ReadLine();
                int number;
                bool result = Int32.TryParse(userInputAge, out number);
                if (result)
                {
                    if (number >= 0 && number < 13)
                    {
                        Console.WriteLine("You are a " + child.Category);
                        return;
                    }
                    else if (number >= 13 && number < 20)
                    {
                        Console.WriteLine("You are a " + teenager.Category);
                        return;
                    }
                    else if (number >= 20 && number < 65)
                    {
                        Console.WriteLine("You are an " + adult.Category);
                        return;
                    }
                    else if (number >= 65 && number <= 110)
                    {
                        Console.WriteLine("You are an " + elder.Category);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            }
        }

        private static void SplitLines()
        {
            Console.WriteLine();
        }
    }
}