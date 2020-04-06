using System;

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            Console.WriteLine(MaxSubArray(nums));
        }

        public static int MaxSubArray(int[] nums)
        {
            var i = 0;
            var sum = 0;
            var max = int.MinValue;

            while (i < nums.Length)
            {
                sum = 0;

                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];

                    max = sum > max ? sum : max;
                }
                
                i++;
            }

            return max;
        }
    }
}
