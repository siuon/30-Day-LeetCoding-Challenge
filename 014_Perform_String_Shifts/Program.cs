using System;

namespace _014_Perform_String_Shifts
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * You are given a string s containing lowercase English letters, and a matrix shift, where shift[i] = [direction, amount]:

             * direction can be 0 (for left shift) or 1 (for right shift). 
             * amount is the amount by which string s is to be shifted.
             * A left shift by 1 means remove the first character of s and append it to the end.
             * Similarly, a right shift by 1 means remove the last character of s and add it to the beginning.
             * Return the final string after all operations.

             * Input: s = "abc", shift = [[0,1],[1,2]]
             * Output: "cab"
             * Explanation: 
             * [0,1] means shift to left by 1. "abc" -> "bca"
             * [1,2] means shift to right by 2. "bca" -> "cab"
             */

            var shift = new int[2][];
            shift[0] = new int[] { 0, 1 };
            shift[1] = new int[] { 1, 2 };

            var s = "abc";

            var solution = new Solution();

            Console.WriteLine(solution.StringShift(s, shift));
        }
    }

    public class Solution
    {
        public string StringShift(string s, int[][] shift)
        {
            int shiftDirection;
            int shiftAmount;

            string section1;
            string section2;

            for (int i = 0; i < shift.Length; i++)
            {
                shiftDirection = shift[i][0];
                shiftAmount = shift[i][1];

                if (shiftDirection == 0)
                {
                    section1 = s.Substring(shiftAmount);
                    section2 = s.Substring(0, shiftAmount);
                }
                else
                {
                    section1 = s.Substring(s.Length - shiftAmount);
                    section2 = s.Substring(0, s.Length - shiftAmount);
                }

                s = section1 + section2;
            }

            return s;
        }
    }
}
