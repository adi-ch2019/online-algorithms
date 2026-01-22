public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;
        
        // Step 1: Sort the array (if not already sorted)
        Array.Sort(nums);
        
        // Step 2: Remove duplicates
        int k = 1; // Position for next unique element
        
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[i - 1]) {
                nums[k] = nums[i];
                k++;
            }
        }
        
        return k;
    }
}