using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Model
{
    public class Item<T>
    {
        public T Data { get; set; }
        public Item<T> Previous { get; set; }
        
        public Item(T data)
        {
            data = Data;
        }

        public override string ToString()
        {
            return Data.ToString(); 
        }
    }
}
