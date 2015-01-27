﻿using System.Collections.Generic;
using System;
namespace L2S04
{
    public class MyList<T>
        where T : IComparable, new()
    {
        List<T> innerList=new List<T>();

        public void Add(T arg) { innerList.Add(arg); }

        public T this[int index]
        {
            get
            {
                if (index >= innerList.Count) return default(T);
                return innerList[index];
            }
            set
            {
                while (index >= innerList.Count)
                    innerList.Add(new T());
                innerList[index] = value;
            }
        }

        public void Sort()
        {
            for (int i=0;i<innerList.Count;i++)
                for (int j=0;j<innerList.Count;j++)
                    if (innerList[i].CompareTo(innerList[j]) < 0)
                    {
                        var temp = innerList[i];
                        innerList[i] = innerList[j];
                        innerList[j] = temp;
                    }
        }
    }
}
//!Требование к генерик-параметру на реализацию интерфейса