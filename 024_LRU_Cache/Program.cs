using System;
using System.Collections.Generic;
using System.Linq;

namespace _024_LRU_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Design and implement a data structure for Least Recently Used (LRU) cache. 
               It should support the following operations: get and put.
  
             * get(key) - Get the value (will always be positive) of the key if the key exists in the cache, otherwise return -1.
             * put(key, value) - Set or insert the value if the key is not already present. When the cache reached its capacity, 
               it should invalidate the least recently used item before inserting a new item.
  
             * The cache is initialized with a positive capacity.
  
             * Follow up:
             * Could you do both operations in O(1) time complexity?
  
             * Example:
  
             * LRUCache cache = new LRUCache( 2 // capacity  );
  
             * cache.put(1, 1);
             * cache.put(2, 2);
             * cache.get(1);       // returns 1
             * cache.put(3, 3);    // evicts key 2
             * cache.get(2);       // returns -1 (not found)
             * cache.put(4, 4);    // evicts key 1
             * cache.get(1);       // returns -1 (not found)
             * cache.get(3);       // returns 3
             * cache.get(4);       // returns 4
             */

            LRUCache cache = new LRUCache(2);
            cache.Put(2, 1);
            cache.Put(1, 1);
            cache.Put(2, 3);
            cache.Put(4, 1);
            Console.WriteLine(cache.Get(1)); // returns -1
            Console.WriteLine(cache.Get(2)); // returns  3
        }
    }

    public class LRUCache
    {
        private List<Item> _Items;
        private int _Capacity;

        public LRUCache(int capacity)
        {
            _Items = new List<Item>();
            _Capacity = capacity;
        }

        public int Get(int key)
        {
            var item = _Items.Where(it => it.Key == key)
                             .OrderByDescending(it => it.UpdateTime)
                             .FirstOrDefault();

            if (item != null)
            {
                item.UpdateTime = DateTime.Now;

                return item.Value;
            }
            else
            {
                return -1;
            }
        }

        public void Put(int key, int value)
        {
            var item = _Items.Where(it => it.Key == key)
                             .OrderBy(it => it.UpdateTime)
                             .FirstOrDefault();

            if (item != null)
            {
                item.Value = value;
                item.UpdateTime = DateTime.Now;
            }
            else
            {
                if (_Items.Count == _Capacity)
                {
                    var renewItem = _Items.OrderBy(it => it.UpdateTime).First();
                    
                    renewItem.Key = key;
                    renewItem.Value = value;
                    renewItem.UpdateTime = DateTime.Now;
                }
                else
                {
                    _Items.Add(new Item()
                    {
                        Key = key,
                        Value = value,
                        UpdateTime = DateTime.Now
                    });
                }
            }
        }
    }

    public class Item
    {
        public int Key { get; set; }
        public int Value { get; set; }
        public DateTime UpdateTime { get; set; }
    }

    /**
     * Your LRUCache object will be instantiated and called as such:
     * LRUCache obj = new LRUCache(capacity);
     * int param_1 = obj.Get(key);
     * obj.Put(key,value);
     */
}
