

IList<int> inputList=new List<int>{2,2,3,3,1,1};
IList<int> outputList=new List<int>();
foreach (int item in inputList)
{
    if (!outputList.Contains(item))
    {
        outputList.Add(item);

    }
}
List<int> sortedList=new List<int>(outputList);
sortedList.Sort();
foreach(int item in sortedList)
Console.WriteLine(item);