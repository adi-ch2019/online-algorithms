using System;

namespace ReverseIntegerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example 1: " + Reverse(123));   // Output: 321
            Console.WriteLine("Example 2: " + Reverse(-123));  // Output: -321
            Console.WriteLine("Example 3: " + Reverse(120));   // Output: 21
            Console.WriteLine("Example 4: " + Reverse(0));     // Output: 0
        }

        public static int Reverse(int x)
        {
            int result = 0;
            while (x != 0)
            {
                int digit = x % 10;
                x /= 10;

                // Check for overflow before multiplying
                if (result > int.MaxValue / 10 || result < int.MinValue / 10)
                {
                    return 0;
                }

                result = result * 10 + digit;
            }
            return result;
        }
    }
}
