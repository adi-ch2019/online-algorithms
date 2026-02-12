public class Program {

    public static void Main(string[] args) {
        string s = "anagram";
        string t = "nagaram";
        Console.WriteLine(IsAnagram(s,t));
    }       
    public static bool IsAnagram(string s, string t) {
        char[] sArray = s.ToArray();
        char[] tArray = t.ToArray();
        Array.Sort(sArray);
        Array.Sort(tArray);
       Console.WriteLine(sArray);
       Console.WriteLine(tArray);
        return new string(sArray) == new string(tArray);
    }
}