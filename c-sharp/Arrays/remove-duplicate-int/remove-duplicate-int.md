# 🧹 Remove Duplicates from Integer Array in .NET

## 📌 Overview

This project demonstrates how to **remove duplicates from an integer array** in C# by:

1. Sorting the array.
2. Iterating through elements to overwrite duplicates.
3. Returning the count of unique elements (`k`).

It’s a practical example of clean, efficient coding practices developed over **14+ years of advanced .NET development**.

---

## 🚀 Features

- Handles both **sorted** and **unsorted arrays** (unsorted arrays are sorted first).
- Returns the number of unique elements (`k`) and modifies the array in place.
- Demonstrates **modern .NET 10.0 project setup** with nullable references and implicit usings enabled.
- Showcases **algorithmic clarity** and **performance awareness**.

---

## 🧑‍💻 Code Example

```csharp
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;
        
        // Step 1: Sort the array (if not already sorted)
        Array.Sort(nums);
        
        // Step 2: Remove duplicates
        int k = 1; // Position for next unique element
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[i - 1]) {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}
