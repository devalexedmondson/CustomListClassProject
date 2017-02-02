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

        }
    }
}
