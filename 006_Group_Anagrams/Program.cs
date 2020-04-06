using System;
using System.Collections.Generic;
using System.Linq;

namespace _006_Group_Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };

            var result = GroupAnagrams(input);

            foreach (var item in result)
            {
                Console.WriteLine(string.Join(", ", item));
            }
        }

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var ret = new List<IList<string>>();
            var pool = new Dictionary<string, int>();
            var poolIndex = 0;

            foreach (var str in strs)
            {
                var sortString = string.Concat(str.OrderBy(it => it));

                if (pool.ContainsKey(sortString))
                {
                    ret[pool.First(it => it.Key == sortString).Value].Add(str);
                }
                else
                {
                    ret.Add(new List<string> { str });
                    pool.Add(sortString, poolIndex);

                    poolIndex++;
                }
            }

            return ret;
        }
    }
}
