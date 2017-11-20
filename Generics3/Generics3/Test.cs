using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics3
{
    public class Test <T> : ITest<T>
    {
        public T[] _list;

        public Test()
        {
            _list = new T[10];
        }

        public void Add(int index, T value)
        {
            Console.WriteLine($"{index}:{value}");
        }
    }
}
