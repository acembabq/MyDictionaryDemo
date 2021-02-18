using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    class MyDictionary<T>
    {
        public T[] _array;
        public T[] _tempArray;

        public MyDictionary()
        {
            _array = new T[0];
        }

        public void Add(T name) 
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = name;


        }
        public void List()
        {
            foreach (var item in _array)
            {
                Console.WriteLine(item);
            }
        }
        public int Count
        {
            get { return _array.Length; } // specifies the length of the array
        }

    }
}
