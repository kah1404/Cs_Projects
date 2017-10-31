using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGenerics
{
    class Program
    {

        private static int _numberIndex;
        private static int _numberValue;

        private static void Main(string[] args)
        {
            var testing = new TestGenerics<int>();
            testing.Add(0, 1);
            testing.Add(1, 2);
            testing.Add(2, 3);
            testing.Add(39, 1);

            AddUnderscore(testing);

            try
            {
                UserInput(testing);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                UserInput(testing);
            }
        }


        private static void UserInput(TestGenerics<int> testing)
        {
            while (true)
            {
                Console.WriteLine("Do you want to add something to the array? if yes, type \"yes\". else type \"no\" ");
                var userInputStart = Console.ReadLine();

                if (userInputStart == "yes" || userInputStart == "y")
                {
                    Console.Clear();
                    NumberIndex();
                    NumberValue();
                    testing.Add(_numberIndex, _numberValue);
                }
                else if (userInputStart == "no")
                {
                    return;
                }
                AddUnderscore(testing);
            }
        }

        private static void NumberValue()
        {
            do
            {
                Console.WriteLine("Pick a number (value)");
            } while (!int.TryParse(Console.ReadLine(), out _numberValue));
            Console.WriteLine("You entered {0}", _numberValue + "\n");
        }

        private static void NumberIndex()
        {
            do
            {
                Console.WriteLine("Pick a number (index)");
            } while (!int.TryParse(Console.ReadLine(), out _numberIndex));
            Console.WriteLine("You entered {0}", _numberIndex + "\n");
        }

        private static void AddUnderscore(TestGenerics<int> testing)
        {
            for (var i = 0; i < testing.Length; i++) Console.Write(testing.Get(i) + ",");
            Console.WriteLine();
        }
    }
}


