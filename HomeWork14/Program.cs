using System;
using System.Collections;
using System.Collections.Generic;

namespace MyListExample
{
    // Определение класса MyList
    public class MyList<T> : IEnumerable<T>
    {
        private T[] _items;
        private int _count;

        public MyList()
        {
            _items = new T[4];
            _count = 0;
        }

        // Метод добавления элемента
        public void Add(T item)
        {
            if (_count == _items.Length)
            {
                Array.Resize(ref _items, _items.Length * 2);
            }
            _items[_count++] = item;
        }

        // Индексатор для получения значения элемента по индексу
        public T this[int index]
        {
            get
            {
                index--;
                if (index < 0 || index >= _count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                return _items[index];
            }
        }

        // Свойство только для чтения для получения общего количества элементов
        public int Count
        {
            get { return _count; }
        }

        // Реализация метода GetEnumerator для поддержки foreach
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _items[i];
            }
        }

        // Необобщенная реализация метода GetEnumerator
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра MyList
            MyList<int> myList = new MyList<int>();

            // Добавление элементов
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            // Использование индексатора для получения значения элемента
            Console.WriteLine("Element at index 2: " + myList[2]);

            // Получение общего количества элементов
            Console.WriteLine("Total number of elements: " + myList.Count);

            // Перебор элементов с использованием foreach
            Console.WriteLine("Elements in MyList:");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

