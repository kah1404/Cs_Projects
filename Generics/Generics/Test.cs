using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Test <T>
    {
        private T[] _test;

        public Test()
        {
            _test = new T[10];
        }

        public void DoSomething(T[] something)
        {

        }

    }
}
