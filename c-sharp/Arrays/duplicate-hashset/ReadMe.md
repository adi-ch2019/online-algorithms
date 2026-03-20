# Duplicate Detection with HashSet in .NET

## 📌 Overview
This project demonstrates a simple yet efficient solution to detect duplicates in an integer array using **HashSet** in C#.  
It’s part of my professional portfolio, showcasing clean, optimized, and production-ready coding practices developed over 14+ years of experience in **.NET development, troubleshooting, and optimization**.

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
