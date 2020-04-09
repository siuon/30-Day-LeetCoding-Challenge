using System;
using System.Collections.Generic;

namespace _009_Backspace_String_Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = "y#fo##f";
            var T = "y#f#o##f";

            Console.WriteLine(BackspaceCompare(S, T));
        }

        public static bool BackspaceCompare(string S, string T)
        {
            return GetBackString(S) == GetBackString(T);
        }

        private static string GetBackString(string input)
        {
            var backStack = new Stack<char>();
            var inputLength = input.Length;

            for (int i = 0; i < inputLength; i++)
            {
                if (input[i] != '#')
                {
                    backStack.Push(input[i]);
                }
                else if (backStack.Count > 0)
                {
                    backStack.Pop();
                }
            }

            return new string(backStack.ToArray());
        }
    }
}
