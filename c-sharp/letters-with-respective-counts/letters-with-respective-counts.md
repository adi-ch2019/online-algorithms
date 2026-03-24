# 🔡 Letters with Respective Counts in .NET

## 📌 Overview

This project demonstrates how to **count the frequency of characters in a string** using C# collections (`Dictionary<char,int>`).  
It’s a simple but powerful example of how to leverage built-in data structures for clarity and efficiency—reflecting the coding discipline I’ve honed over **14+ years of advanced .NET development**.

---

## 🚀 Features

- Counts occurrences of each character in a given string.
- Uses **Dictionary** for fast lookups and updates.
- Outputs results in a compact format (e.g., `banana` → `b1a3n2`).
- Built with **.NET 8.0** for modern compatibility.

---

## 🧑‍💻 Code Example

```csharp
using System;
using System.Collections.Generic;

string inputString = "banana";
IDictionary<char,int> charCount = new Dictionary<char,int>();
List<string> outputParts = new List<string>();

foreach (char c in inputString) {
    if (charCount.ContainsKey(c)) {
        charCount[c]++;
    } else {
        charCount.Add(c, 1);
    }
}

foreach (KeyValuePair<char, int> kvp in charCount) {
    outputParts.Add($"{kvp.Key}{kvp.Value}");
}

Console.WriteLine(string.Join("", outputParts));
// Output: b1a3n2
