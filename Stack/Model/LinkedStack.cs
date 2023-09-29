using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Model
{
    public class LinkedStack<T>
    {
        public Item<T> Head { get; set; }
        public int Count { get; set; }

        public LinkedStack()
        {
            Head = null;
            Count = 0;  
        }

        public LinkedStack(T data)
        {
            var Head = new Item<T>(data);
            Count = 1; 
        }

        public void Push(T data) 
        {
            var item = new Item<T>(data);
            item.Previous = Head;
            Head = item;
            Count++;    
        }

        public T Pop()
        {
            var item = Head;
            Head = Head.Previous;
            Count--;
            return item.Data;
        }

        public T Peek()
        {
            return Head.Data;
        }
    }
}
