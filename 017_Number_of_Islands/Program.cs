using System;

namespace _017_Number_of_Islands
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.
             *
             * Example 1:
             * Input:
             * 11110
             * 11010
             * 11000
             * 00000
             * Output: 1
             * 
             * Example 2:
             * Input:
             * 11000
             * 11000
             * 00100
             * 00011
             * Output: 3
             */

            var grid = new char[4][];

            grid[0] = new char[] { '1', '1', '0', '0', '0' };
            grid[1] = new char[] { '1', '1', '0', '0', '0' };
            grid[2] = new char[] { '0', '0', '1', '0', '0' };
            grid[3] = new char[] { '0', '0', '0', '1', '1' };


            var solution = new Solution();

            Console.WriteLine(solution.NumIslands(grid));
        }
    }

    public class Solution
    {
        public int NumIslands(char[][] grid)
        {
            throw new NotImplementedException();
        }
    }
}
