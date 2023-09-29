using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Models
{
    public class EasyMap<TKey, TValue> : IEnumerable
    {
        private List<Item<TKey, TValue>> Items = new List<Item<TKey, TValue>>();
        private List<TKey> keys = new List<TKey>();

        public int Count => Items.Count; 

        public EasyMap()
        {
            
        }

        public void Add(Item<TKey, TValue> item)
        {
            if(!keys.Contains(item.Key)) 
            {
                keys.Add(item.Key);
                Items.Add(item);
            } 
        }

        public TValue Search(TKey key)
        {
            if (keys.Contains(key))
            {
                return Items.Single(i => i.Key.Equals(key)).Value;
            }
            //throw new Exception();
            return default(TValue);
        }

        public void Remove(TKey key)
        {
            if (keys.Contains(key))
            {
                keys.Remove(key); 
                Items.Remove(Items.Single(i => i.Key.Equals(key))); 
            }
        }

        public IEnumerator GetEnumerator()
        {
           return Items.GetEnumerator(); 
        }
    }
}
