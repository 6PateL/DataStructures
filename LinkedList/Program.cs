using LinkedList.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var duplexList = new DuplexLinkedList<int>(); 
            duplexList.Add(1);
            duplexList.Add(2);  
            duplexList.Add(3);  
            duplexList.Add(4);
            duplexList.Add(5);

            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            duplexList.Remove(3);
            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            DuplexLinkedList<int> reverse = duplexList.Reverse(); 
            foreach(var item in reverse)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            var circularList = new CircularLinkedList<int>();
            circularList.Add(1);
            circularList.Add(2);
            circularList.Add(3);
            circularList.Add(4); 
            circularList.Add(5); 

            foreach(var item in circularList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
