using System;

namespace _023_Bitwise_AND_of_Numbers_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a range [m, n] where 0 <= m <= n <= 2147483647, 
               return the bitwise AND of all numbers in this range, inclusive.

             * Example 1:
             * Input: [5,7]
             * Output: 4

             * Example 2:
             * Input: [0,1]
             * Output: 0
             */

            var m = 5;
            var n = 7;

            var solution = new Solution();

            Console.WriteLine(solution.RangeBitwiseAnd(m, n) == 4);
        }
    }

    public class Solution
    {
        public int RangeBitwiseAnd(int m, int n)
        {
            var ret = int.MaxValue;

            for (int i = m; i <= n; i++)
            {
                ret &= i;
            }

            return ret;
        }
    }
}
