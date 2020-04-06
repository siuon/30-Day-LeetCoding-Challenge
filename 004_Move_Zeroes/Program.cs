using System;

namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 0, 1 };

            MoveZeroes(nums);

            Console.WriteLine(string.Join(",", nums));
        }

        public static void MoveZeroes(int[] nums)
        {
            var numIndex = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != 0)
                {
                    numIndex++;
                }
                else if (nums[i] == 0 && nums[i + 1] != 0)
                {
                    nums[numIndex++] = nums[i + 1];
                    nums[i + 1] = 0;
                }
            }
        }
    }
}
