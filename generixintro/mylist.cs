using System;
using System.Collections.Generic;
using System.Text;

namespace generixintro
{
    class Mylist<T>
    {
        T[] items;
        //Ctor = constructor
        public Mylist()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            // length = eleman sayısı
            // items eleman sayısı 1 + 1  artırır
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
