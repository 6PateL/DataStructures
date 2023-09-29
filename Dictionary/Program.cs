using Dictionary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EasyMap: ");
            var easyMap = new EasyMap<int, string>();

            easyMap.Add(new Item<int, string>(1,"One"));
            easyMap.Add(new Item<int, string>(2, "Two"));
            easyMap.Add(new Item<int, string>(3, "Three"));
            easyMap.Add(new Item<int, string>(4, "Four"));
            easyMap.Add(new Item<int, string>(5, "Five"));

            
            foreach(var item in easyMap)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine(easyMap.Search(7) ?? "не найдено");
            Console.WriteLine(easyMap.Search(5) ?? "не найдено");

            easyMap.Remove(3);
            easyMap.Remove(1);

            Console.WriteLine();
            foreach (var item in easyMap)
            {
                Console.WriteLine(item);
            };

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("DICT : ");
            var dict = new Dict<int, string>();

            dict.Add(new Item<int, string>(1, "One"));
            dict.Add(new Item<int, string>(1, "One"));
            dict.Add(new Item<int, string>(2, "Two"));
            dict.Add(new Item<int, string>(3, "Three"));
            dict.Add(new Item<int, string>(4, "Four"));
            dict.Add(new Item<int, string>(5, "Five"));
            dict.Add(new Item<int, string>(101, "one hundred one"));

            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine(dict.Search(7) ?? "не найдено");
            Console.WriteLine(dict.Search(5) ?? "не найдено");
            Console.WriteLine(dict.Search(101) ?? "не найдено");

            dict.Remove(7);
            dict.Remove(101);
            dict.Remove(3);
            dict.Remove(1); 

            Console.WriteLine();
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            };

            Console.ReadLine(); 
        }
    }
}
