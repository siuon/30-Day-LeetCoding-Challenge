using System;
using System.Collections.Generic;

namespace _019_Search_in_Rotated_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
             * (i.e., [0,1,2,4,5,6,7] might become [4,5,6,7,0,1,2]).
             * You are given a target value to search. If found in the array return its index, otherwise return -1.
             * You may assume no duplicate exists in the array.
             * Your algorithm's runtime complexity must be in the order of O(log n).

             * Example 1:
             * Input: nums = [4,5,6,7,0,1,2], target = 0
             * Output: 4

             * Example 2:
             * Input: nums = [4,5,6,7,0,1,2], target = 3
             * Output: -1
             */

            var nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            var target = 3;

            var solution = new Solution();

            Console.WriteLine(solution.Search(nums, target) == -1);
        }
    }

    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            var list = new List<int>(nums);

            return list.IndexOf(target);
        }
    }
}
