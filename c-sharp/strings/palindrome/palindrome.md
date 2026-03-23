# 🔁 Palindrome Checker in .NET

## 📌 Overview

This project demonstrates how to check if a given string is a **palindrome** using C#. 
It ignores non-alphanumeric characters and is case-insensitive, making it robust for real-world inputs like `"A man, a plan, a canal: Panama"`.  
This example reflects clean algorithm design and practical string handling—skills honed over **14+ years of advanced .NET development**.

---

## 🚀 Features

- Checks if a string is a palindrome.
- Ignores spaces, punctuation, and special characters.
- Case-insensitive comparison.
- Built with **.NET 10.0** for modern compatibility.

---

## 🧑‍💻 Code Example

```csharp
Console.WriteLine("Check if a string is a palindrome.");
string input = Console.ReadLine() ?? string.Empty; 
// Example input: A man, a plan, a canal: Panama

if (IsPalindrome(input)) {
    Console.WriteLine($"'{input}' is a palindrome.");
} else {
    Console.WriteLine($"'{input}' is not a palindrome.");
}

static bool IsPalindrome(string str) {
    int left = 0, right = str.Length - 1;
    while (left < right) {
        while (left < right && !char.IsLetterOrDigit(str[left]))
            left++;

        while (left < right && !char.IsLetterOrDigit(str[right]))
            right--;

        if (char.ToLower(str[left]) != char.ToLower(str[right]))
            return false;

        left++;
        right--;
    }   
    return true;
}
