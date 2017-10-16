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
                Category = "Female Child",
                Sex = "Female",
                LowestPossibleAge = 0,
                HighestPossibleAge = 12
            };
            femaleChild.Show();

            var femaleTeenager = new Teenager
            {
                Category = "Female teenager",
                Sex = "Female",
                LowestPossibleAge = 13,
                HighestPossibleAge = 19
            };
            femaleTeenager.Show();

            var femaleAdult = new Adult
            {
                Category = "Female adult",
                Sex = "Female",
                LowestPossibleAge = 20,
                HighestPossibleAge = 64
            };
            femaleAdult.Show();

            var femaleElder = new Elder
            {
                Category = "Female elder",
                Sex = "Female",
                LowestPossibleAge = 65,
                HighestPossibleAge = 110
            };
            femaleElder.Show();

            var maleChild = new Child
            {
                Category = "Female Child",
                Sex = "Male",
                LowestPossibleAge = 0,
                HighestPossibleAge = 12
            };
            maleChild.Show();

            var maleTeenager = new Teenager
            {
                Category = "Female teenager",
                Sex = "Male",
                LowestPossibleAge = 13,
                HighestPossibleAge = 19
            };
            maleTeenager.Show();

            var maleAdult = new Adult
            {
                Category = "Female adult",
                Sex = "Male",
                LowestPossibleAge = 20,
                HighestPossibleAge = 64
            };
            maleAdult.Show();

            var maleElder = new Elder
            {
                Category = "Female elder",
                Sex = "Male",
                LowestPossibleAge = 65,
                HighestPossibleAge = 110
            };
            maleElder.Show();


            //            UserInputSex(human);
            //            SplitLines();
            //            UserInputAge(child, teenager, adult, elder);
        }

//        private static void DisplayHumanInfo(Child child, Teenager teenager, AdultFemale adult, Elder elder)
//        {
//            SplitLines();
//            Console.WriteLine("A child is " + child.LowestPossibleAge + " years old, to " + child.HighestPossibleAge +
//                              " years old");
//            SplitLines();
//            Console.WriteLine("A teenager is " + teenager.LowestPossibleAge + " years old, to " +
//                              teenager.HighestPossibleAge + " years old");
//            SplitLines();
//            Console.WriteLine("An adult is " + adult.LowestPossibleAge + " years old, to " + adult.HighestPossibleAge +
//                              " years old");
//            SplitLines();
//            Console.WriteLine("An elder is " + elder.LowestPossibleAge + " years old, to " + elder.HighestPossibleAge +
//                              " years old");
//            SplitLines();
//        }

//        private static void UserInputSex(Human human)
//        {
//            Console.WriteLine("Are you a male or female? ");
//
//
//            while (true)
//            {
//                string userInputSex = Console.ReadLine()?.ToLower();
//                if (userInputSex == "female")
//                {
//                    Console.WriteLine("you are a " + human.IsFemale);
//                    return;
//                }
//
//                else if (userInputSex == "male")
//                {
//                    Console.WriteLine("you are a " + human.IsMale);
//                    return;
//                }
//                else
//                {
//                    Console.WriteLine("Try again!");
//                    Console.WriteLine("Type \"female\" if you are a female");
//                    Console.WriteLine("Type \"male\" if you are a male");
//                }
//            }
//        }

//        private static void UserInputAge(Child child, Teenager teenager, AdultFemale adult, Elder elder)
//        {
//            Console.WriteLine("How old are you?");
//            Console.WriteLine("Example: 22");
//            while (true)
//            {
//                string userInputAge = Console.ReadLine();
//                int number;
//                bool result = Int32.TryParse(userInputAge, out number);
//                if (result)
//                {
//                    if (number >= 0 && number < 13)
//                    {
//                        Console.WriteLine("You are a " + child.Category);
//                        DisplayHumanInfo(child, teenager, adult, elder);
//                        return;
//                    }
//                    else if (number >= 13 && number < 20)
//                    {
//                        Console.WriteLine("You are a " + teenager.Category);
//                        DisplayHumanInfo(child, teenager, adult, elder);
//                        return;
//                    }
//                    else if (number >= 20 && number < 65)
//                    {
//                        Console.WriteLine("You are an " + adult.Category);
//                        DisplayHumanInfo(child, teenager, adult, elder);
//                        return;
//                    }
//                    else if (number >= 65 && number <= 110)
//                    {
//                        Console.WriteLine("You are an " + elder.Category);
//                        DisplayHumanInfo(child, teenager, adult, elder);
//                        return;
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Try again!");
//                }
//            }
//        }
//        private static void SplitLines()
//        {
//            Console.WriteLine("____________________________________________");
//        }
    }


}

