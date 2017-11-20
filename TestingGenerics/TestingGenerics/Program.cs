using System;

namespace TestingGenerics
{
    class Program
    {
        private static int _numberIndex;
        private static string _numberValue;

        private static void Main(string[] args)
        {
            var testing = new TestGenerics<string>();
            try
            {
                UserInput(testing);
            }
            catch (OutOfMemoryException e1)
            {
                Console.WriteLine("OutOfMemoryExeption! :( {0}", e1);
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2);
            }
            finally
            {
                Console.WriteLine("Bye");
            }
        }

        
        private static void UserInput(TestGenerics<string> testing)
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
//            do
//            {
//                Console.WriteLine("Pick a number (value)");
//
//            } while (!int.TryParse(Console.ReadLine(), out _numberValue));

            Console.WriteLine("Pick a number (value)");
            _numberValue = Console.ReadLine();
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

        private static void AddUnderscore(TestGenerics<string> testing)
        {
            for (var i = 0; i < testing.Length; i++) Console.Write(testing.Get(i) + ",");
            Console.WriteLine();
        }
    }
}