using System;
using System.Collections.Generic;
 
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
 
        // Bug: This should use a foreach loop instead of a for loop to avoid index out of range
        for (int i = 0; i <= numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
 
        // Unoptimized: Using a nested loop to find duplicates
        List<int> duplicates = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = i + 1; j < numbers.Count; j++)
            {
                if (numbers[i] == numbers[j] && !duplicates.Contains(numbers[i]))
                {
                    duplicates.Add(numbers[i]);
                }
            }
        }
 
        // Print duplicates
        foreach (var duplicate in duplicates)
        {
            Console.WriteLine("Duplicate: " + duplicate);
        }
    }
}