class Program
{
    static void Main(string[] args)
    {
        int[] nums={1, 1, 2, 2, 3, 4, 4, 5};
        Array.Sort(nums);
        int k=1;
        for(int i=0;i<nums.Length-1;i++)
        {
            if(nums[i]!=nums[i+1])
            {
                nums[k]=nums[i+1];
                k++;
            }            
        }
        for(int j=k-1;j<nums.Length;j++)
        {
            nums[j]=' ';
        }
        Console.WriteLine($"k = {k}");
        Console.Write("Array: [");  
         for (int i = 0; i < nums.Length; i++) {
            Console.Write(nums[i] + (i < nums.Length - 1 ? ", " : ""));
        }
        Console.WriteLine("]");
    }
}