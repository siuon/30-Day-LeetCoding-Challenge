using System;

namespace _005_Best_Time_to_Buy_and_Sell_Stock_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices;

            // prices = new int[] { 7, 1, 5, 3, 6, 4 }; // 7

            // Console.WriteLine(MaxProfit(prices));

            // prices = new int[] { 1, 2, 3, 4, 5 }; // 4

            // Console.WriteLine(MaxProfit(prices));

            //prices = new int[] { 1, 2 }; // 1

            //Console.WriteLine(MaxProfit(prices));

            // prices = new int[] { 2, 1, 2, 0, 1 }; // 2

            // Console.WriteLine(MaxProfit(prices));

            prices = new int[] { 1, 9, 6, 9, 1, 7, 1, 1, 5, 9, 9, 9 }; // 25

            Console.WriteLine(MaxProfit(prices));
        }

        public static int MaxProfit(int[] prices)
        {
            var sellItem = -1;
            var profit = 0;
            var i = 0;

            for (; i < prices.Length - 1; i++)
            {
                if (sellItem == -1)
                {
                    if (prices[i] < prices[i + 1])
                    {
                        sellItem = prices[i];
                    }
                }
                else if (prices[i] > prices[i + 1])
                {
                    profit += prices[i] - sellItem;
                    sellItem = -1;
                }
                else if (prices[i] <= prices[i + 1] &&
                         i + 1 == prices.Length - 1)
                {
                    profit += prices[i + 1] - sellItem;
                    sellItem = -1;
                }
            }

            if (sellItem != -1 &&
                prices[i] >= prices[i - 1])
            {
                profit += prices[i] - prices[i - 1];
            }

            return profit;
        }
    }
}
