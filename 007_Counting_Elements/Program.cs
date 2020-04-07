using System;
using System.Collections.Generic;
using System.Linq;

namespace _007_Counting_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = new int[] { 1, 1, 3, 3, 5, 5, 7, 7 };
            int[] arr3 = new int[] { 1, 3, 2, 3, 5, 0 };
            int[] arr4 = new int[] { 1, 1, 2, 2 };

            Console.WriteLine(CountElements(arr1) == 2);
            Console.WriteLine(CountElements(arr2) == 0);
            Console.WriteLine(CountElements(arr3) == 3);
            Console.WriteLine(CountElements(arr4) == 2);
        }

        public static int CountElements(int[] arr)
        {
            var arrHash = new HashSet<int>(arr);
            var findCount = 0;

            foreach (var number in arr)
            {
                if (arrHash.FirstOrDefault(it => it == number + 1) != 0)
                {
                    findCount++;
                }
            }

            return findCount;
        }
    }
}
