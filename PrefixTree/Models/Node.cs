﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrefixTree.Models
{
    class Node<T>
    {
        public char Symbol { get; set; }
        public T Data { get; set; }
        public bool IsWord { get; set; }
        public string Prefix { get; set; }

        public Dictionary<char, Node<T>> SubNodes { get; set; }

        public Node(char symbol, T data, string prefix)
        {
            Data = data;
            Symbol = symbol;
            SubNodes = new Dictionary<char, Node<T>>();
            Prefix = prefix; 
        }

        public override string ToString()
        {
            return $"{Data} [{SubNodes.Count}] ({Prefix})";
        }

        public Node<T> TryFind(char symbol) 
        {
            if(SubNodes.TryGetValue(symbol, out Node<T> value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }
         
        public override bool Equals(object obj)
        {
            if(obj is Node<T> item)
            {
                return Data.Equals(item);
            }
            else
            {
                return false;
            }
        }
    }
}
