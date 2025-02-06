using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    public class Product
    {
        public string Category { get; set; }
        public decimal SalesPrice { get; set; }
    }

    public static void Main()
    {
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
}
