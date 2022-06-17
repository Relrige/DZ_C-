using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Generic_types
{
    class MyStack<T> : IStack<T>, IEnumerable<T>
    {
        const int defaultCapacity = 10;
        const int defaultGrow = 5;
        const int empty = -1;
        T[] stack;
        int top = empty; 
        public MyStack(int capacity = defaultCapacity)
        {
            stack = new T[capacity];
        }
        public int Size => top + 1;
        public uint Count { get; }

        public bool Empty()
        {
            return top == empty;
        }

        public T Peek()
        {
            if (top != -1)
            {
                return stack[top]; 
            }
            else
                throw new Exception("Error peek");

        }

        public void Pop()
        {
            --top;
        }
        private bool Full()
        {
            return top == stack.Length - 1;
        }
        public void Push(T elem)
        {
            if (Full())  
            {
                Array.Resize(ref stack, stack.Length + defaultGrow);
            }
            stack[++top] = elem; 
        }
        public void CopyTo(T[] array, int index)
        {
            for (int i = index; i < array.Length; i++)
            {
                array[i] = stack[i];
            }
        }
        public bool TryPeek(out T result)
        {
            T a = Peek();
            if (Convert.ToInt32(a) != -1)
            {
                result = a;
                return true;
            }
            result = default(T);
            return false;
        }
        public bool TryPop(out T result)
        {
            T a = Peek();
            if (Convert.ToInt32(a) != -1)
            {
                result = a;
                Pop();
                return true;
            }
            result = default(T);
            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = top; i >=0; i--) 
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //for (int i = top; i >= 0; i--) 
            //{
            //    yield return stack[i];
            //}
            return this.GetEnumerator();
        }
    }
}
