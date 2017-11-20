using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics3
{
    class Program
    {
        private static int _numberValue;

        static void Main(string[] args)
        {
            var test = new Test<string>();

            SomeMethod(test);

            while (!int.TryParse(Console.ReadLine(), out _numberValue ));
            var userInputValue = Console.ReadLine();
            

            test.Add(_numberValue, userInputValue);

        }

        private static void SomeMethod(ITest<string> test)
        {
            test.Add(1, "test");
        }
    }
}
