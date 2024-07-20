using System;

namespace MyListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            int[] array = myList.GetArray();

            Console.WriteLine("Elements in the array returned by GetArray:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}