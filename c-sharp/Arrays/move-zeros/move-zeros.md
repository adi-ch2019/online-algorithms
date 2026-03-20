# 🔍 Duplicate Detection with HashSet in .NET

## 📌 Overview
This project demonstrates a clean and efficient solution to detect duplicates in an integer array using **HashSet** in C#.  
It highlights practical use of built-in collections for performance optimization—an approach I’ve refined over **14+ years of advanced .NET development**.

---

## 🚀 Features
- **Efficient Algorithm**: O(n) average time complexity using HashSet.
- **Modern .NET Practices**: Nullable reference types, implicit usings, and clean separation of logic.
- **Scalable Foundation**: Easily extendable for larger datasets or integration into enterprise applications.

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
