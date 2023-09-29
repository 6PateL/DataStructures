using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Models
{
    public class DuplexLinkedList<T> : IEnumerable<T>
    {
        public DuplexItem<T> Head { get; set; }
        public DuplexItem<T> Tail { get; set; }
        public int count { get; set; }


        public DuplexLinkedList() { }

        public DuplexLinkedList(T data)
        {
            var item = new DuplexItem<T>(data);
            Head = item;
            Tail = item;
            count = 1; 
        }

        public void Add(T data)
        {
            var item = new DuplexItem<T>(data);

            if (count == 0)
            {
                Head = item;
                Tail = item;
                count = 1;
                return; 
            }
            Tail.Next = item;
            item.Previous = Tail;
            Tail = item;
            count++; 
        }

        public void Remove(T data)
        {
            var current = Head;

            while(current != null)
            {
                if(current.Data.Equals(data))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    count--;
                    return;
                }
                current = current.Next;
            }
        }

        public DuplexLinkedList<T> Reverse()
        {
            var result = new DuplexLinkedList<T>();

            var current = Tail;

            while(current != null)
            {
                result.Add(current.Data);
                current = current.Previous;
            }
            return result;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while(current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator(); 
        }
    }
}
