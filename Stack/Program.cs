using Stack.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<int> arrayStack = new ArrayStack<int>(4);
            arrayStack.Push(10);
            arrayStack.Push(20);
            arrayStack.Push(30);
            arrayStack.Push(40);

            Console.WriteLine(arrayStack.Peek());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Peek());
            Console.ReadLine();

            LinkedStack<int> linkedStack = new LinkedStack<int>();
            linkedStack.Push(1);
            linkedStack.Push(2);
            linkedStack.Push(3);
            linkedStack.Push(4);
            linkedStack.Push(5);

            Console.WriteLine(linkedStack.Peek());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Peek());
            Console.ReadLine();

            EasyStack<int> easyStack = new EasyStack<int>(); 

            easyStack.Push(1);
            easyStack.Push(2);
            easyStack.Push(3);
            easyStack.Push(4);

            var item = easyStack.Pop();
            var item2 = easyStack.Peek();

            Console.WriteLine(item);
            Console.WriteLine(item2);
            Console.ReadLine(); 
        }
    }
}
