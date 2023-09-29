using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Model
{
    public class ArrayStack<T>
    {
        T[] items;

        private int size = 10; //max size of stack 
        private int current = -1;

        public int Count => items.Length;

        public ArrayStack(int size = 10) 
        {
            items = new T[size];
            this.size = size;
        }

        public ArrayStack(T data, int size = 10) : this(size)
        {
            items[current] = data; // data.Length = 10; current = 10;
            current = 1;   
        }

        public void Push(T data)
        {
            if(current < size - 1) 
            {
                current++;
                items[current] = data;
            }
            else
            {
                throw new StackOverflowException("stack is overflow");
            }
        }

        public T Pop()
        {
            if(current >= 0)
            {
                var item = items[current];
                items[current] = default(T);
                current--;
                return item;
            }
            else
            {
                throw new NullReferenceException("stack is empty");
            }
        }

        public T Peek()
        {
            if (current >= 0)
            {
                var item = items[current];
                return item;
            }
            else
            {
                throw new NullReferenceException("stack is empty");
            }
        }
    }
}
