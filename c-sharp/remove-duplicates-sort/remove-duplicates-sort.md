# 🧹 Remove Duplicates and Sort in .NET

## 📌 Overview
This project demonstrates how to **remove duplicate integers from a list** and then **sort the unique values** using C#.  
It highlights practical use of collections (`List<T>`, `IList<T>`) and built-in methods like `Contains` and `Sort`—showcasing clean, efficient coding practices developed over **14+ years of advanced .NET development**.

---

## 🚀 Features
- Removes duplicates from an input list.
- Produces a sorted list of unique integers.
- Demonstrates **collection manipulation** and **basic algorithms** in C#.
- Built with **.NET 9.0** for modern compatibility.

---

## 🧑‍💻 Code Example
```csharp
IList<int> inputList = new List<int> { 2, 2, 3, 3, 1, 1 };
IList<int> outputList = new List<int>();

foreach (int item in inputList) {
    if (!outputList.Contains(item)) {
        outputList.Add(item);
    }
}

List<int> sortedList = new List<int>(outputList);
sortedList.Sort();

foreach (int item in sortedList)
    Console.WriteLine(item);

// Output:
// 1
// 2
// 3
