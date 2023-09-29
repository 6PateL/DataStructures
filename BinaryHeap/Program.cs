using BinaryHeap.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeap
{
    public class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();
            var rnd = new Random();
            var startItems = new List<int>();

            for(int i = 0; i < 100; i++)
            {
                startItems.Add(rnd.Next(-1000, 1000)); 
            }

            timer.Start();
            var intHeap = new HeapInt(startItems);
            timer.Stop();
            Console.WriteLine("Первоначальная инициазлизация из 1к элементов" + timer.Elapsed);

            timer.Restart();
            for (int i = 0; i < 100; i++)
            {
                startItems.Add(rnd.Next(-1000, 1000));
            }
            timer.Stop();
            Console.WriteLine("Добавление 2 - тысячи элементов" + timer.Elapsed);

            timer.Restart(); 
            foreach (var item in intHeap)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Вывод 2к элементов" + timer.Elapsed);

            Console.ReadLine();

            //intHeap.Add(20);
            //intHeap.Add(11);
            //intHeap.Add(17);
            //intHeap.Add(7);
            //intHeap.Add(4);
            //intHeap.Add(13);
            //intHeap.Add(15);
            //intHeap.Add(14);

            //while (intHeap.Count > 0)
            //{
            //    Console.WriteLine(intHeap.GetMax());
            //}
            //Console.WriteLine(intHeap);
        }
    }
}
