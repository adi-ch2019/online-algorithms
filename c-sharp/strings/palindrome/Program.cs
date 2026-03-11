Console.WriteLine("Check if a string is a palindrome.");
string input = Console.ReadLine() ?? string.Empty;// Example input A man, a plan, a canal: Panama

if (IsPalindrome(input))
{
    Console.WriteLine($"'{input}' is a palindrome.");
}
else
{
    Console.WriteLine($"'{input}' is not a palindrome.");
}

static bool IsPalindrome(string str)
{
    int left = 0, right = str.Length - 1;
    while (left < right)
    {
        while(left < right && !char.IsLetterOrDigit(str[left]))
            left++;

        while(left < right && !char.IsLetterOrDigit(str[right]))
            right--;
        if (char.ToLower(str[left]) != char.ToLower(str[right]))
            return false;
        left++;
        right--;
    }   
    return true;
}
