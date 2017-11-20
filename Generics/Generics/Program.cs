using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeStuff();
        }

        private static void SomeStuff()
        {
            var test1 = new Test<int>();
            var test2 = new Test<decimal>();
            var test3 = new Test<string>();
            var test4 = new Test<object>();
            var test5 = new Test<int>();

            Console.WriteLine(test1.GetType() == test2.GetType());
            Console.WriteLine(test2.GetType() == test3.GetType());
            Console.WriteLine(test3.GetType() == test4.GetType());
            Console.WriteLine(test4.GetType() == test5.GetType());
            Console.WriteLine(test5.GetType() == test1.GetType());
        }
    }
}
