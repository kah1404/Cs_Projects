using System;

namespace AgeGroups
{
    public class Program
    {
        static void Main(string[] args)
        {
            var human = new Human();
            var child = new Child();
            var teenager = new Teenager();
            var adult = new Adult();
            var elder = new Elder();

            UserInputSex(human);
            SplitLines();
            UserInputAge(child, teenager, adult, elder);
        }

        private static void DisplayHumanInfo(Child child, Teenager teenager, Adult adult, Elder elder)
        {
            SplitLines();
            Console.WriteLine("A child is " + child.LowestPossibleAge + " years old, to " + child.HighestPossibleAge +
                              " years old");
            SplitLines();
            Console.WriteLine("A teenager is " + teenager.LowestPossibleAge + " years old, to " +
                              teenager.HighestPossibleAge + " years old");
            SplitLines();
            Console.WriteLine("An adult is " + adult.LowestPossibleAge + " years old, to " + adult.HighestPossibleAge +
                              " years old");
            SplitLines();
            Console.WriteLine("An elder is " + elder.LowestPossibleAge + " years old, to " + elder.HighestPossibleAge +
                              " years old");
            SplitLines();
        }

        private static void UserInputSex(Human human)
        {
            Console.WriteLine("Are you a male or female? ");


            while (true)
            {
                string userInputSex = Console.ReadLine()?.ToLower();
                if (userInputSex == "female")
                {
                    Console.WriteLine("you are a " + human.IsFemale);
                    return;
                }

                else if (userInputSex == "male")
                {
                    Console.WriteLine("you are a " + human.IsMale);
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
            Console.WriteLine("How old are you?");
            Console.WriteLine("Example: 22");
            while (true)
            {
                string userInputAge = Console.ReadLine();
                int number;
                bool result = Int32.TryParse(userInputAge, out number);
                if (result)
                {
                    if (number >= 0 && number < 13)
                    {
                        Console.WriteLine("You are a " + child.Name);
                        DisplayHumanInfo(child, teenager, adult, elder);
                        return;
                    }
                    else if (number >= 13 && number < 20)
                    {
                        Console.WriteLine("You are a " + teenager.Name);
                        DisplayHumanInfo(child, teenager, adult, elder);
                        return;
                    }
                    else if (number >= 20 && number < 65)
                    {
                        Console.WriteLine("You are an " + adult.Name);
                        DisplayHumanInfo(child, teenager, adult, elder);
                        return;
                    }
                    else if (number >= 65 && number <= 110)
                    {
                        Console.WriteLine("You are an " + elder.Name);
                        DisplayHumanInfo(child, teenager, adult, elder);
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
            Console.WriteLine("____________________________________________");
        }
    }


}

