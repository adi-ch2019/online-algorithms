int[] nums1 = {1,2,3,0,0,0};
int m = 3;
int[] nums2 = {2,5,6};
int n = 3;

Solution sol = new Solution();
sol.Merge(nums1, m, nums2, n);

Console.WriteLine(string.Join(",", nums1));
// Output: 1,2,2,3,5,6

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = m - 1;       // Pointer for nums1
        int j = n - 1;       // Pointer for nums2
        int k = m + n - 1;   // Pointer for placement in nums1

        // Merge in reverse order
        while (i >= 0 && j >= 0) {
            if (nums1[i] > nums2[j]) {
                nums1[k] = nums1[i];
                i--;
            } else {
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }

        // Copy remaining elements from nums2 if any
        while (j >= 0) {
            nums1[k] = nums2[j];
            j--;
            k--;
        }
    }
}
