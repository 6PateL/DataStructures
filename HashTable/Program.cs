using HashTable.Models;
using HashTable.Models.Person;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            var superHashTable = new MySuperHashTable<Person>(100);
            superHashTable.Add(new Person { Name = "Vasa", Age = 25, Gender = 0});
            superHashTable.Add(new Person { Name = "Petya", Age = 27, Gender = 0 });
            superHashTable.Add(new Person { Name = "Anton", Age = 31, Gender = 0 });
            superHashTable.Add(new Person { Name = "Artur", Age = 26, Gender = 0 });

            Console.WriteLine(superHashTable.Search(new Person { Name = "Anton", Age = 25, Gender = 0 }));
            Console.WriteLine(superHashTable.Search(new Person { Name = "Petya", Age = 27, Gender = 0 }));

            Console.ReadLine(); 

            Console.WriteLine();
            var hashTable = new MyHashTable<int, string>(100);
            hashTable.Add(5, "Hello");
            hashTable.Add(18, "World");
            hashTable.Add(777, "Greetings");
            hashTable.Add(7, "Programmer");

            Console.WriteLine(hashTable.Search(6, "Vasa"));
            Console.WriteLine(hashTable.Search(18, "World"));

            Console.ReadLine(); 

            Console.WriteLine();
            var badHashTable = new MyBadHashTable<int>(100);
            badHashTable.Add(5);
            badHashTable.Add(18);
            badHashTable.Add(777);
            badHashTable.Add(7); 

            Console.WriteLine(badHashTable.Search(6));
            Console.WriteLine(badHashTable.Search(18));

            Console.ReadLine(); 
        }
    }
}
