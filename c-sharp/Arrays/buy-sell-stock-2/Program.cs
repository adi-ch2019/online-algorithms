using System;

namespace StockProfitCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices1 = { 7, 1, 5, 3, 6, 4 };
            int[] prices2 = { 1, 2, 3, 4, 5 };
            int[] prices3 = { 7, 6, 4, 3, 1 };

            Console.WriteLine("Example 1 Profit: " + MaxProfit(prices1)); // Output: 7
            Console.WriteLine("Example 2 Profit: " + MaxProfit(prices2)); // Output: 4
            Console.WriteLine("Example 3 Profit: " + MaxProfit(prices3)); // Output: 0
        }

        public static int MaxProfit(int[] prices)
        {
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    profit += prices[i] - prices[i - 1];
                }
            }
            return profit;
        }
    }
}
