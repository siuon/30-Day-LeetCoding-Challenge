using System;
using System.Collections.Generic;
using System.Linq;

namespace _012_Last_Stone_Weight
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input: [2,7,4,1,8,1]
            // Output: 1
            var stones = new int[] { 2, 7, 4, 1, 8, 1 };

            var solution = new Solution();

            Console.WriteLine(solution.LastStoneWeight(stones));
        }
    }

    public class Solution
    {
        public int LastStoneWeight(int[] stones)
        {
            if (stones.Length < 2)
            {
                return stones[0];
            }

            var arrayLast = stones.Length - 1;
            var arrayLast2 = arrayLast - 1;

            Array.Sort(stones);

            for (int i = stones.Length - 1; i > 0; i--)
            {
                var x = stones[arrayLast];
                var y = stones[arrayLast2];

                stones[arrayLast] = Math.Abs(x - y);
                stones[arrayLast2] = 0;

                Array.Sort(stones);
            }

            return stones.Last();
        }
    }
}
