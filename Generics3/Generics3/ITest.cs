using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics3
{
    public interface ITest<T>
    {
        void Add(int index, T value);
    }
}
