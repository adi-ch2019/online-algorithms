# Duplicate Detection with HashSet in .NET

## 📌 Overview

This project demonstrates a simple yet efficient solution to detect duplicates in an integer array using **HashSet** in C#.  

---

## 🚀 Features

- Implements a **HashSet-based algorithm** for O(n) average time complexity.
- Demonstrates **best practices** in C# coding:
  - Clear method separation (`Main` vs `ContainsDuplicate`)
  - Use of built-in collections for efficiency
  - Readable and maintainable structure
- Targets **.NET 10.0** framework for modern compatibility.

---

## 🧑‍💻 Code Example

```csharp
public class Program {
    public static void Main(string[] args) {
        int[] nums = {1, 2, 3, 1};
        Program p = new Program();
        bool result = p.ContainsDuplicate(nums);
        Console.WriteLine(result); // Output: True
    }

    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> hsNums = new HashSet<int>();
        foreach (int i in nums) {
            if (!hsNums.Add(i)) return true;
        }
        return false;
    }
}
