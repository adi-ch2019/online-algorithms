# 🔍 Duplicate Detection with HashSet in .NET

## 📌 Overview

This project demonstrates a clean and efficient solution to detect duplicates in an integer array using **HashSet** in C#.  

---

## 🚀 Features

- **Efficient Algorithm**: O(n) average time complexity using HashSet.
- **Modern .NET Practices**: Nullable reference types, implicit usings, and clean separation of logic.
- **Scalable Foundation**: Easily extendable for larger datasets or integration into enterprise applications.

---

## 🧑‍💻 Code Example

```csharp
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
  
```
