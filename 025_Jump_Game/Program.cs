using System;

namespace _025_Jump_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of non-negative integers, you are initially positioned at the first index of the array.
  
             * Each element in the array represents your maximum jump length at that position.
  
             * Determine if you are able to reach the last index.
  
             * Example 1:
  
             * Input: [2,3,1,1,4]
             * Output: true
             * Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
             * Example 2:
  
             * Input: [3,2,1,0,4]
             * Output: false
             * Explanation: You will always arrive at index 3 no matter what. Its maximum
             * jump length is 0, which makes it impossible to reach the last index.
             */

            var solution = new Solution();
            int[] nums;

            // nums = new int[] { 2, 3, 1, 1, 4 };
            // Console.WriteLine(solution.CanJump(nums) == true);

            // nums = new int[] { 3, 2, 1, 0, 4 };
            // Console.WriteLine(solution.CanJump(nums) == false);

            // nums = new int[] { 0 };
            // Console.WriteLine(solution.CanJump(nums) == true);

            nums = new int[] { 2, 5, 0, 0 };
            Console.WriteLine(solution.CanJump(nums) == true);

            // nums = new int[] {2, 0};
            // Console.WriteLine(solution.CanJump(nums) == true);
        }
    }

    public class Solution
    {
        private bool _hitLast = false;
        private int[] _nums;

        public bool CanJump(int[] nums)
        {
            _nums = nums;

            Jump(1);

            return _hitLast;
        }

        private void Jump(int currentStep)
        {
            if (_hitLast) { return; }

            if (currentStep >= _nums.Length)
            {
                _hitLast = true;

                return;
            }
            else
            {
                if (currentStep < _nums.Length)
                {
                    var step = _nums[currentStep - 1];
                    
                    for (int i = 1; i <= step; i++)
                    {
                        Jump(currentStep + i);
                    }
                }
            }
        }
    }
}
