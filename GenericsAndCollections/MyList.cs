using System;
using System.Collections.Generic;

namespace GenericsAndCollections
{
    public class CustomList<T>
    {
        public int Length => _insertIndex;

        private T[] _array = new T[4];
        private int _insertIndex = 0;

        public void Add(T item)
        {
            if (_array.Length == _insertIndex)
            {
                var newArray = new T[_array.Length * 2];
                Array.Copy(_array, newArray, _array.Length);
                _array = newArray;
            }

            _array[_insertIndex] = item;
            _insertIndex++;
        }

        public T Get(int index)
        {
            return _array[index];
        }
    }
}