using BinaryTree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1); 
            tree.Add(2);
            tree.Add(8);
            tree.Add(6);
            tree.Add(9);

            foreach(var item in tree.Preorder())
            {
                Console.WriteLine(item + ", ");
            }

            Console.WriteLine();
            foreach (var item in tree.PostOrder())
            {
                Console.WriteLine(item + ", ");
            }

            Console.WriteLine();
            foreach (var item in tree.InOrder())
            {
                Console.WriteLine(item + ", ");
            }
            Console.ReadLine();
        }
    }
}
