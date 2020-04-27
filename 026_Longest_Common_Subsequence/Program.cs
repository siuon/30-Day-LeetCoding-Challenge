﻿using System;

namespace _026_Longest_Common_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given two strings text1 and text2, return the length of their longest common subsequence.
  
             * A subsequence of a string is a new string generated from the original string with some characters(can be none) 
               deleted without changing the relative order of the remaining characters. (eg, "ace" is a subsequence of "abcde" 
               while "aec" is not). A common subsequence of two strings is a subsequence that is common to both strings.
  
             * If there is no common subsequence, return 0.
  
             * Example 1:
             * Input: text1 = "abcde", text2 = "ace" 
             * Output: 3  
             * Explanation: The longest common subsequence is "ace" and its length is 3.

             * Example 2:
             * Input: text1 = "abc", text2 = "abc"
             * Output: 3
             * Explanation: The longest common subsequence is "abc" and its length is 3.

             * Example 3:
             * Input: text1 = "abc", text2 = "def"
             * Output: 0
             * Explanation: There is no such common subsequence, so the result is 0.
             * 
  
             * Constraints:
             * 1 <= text1.length <= 1000
             * 1 <= text2.length <= 1000
             * The input strings consist of lowercase English characters only.
             */

            string text1, text2;
            var solution = new Solution();

            text1 = "abcde";
            text2 = "ace";
            Console.WriteLine(solution.LongestCommonSubsequence(text1, text2) == 3);
        }
    }

    public class Solution
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            throw new NotFiniteNumberException();
        }
    }
}
