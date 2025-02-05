 // there is a products table with > product category and sales price
// Please write a LINQ query which will
// group on Category and return average sales price per category

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

		var listCatAvgSalesPrice = from p in products
		{ select p.Category, avg( p.SalesPrice) 
			group by p.Category, p.SalesPrice			
		};		

    }

}

 