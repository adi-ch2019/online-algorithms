// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Move Zeroes! to the end of the array while maintaining the relative order of the non-zero elements.");

void MoveZeroes(int[] nums) {
        int lastNonZeroFoundAt = 0;

        // Move non-zero elements forward
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                nums[lastNonZeroFoundAt] = nums[i];
                lastNonZeroFoundAt++;
            }
        }

        // Fill remaining positions with zeros
        for (int i = lastNonZeroFoundAt; i < nums.Length; i++) {
            nums[i] = 0;
        }
    }

        int[] nums = {0, 1, 0, 3, 12};
         Console.WriteLine("Array before moving zeroes:");
        foreach (int num in nums) {
            Console.Write(num + " ");
        }
        MoveZeroes(nums);
        Console.WriteLine(" \n Array after moving zeroes:");
        foreach (int num in nums) {
            Console.Write(num + " ");
        }
  