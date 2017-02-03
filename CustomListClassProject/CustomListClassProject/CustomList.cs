using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class MyList<T>
    {
        public T[] objects;
        private T[] blankArray = new T[0];
        public int size;


        public MyList()
        {
            objects = blankArray;
            size = 0;
            
        }
        public MyList(int capacity)
        {
            if (capacity < 0)
            {
                //error
            }
            if (capacity == 0)
            {
                objects = blankArray;
            }
            else
            {
                objects = new T[capacity];
            }
        }
        public void Add (T value)
        {
            if (objects.Length <= size)
            {
                T[] tempArray = new T[size + 1];
                for (int i = 0; i < size; i++)
                {
                    tempArray[i] = objects[i];
                }
                tempArray[size] = value;
                size++;
                objects = tempArray;
            }
        }
        public void Remove(T value)
        {
            if (objects.Length <= size)
            {
                T[] tempArray = new T[size - 1];
                for (int i = 0; i < size; i++)
                {
                    objects[i] = tempArray[i];
                }
                tempArray[size] = value;
                size--;
                objects = tempArray;
            }
        }
        //public void Count(T value)
        //{

        //}

    }
}
