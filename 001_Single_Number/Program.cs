using System;
using System.Collections.Generic;
using System.Linq;

namespace Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 4, 1, 2, 1, 2 };
            
            Console.WriteLine(SingleNumber(nums));
        }

        public static int SingleNumber(int[] nums) {
            var numsList = nums.ToList();
            var list = new HashSet<int>();

            foreach (var item in numsList)
            {
                if (list.Contains(item))
                {
                    list.Remove(item);
                }
                else
                {
                    list.Add(item);
                }
            }

            return list.First();
        }
    }
}
