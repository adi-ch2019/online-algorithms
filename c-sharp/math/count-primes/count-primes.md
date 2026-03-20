# 🔢 Prime Numbers with Sieve of Eratosthenes in .NET

## 📌 Overview
This project demonstrates how to generate prime numbers up to a given limit using the **Sieve of Eratosthenes** algorithm in C#.  
It highlights efficient algorithm design, memory management, and clean coding practices—reflecting the expertise I’ve built over **14+ years of advanced .NET development**.

---

## 🚀 Features
- Implements the **Sieve of Eratosthenes** for prime number generation.
- Two-pass approach:
  1. Count primes.
  2. Allocate and fill an array of primes.
- Outputs all prime numbers up to `n`.
- Built with modern **.NET** project setup.

---

## 🧑‍💻 Code Example
```csharp
int n = 10;
bool[] isPrime = new bool[n];
for (int i = 2; i < n; i++) isPrime[i] = true;

// Sieve
for (int i = 2; i * i < n; i++) {
    if (isPrime[i]) {
        for (int j = i * i; j < n; j += i) {
            isPrime[j] = false;
        }
    }
}

// First pass: count primes
int count = 0;
for (int i = 2; i < n; i++) {
    if (isPrime[i]) count++;
}

// Allocate array
int[] primesArray = new int[count];

// Second pass: fill array
int index = 0;
for (int i = 2; i < n; i++) {
    if (isPrime[i]) {
        primesArray[index++] = i;
    }
}

// Print array
Console.WriteLine("Prime numbers array:");
foreach (int prime in primesArray) {
    Console.Write(prime + " ");
}
// Output: Prime numbers array: 2 3 5 7
