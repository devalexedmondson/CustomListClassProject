﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class MyList<T> : IEnumerable
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
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < objects.Length; i++)
            {
                yield return objects[i];
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
        public  void Remove(T value)
        {
            if (objects.Length <= size)
            {
                T[] tempArray = new T[size - 1];
                bool placeHolder = true;
                for (int i = 0; i < size; i++)
                {
                    if (!objects[i].Equals(value) && placeHolder)
                    {
                        tempArray[i] = objects[i];
                    }
                    else if (i != size - 1)
                    {
                        placeHolder = false;
                        tempArray[i] = objects[i + 1];
                    }
                }
                size--;
                objects = tempArray;
            }
        }
        public new virtual void ToString()
        {

        }


















        //public static MyList<T> operator+(MyList<T> x, MyList<T> y)
        //{
        //    MyList<T> list = new MyList<T>();
        //    list.Add = x.Add + y.Add;
        //    return list;
        //}
        //public void Count()
        //{
        //    /*1. Get the .Length of the objects array
        //      2. convert the answer, ToString();
        //    */
        //}
    }
}
