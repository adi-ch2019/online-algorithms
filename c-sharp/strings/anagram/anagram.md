# 🔄 Anagram Checker in .NET

## 📌 Overview

This project demonstrates how to check if two strings are **anagrams** of each other using C#.  
It leverages array manipulation and sorting to compare character sequences—showcasing clean, efficient coding practices developed over **14+ years of advanced .NET development**.

---

## 🚀 Features

- Compares two strings to determine if they are anagrams.
- Uses `Array.Sort` for character ordering.
- Returns a boolean result (`true` if anagrams, `false` otherwise).
- Built with **.NET 10.0** for modern compatibility.

---

## 🧑‍💻 Code Example

```csharp
public class Program {
    public static void Main(string[] args) {
        string s = "anagram";
        string t = "nagaram";
        Console.WriteLine(IsAnagram(s, t)); // Output: True
    }       

    public static bool IsAnagram(string s, string t) {
        char[] sArray = s.ToArray();
        char[] tArray = t.ToArray();
        Array.Sort(sArray);
        Array.Sort(tArray);

        return new string(sArray) == new string(tArray);
    }
}
