using System;
using System.Collections.Generic;

string inputString="banana";
IDictionary<char,int> charCount=new Dictionary<char,int>();
List<string> outputParts = new List<string>();

foreach(char c in inputString)
{
    if (charCount.ContainsKey(c))
    {
        charCount[c]++;
    }
    else
    charCount.Add(c,1);
     
}
foreach (KeyValuePair<char, int> kvp in charCount)
{
    outputParts.Add($"{kvp.Key}{kvp.Value}");
}
Console.WriteLine(string.Join("", outputParts));