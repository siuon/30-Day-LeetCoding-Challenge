using System;

namespace _027_Maximal_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a 2D binary matrix filled with 0's and 1's, find the largest square containing only 1's and return its area.
  
             * Example:
             * Input: 
             * 1 0 1 0 0
             * 1 0 1 1 1
             * 1 1 1 1 1
             * 1 0 0 1 0
  
             * Output: 4
             */

            var matrix = new char[4][];
            matrix[0] = new char[] { '1', '0', '1', '0', '0' };
            matrix[0] = new char[] { '1', '0', '1', '1', '1' };
            matrix[0] = new char[] { '1', '1', '1', '1', '1' };
            matrix[0] = new char[] { '1', '0', '0', '1', '0' };

            var solution = new Solution();

            Console.WriteLine(solution.MaximalSquare(matrix) == 4);
        }
    }

    public class Solution
    {
        public int MaximalSquare(char[][] matrix)
        {
            return 0;
        }
    }
}
