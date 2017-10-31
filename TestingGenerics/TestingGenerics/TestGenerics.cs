using System;

namespace TestingGenerics
{
    class TestGenerics<T>
    {
        private T[] _array;
        public int Length { get; private set; }
        public int Capacity => _array.Length;

        public TestGenerics()
        {
            _array = new T[10];
        }

        public void Add(int index, T value)
        {
            Length = Math.Max(Length, index + 1);
            if (index > _array.Length)
            {
                var newSize = _array.Length;
                while (index > newSize) newSize *= 2;
                var newArray = new T[newSize];
                Console.WriteLine("The array length is " + newSize);
                Array.Copy(_array, newArray, _array.Length);
                _array = newArray;
            }
            _array[index] = value;
            Console.WriteLine("index = " + index + " value = " + value);
        }

        public T Get(int i)
        {
            return _array[i];
        }
    }
}