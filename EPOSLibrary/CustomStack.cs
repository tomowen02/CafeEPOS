using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPOSLibrary
{
    class CustomStack<T>
    {
        List<T> items = new List<T>();

        public int Count { get; set; }


        public bool IsEmpty()
        {
            if (items.Count == 0)
            {
                return true;
            }
            return false;
        }

        public void Push(T newItem)
        {
            items.Add(newItem);
            Count += 1;
        }

        public T Pop()
        {
            int index = Count - 1;
            T value = items[index];
            items.RemoveAt(index);
            Count -= 1;
            return value;
        }

        public T Peek()
        {
            return items[Count - 1];
        }
    }
}
