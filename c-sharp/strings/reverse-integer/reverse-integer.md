# Reverse Integer

## 📖 Problem Statement

Given a signed 32-bit integer `x`, return `x` with its digits reversed.  
If reversing `x` causes the value to go outside the signed 32-bit integer range `[−2³¹, 2³¹ − 1]`, return `0`.

---

## 🧩 Examples

- Input: `123` → Output: `321`  
- Input: `-123` → Output: `-321`  
- Input: `120` → Output: `21`  
- Input: `0` → Output: `0`  

---

## ⚡ Approach

- Extract digits one by one using modulo (`x % 10`).  

- Build the reversed number step by step.  
- Check for overflow before multiplying and adding digits.  
- Return `0` if overflow occurs.

**Time Complexity:** `O(log₁₀(n))` (number of digits)  
**Space Complexity:** `O(1)`  

---

## 💻 Usage

Clone the repository and run:

```bash
dotnet run
