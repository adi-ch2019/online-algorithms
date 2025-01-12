using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        
        // Test for finding the longest substring without repeating characters
        Console.WriteLine("\nFinding the Length of Longest Substring Without Repeating Characters:");
        string inputString = "abcabcbb";
        int length = LengthOfLongestSubstring(inputString);
        Console.WriteLine($"Input String: \"{inputString}\"");
        Console.WriteLine($"Length of Longest Substring Without Repeating Characters: {length}");
    }

    

    public static int LengthOfLongestSubstring(string s)
    {
        int n = s.Length;
        int maxLength = 0;
        Dictionary<char, int> charIndex = new Dictionary<char, int>();
        int left = 0;

        for (int right = 0; right < n; right++)
        {
            if (charIndex.ContainsKey(s[right]))
            {
                left = Math.Max(charIndex[s[right]] + 1, left);
            }

            charIndex[s[right]] = right;
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
