using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Models
{
    class Tree<T> where T : IComparable, IComparable<T>
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }

        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }
            Root.Add(data);
            Count++;
        }

        public List<T> Preorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Preorder(Root);
        }

        public List<T> PostOrder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return PostOrder(Root);
        }

        public List<T> InOrder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return InOrder(Root);
        }

        private List<T> Preorder(Node<T> node)
        {
            var list = new List<T>();

            if(node != null)
            {
                list.Add(node.Data);
                
                if(node.Left != null)
                {
                    list.AddRange(Preorder(node.Left));
                }

                if(node.Right != null)
                {
                    list.AddRange(Preorder(node.Right));
                }
            }

            return list;
        }

        private List<T> PostOrder(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(PostOrder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(PostOrder(node.Right));
                }

                list.Add(node.Data);
            }

            return list;
        }

        private List<T> InOrder(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(InOrder(node.Left));
                }

                list.Add(node.Data);

                if (node.Right != null)
                {
                    list.AddRange(InOrder(node.Right));
                }
            }

            return list;
        }
    }
}
