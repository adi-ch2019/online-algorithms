var sw = new Stopwatch();
sw.Start();
Merge(nums1, m, nums2, n);
sw.Stop();
Console.WriteLine($"Optimized merge: {sw.ElapsedTicks} ticks");


void Merge(int[] nums1, int m, int[] nums2, int n)
{
    int i = m - 1;       // pointer for nums1
    int j = n - 1;       // pointer for nums2
    int k = m + n - 1;   // pointer for placement in nums1
    while (j >= 0)
    {
        if (i >= 0 && nums1[i] > nums2[j])
        {
            nums1[k--] = nums1[i--];
        }
        else
        {
            nums1[k--] = nums2[j--];
        }
    }
}
