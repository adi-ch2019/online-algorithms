//Given an array of integers, where all elements but one occur twice, find the unique element.
//
//Example a = [1, 2, 3, 4, 3, 2, 1] 
// The unique element is 4.
//
//It is guaranteed that size is an odd number and that there is one unique element.
using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		//Console.WriteLine("Hello World");
		
		IList<int> intNumbers=new List<int>(){1, 2, 3, 4, 5,6,3, 2,6, 1} ;
		//{1,2,3,5,3,2,1}};
		IList<int> notDuplicate=new List<int>();
		IList<int> copyNumbers=new List<int>();
				IList<int> notDuplicate2=new List<int>();
		
		foreach(int i in intNumbers)
		{
			if(!notDuplicate.Contains(i))
				notDuplicate.Add(i);
			else{
				copyNumbers.Add(i);
			}
		}
		foreach(int i in intNumbers)
		{
			if(!copyNumbers.Contains(i))
				notDuplicate2.Add(i);
		}
		foreach(int i in notDuplicate2)
		{
			Console.WriteLine(i);
		}
	}
}