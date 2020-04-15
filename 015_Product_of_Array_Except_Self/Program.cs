using System;
using System.Collections.Generic;
using System.Linq;

namespace _015_Product_of_Array_Except_Self
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given an array nums of n integers where n > 1,  
            // return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].

            var input = new int[] { 1, 2, 3, 4 };
            // Output: [24,12,8,6]

            //var input = new int[] { 0, 0 };
            // Output: [0, 0]

            var solution = new Solution();

            Console.WriteLine(string.Join(",", solution.ProductExceptSelf(input)));
        }
    }

    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            List<int> values = new List<int>();
            int sum;

            for (int i = 0; i < nums.Length; i++)
            {
                sum = 1;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j) continue;

                    sum *= nums[j];
                }

                values.Add(sum);
            }

            return values.ToArray();
        }
    }
}
