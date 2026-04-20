# Merge Sorted Arrays (In‑Place)

## Problem Statement

You are given two sorted integer arrays `nums1` and `nums2`, along with their respective lengths `m` and `n`.  
The goal is to merge them into a single sorted array, stored **in‑place** inside `nums1`.

- `nums1` has length `m + n`, with trailing zeros reserved for `nums2`.
- The merged result must be sorted in non‑decreasing order.

---

## Optimized Solution

We solve this in **O(m+n)** time and **O(1)** extra space by working backwards from the end of `nums1`.

```csharp
public void Merge(int[] nums1, int m, int[] nums2, int n)
{
    int i = m - 1;       // pointer for nums1
    int j = n - 1;       // pointer for nums2
    int k = m + n - 1;   // pointer for placement in nums1

    while (j >= 0)
    {
        if (i >= 0 && nums1[i] > nums2[j])
            nums1[k--] = nums1[i--];
        else
            nums1[k--] = nums2[j--];
    }
}
