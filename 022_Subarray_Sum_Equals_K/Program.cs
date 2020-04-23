using System;
using System.Collections.Generic;

namespace _022_Subarray_Sum_Equals_K
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Given an array of integers and an integer k, you need to find the total number of continuous subarrays whose sum equals to k.

             *Example 1:
             *Input:nums = [1,1,1], k = 2
             *Output: 2
             
             *Note:
             *The length of the array is in range [1, 20,000].
             *The range of numbers in the array is [-1000, 1000] and the range of the integer k is [-1e7, 1e7].
             */

            var nums = new int[] { 1, 1, 1 };
            var k = 2;

            var solution = new Solution();

            Console.WriteLine(solution.SubarraySum(nums, k));
        }
    }

    public class Solution
    {
        public int SubarraySum(int[] nums, int k)
        {
            var subarraySum = 0;
            var sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum = 0;

                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];

                    if (sum == k)
                    {
                        subarraySum++;
                    }
                }
            }

            return subarraySum;
        }
    }
}
