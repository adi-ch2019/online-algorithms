/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class VersionControl {
    private int badVersion;

    // Constructor to set the bad version for testing
    public VersionControl(int bad) {
        badVersion = bad;
    }

    // Simulated API
    protected bool IsBadVersion(int version) {
        return version >= badVersion;
    }
}

public class Solution : VersionControl {
    public Solution(int bad) : base(bad) {}

    public int FirstBadVersion(int n) {
        int left = 1;
        int right = n;

        while (left < right) {
            int mid = left + (right - left) / 2; // avoid overflow
            if (IsBadVersion(mid)) {
                right = mid; // mid could be the first bad version
            } else {
                left = mid + 1; // first bad version must be after mid
            }
        }

        return left; // when left == right, it's the first bad version
    }
}

// Test Program
public class Program {
    public static void Main() {
        // Example 1: n = 5, bad = 4
        Solution sol1 = new Solution(4);
        Console.WriteLine(sol1.FirstBadVersion(5)); // Output: 4

        // Example 2: n = 1, bad = 1
        Solution sol2 = new Solution(1);
        Console.WriteLine(sol2.FirstBadVersion(1)); // Output: 1

        // Example 3: n = 10, bad = 7
        Solution sol3 = new Solution(7);
        Console.WriteLine(sol3.FirstBadVersion(10)); // Output: 7
    }
}
