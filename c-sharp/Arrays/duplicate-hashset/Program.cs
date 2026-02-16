public class Program {
    public static void Main(string[] args) {
        int[] nums = {1, 2, 3, 1};
        Program p = new Program();
        bool result = p.ContainsDuplicate(nums);
        Console.WriteLine(result); // Output: True
    }
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> hsNums=new HashSet<int>();
        
        foreach(int i in nums)
        {
            if(!hsNums.Add(i)) return true;
           
        }    
        return false;
    }
}