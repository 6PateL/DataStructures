
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Models
{
    public class CircularLinkedList<T> : IEnumerable
    {
        public DuplexItem<T> Head { get; set; }
        public DuplexItem<T> Tail { get; set; }
        public int count { get; set; }

        public CircularLinkedList()
        {
            
        }

        public CircularLinkedList(T data)
        {
            SetHeadItem(data);
        }

        public void Add(T data)
        {
            if(count == 0)
            {
                SetHeadItem(data);
                return; 
            }

            var item = new DuplexItem<T>(data);
            item.Next = Head;
            item.Previous = Head.Previous;
            Head.Previous.Next = item;
            Head.Previous = item;
            count++; 
        }

        public void Remove(T data)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (current == Tail)
                    {
                        current.Previous.Next = Tail.Next;

                        count--;
                        return;
                    }
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    count--;
                    return;
                }
                current = current.Next;
            }
        }

        private void SetHeadItem(T data)
        {
            Head = new DuplexItem<T>(data);
            Head.Next = Head;
            Head.Previous = Head;
            count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head; 

            for(int i = 0; i < count; i++)
            {
                yield return current;
                current = current.Next;
            }
        }
    }
}
