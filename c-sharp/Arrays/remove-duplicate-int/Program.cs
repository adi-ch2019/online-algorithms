// Example usage
class Program {
    static void Main() {
        Solution sol = new Solution();
        
        // Example 1
        int[] nums1 = {1, 1, 2};
        int k1 = sol.RemoveDuplicates(nums1);
        Console.WriteLine($"k = {k1}");
        Console.Write("Array: [");
        for (int i = 0; i < k1; i++) {
            Console.Write(nums1[i] + (i < k1 - 1 ? ", " : ""));
        }
        Console.WriteLine("]");
        
        // Example 2
        int[] nums2 = {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
        int k2 = sol.RemoveDuplicates(nums2);
        Console.WriteLine($"\nk = {k2}");
        Console.Write("Array: [");
        for (int i = 0; i < k2; i++) {
            Console.Write(nums2[i] + (i < k2 - 1 ? ", " : ""));
        }
        Console.WriteLine("]");
        
        // Example with unsorted array (using Version 2)
        int[] nums3 = {3, 2, 2, 1, 4, 1, 0};
        Console.WriteLine("\nOriginal unsorted: " + string.Join(", ", nums3));
        int k3 = sol.RemoveDuplicates(nums3);
        Console.WriteLine($"k = {k3}");
        Console.Write("Array after sort and dedup: [");
        for (int i = 0; i < k3; i++) {
            Console.Write(nums3[i] + (i < k3 - 1 ? ", " : ""));
        }
        Console.WriteLine("]");
    }

    
}