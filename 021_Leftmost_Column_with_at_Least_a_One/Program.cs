using System;
using System.Collections.Generic;

namespace _021_Leftmost_Column_with_at_Least_a_One
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * (This problem is an interactive problem.)

             * A binary matrix means that all elements are 0 or 1. For each individual row of the matrix, 
               this row is sorted in non-decreasing order.

             * Given a row-sorted binary matrix binaryMatrix, return leftmost column index(0-indexed) 
               with at least a 1 in it. If such index doesn't exist, return -1.

             * You can't access the Binary Matrix directly.  You may only access the matrix using a BinaryMatrix interface:
               BinaryMatrix.get(x, y) returns the element of the matrix at index (x, y) (0-indexed).
               BinaryMatrix.dimensions() returns a list of 2 elements [n, m], which means the matrix is n * m.

             * Submissions making more than 1000 calls to BinaryMatrix.get will be judged Wrong Answer.  Also, 
               any solutions that attempt to circumvent the judge will result in disqualification.

             * For custom testing purposes you're given the binary matrix mat as input in the following four examples. 
               You will not have access the binary matrix directly.
             */
        }
    }

    // This is BinaryMatrix's API interface.
    // You should not implement it, or speculate about its implementation
    interface BinaryMatrix
    {
        int Get(int x, int y);
        IList<int> Dimensions();
    }

    class Solution
    {
        public int LeftMostColumnWithOne(BinaryMatrix binaryMatrix)
        {
            var nm = binaryMatrix.Dimensions();
            var columns = nm[0];
            var rows = nm[1];
            
            var hasBoth = 0;
            var ret = 0;

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    hasBoth += binaryMatrix.Get(y, x);

                    if (hasBoth > 0)
                    {
                        return ret;
                    }
                }

                ret++;
            }

            return -1;
        }
    }
}
