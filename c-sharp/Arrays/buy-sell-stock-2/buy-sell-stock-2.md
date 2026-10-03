# Best Time to Buy and Sell Stock II

## 📖 Problem Statement

You are given an integer array `prices` where `prices[i]` is the price of a given stock on the *iᵗʰ* day.  
On each day, you may decide to buy and/or sell the stock. You can only hold at most one share of the stock at any time.  
Find and return the **maximum profit** you can achieve.

---

## 🧩 Examples

- Input: `[7,1,5,3,6,4]` → Output: `7`  
- Input: `[1,2,3,4,5]` → Output: `4`  
- Input: `[7,6,4,3,1]` → Output: `0`  

---

## ⚡ Approach

The greedy solution works best:

- Add up all **positive differences** between consecutive days.

- This ensures capturing every profitable transaction.

**Time Complexity:** `O(n)`  
**Space Complexity:** `O(1)`

---

## 💻 Usage

Clone the repository and run:

```bash
dotnet run
