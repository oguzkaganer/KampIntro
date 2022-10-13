using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T> //Generic class
    {
        T[] _array;
        T[] tempArray;

        public MyList()
        {
            _array = new T[0];
        }
        //public MyList() => items = new T[0]; yukarıdaki bu şekildede yazılabilir.

        public void Add(T item)
        {
            tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                _array[i] = tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }

    }
}
