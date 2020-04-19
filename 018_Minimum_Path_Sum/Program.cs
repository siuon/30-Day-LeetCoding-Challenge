using System;

namespace _018_Minimum_Path_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right which 
             * minimizes the sum of all numbers along its path.
             * Note: You can only move either down or right at any point in time.
             * Example:
             * Input:
             * [
             *   [1,3,1],
             *   [1,5,1],
             *   [4,2,1]
             * ]
             * Output: 7
             * Explanation: Because the path 1→3→1→1→1 minimizes the sum.
             */

            var grid = new int[3][];
            grid[0] = new int[] { 1, 3, 1 };
            grid[1] = new int[] { 1, 5, 1 };
            grid[2] = new int[] { 4, 2, 1 };

            var solution = new Solution();

            Console.WriteLine(solution.MinPathSum(grid) == 7);
        }
    }

    public class Solution
    {
        private int _miniSum = int.MaxValue;
        private int _mapX;
        private int _mapY;
        private int[][] _grid;

        public int MinPathSum(int[][] grid)
        {
            _grid = grid;
            _mapY = grid[0].Length - 1;
            _mapX = grid.Length - 1;

            FindPath(0, 0, 0);

            return _miniSum;
        }

        private void FindPath(int x, int y, int sum)
        {
            sum += _grid[x][y];

            if (sum >= _miniSum)
            {
                return;
            }

            if (x == _mapX && y == _mapY)
            {
                _miniSum = Math.Min(_miniSum, sum);

                return;
            }

            if (x < _mapX)
            {
                FindPath(x + 1, y, sum);
            }

            if (y < _mapY)
            {
                FindPath(x, y + 1, sum);
            }
        }
    }
}
