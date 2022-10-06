using System;
using System.Collections;
using System.Collections.Generic;

namespace Module3HW1
{
    internal class MyList<T> : IEnumerable
    {
        private const int DoubleSize = 2;
        private T[] _data;
        private int _count = 0;
        private int _capacity;
        public MyList(int initialCapacity = 4)
        {
            if (initialCapacity < 1)
            {
                initialCapacity = 0;
            }

            _capacity = initialCapacity;
            _data = new T[initialCapacity];
        }

        public int Count
        {
            get { return _count; }
        }

        public T[] Data
        {
            get { return _data; }
        }

        public int Capacity
        {
            get { return _capacity; }
        }

        public IEnumerator GetEnumerator() => _data.GetEnumerator();

        // Add додавання нового елементу в список
        public void Add(T newElement)
        {
            if (_count == _capacity)
            {
                Resize();
            }

            _data[_count] = newElement;
            _count++;
        }

        // AddRange: додавання в список колекції або масиву
        public void AddRange(List<T> newElement)
        {
            for (var i = 0; i < newElement.Count; i++)
            {
                if (_count == _capacity)
                {
                    Resize();
                }

                _data[_count] = newElement[i];
                _count++;
            }
        }

        // AddRange: додавання в список колекції або масиву
        // перегрузка функції
        public void AddRange(T[] newElement)
        {
            for (var i = 0; i < newElement.Length; i++)
            {
                if (_count == _capacity)
                {
                    Resize();
                }

                _data[_count] = newElement[i];
                _count++;
            }
        }

        // Remove видаляє елемент item із списку, і якщо видалення прошло успішно, то повертає true
        public bool Remove(T item)
        {
            var res = Array.Find(_data, el => el.ToString() == item.ToString());
            if (res == null)
            {
                return false;
            }

            var index = Array.IndexOf(_data, item);
            _data[index] = default;
            return true;
        }

        // RemoveAt: видалення елементу по вказаному індексу index
        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= _count)
            {
                return false;
            }

            _data[index] = default;
            return true;
        }

        // Sort: сортування списку
        public void Sort(IComparer<T> comparer)
        {
            Array.Sort(_data, comparer);
        }

        private void Resize()
        {
            T[] resized = new T[_capacity * DoubleSize];
            for (var i = 0; i < _capacity; i++)
            {
                resized[i] = _data[i];
            }

            _data = resized;
            _capacity = _capacity * DoubleSize;
        }
    }
}
