using System;
using System.Collections.Generic;

namespace MyListExample
{
    public static class MyExtensions
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            List<T> tempList = new List<T>();
            foreach (var item in list)
            {
                tempList.Add(item);
            }
            return tempList.ToArray();
        }
    }
}

