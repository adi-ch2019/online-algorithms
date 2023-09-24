using System;
using System.Collections.Generic;

int [] A= {0,1,1,3,3,3,0,0};
int [] B={1,2,3,4,5,6,7,8};
IDictionary<int, int[]> dictRoutes=new Dictionary<int,int[]>(); 
for(int i=0,j=0;i<A.Length && j<B.Length ;i++,j++)
{   
    if (dictRoutes.ContainsKey(A[i]))
    { 
        int [] modified =dictRoutes[A[i]];
        List<int> list = new List<int>(modified);
        list.Add(B[j]);
        modified = list.ToArray();
        
        dictRoutes[A[i]]=modified;
    }
    else
    {
        dictRoutes.Add(A[i],new int[] {B[j]});
    }

}

int Sum=0;
foreach(KeyValuePair<int,int[]> pair in dictRoutes)
{
    int key = pair.Key;
    int[] values = pair.Value;

    // Print the key
    Console.WriteLine("Key: " + key);
    
    // Print the values using a loop
    Console.Write("Values: ");
    for (int i = 0; i < values.Length; i++)
    {
        Sum++;
        Console.Write(values[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("find no of routes to node zero is "+Sum);
