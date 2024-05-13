using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 4;
        private T[] stack;
        public int Count { get; private set; }
        public Stack() 
        {
            Count = 0;
            stack = new T[InitialCapacity];
        }
        public void Push(T input)
        {
            if (Count >= stack.Length)
            {
                Resize();
            }
            stack[Count] = input;
            Count++;
        }
        private void Resize()
        {
            T[] temp = new T[InitialCapacity * 2];
            for (int i = 0; i < stack.Length; i++)
            {
                temp[i] = stack[i];
            }
            stack = temp;
        }
        public T Peek()
        {
            return stack[Count - 1];
        }
        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            return stack[--Count];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
