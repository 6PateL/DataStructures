using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Model
{
    public class EasyStack<T> : ICloneable
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;
        public bool IsEmpty => items.Count == 0; 

        public void Push(T item)
        {
            items.Add(item);
        }

        public void Clear()
        {
            items.Clear();
        }

        public T Pop()
        {
            if (!IsEmpty)
            {
                var item = items.LastOrDefault();
                items.Remove(item);
                return item; 
            }
            else
            {
                throw new NullReferenceException("stack is empty");
             };
        }
        
        public T Peek()
        {
            if(!IsEmpty)
            {
                var item = items.LastOrDefault();
                return items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("stack is empty");
            }
        }

        public override string ToString()
        {
            return $"Stack with {Count} elements";
        }

        public object Clone()
        {
            var newStack = new EasyStack<T>();
            newStack.items = new List<T>(items);
            return newStack;
        }
    }
}
