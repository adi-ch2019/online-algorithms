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

		 // Sample data
        List<Product> products = new List<Product>
        {
            new Product { Category = "Electronics", SalesPrice = 1000 },
            new Product { Category = "Electronics", SalesPrice = 1200 },
            new Product { Category = "Clothing", SalesPrice = 50 },
            new Product { Category = "Clothing", SalesPrice = 80 },
            new Product { Category = "Groceries", SalesPrice = 10 },
            new Product { Category = "Groceries", SalesPrice = 15 }
        };

        // LINQ query to group by category and calculate average sales price
        var listCatAvgSalesPrice = from p in products
                                   group p by p.Category into g
                                   select new 
                                   {
                                       Category = g.Key,
                                       AvgSalesPrice = g.Average(p => p.SalesPrice)
                                   };

        // Output the results
        foreach (var item in listCatAvgSalesPrice)
        {
            Console.WriteLine($"Category: {item.Category}, Average Sales Price: {item.AvgSalesPrice}");
        }
	}


	 public class Product
    {
        public string Category { get; set; }
        public decimal SalesPrice { get; set; }
    }

}