using System;
using System.Collections.Generic;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsHappy(19));
        }

        static int maxloop = 100;
        static int count = 0;

        public static bool IsHappy(int n)
        {
            return HappyNumber(n);
        }

        public static bool HappyNumber(int n)
        {
            var list = new List<int>();
            var number = 0d;
            var nString = n.ToString();

            for (int i = 0; i < nString.Length; i++)
            {
                number += Math.Pow(int.Parse(nString[i].ToString()), 2);
            }

            if (number == 1)
            {
                return true;
            }
            else 
            {
                if (count > maxloop)
                {
                    return false;
                }

                count++;
                return HappyNumber(Convert.ToInt32(number));
            }
        }
    }
}
