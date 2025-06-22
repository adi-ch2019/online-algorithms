int a = 0;
int b = 1;
List<int> resultList = new List<int>();
resultList.Add(a);
resultList.Add(b);
for (int i = 0; i < 8; i++)
{
    int c = a + b;
    resultList.Add(c);
    a = b;
    b = c;
}

Console.WriteLine(string.Join(",", resultList));