using System;
using System.Collections.Generic;
using System.Linq;

namespace SortArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInt = new int[] { 2, 4, 0, 1, 0, 5, 0, 0, 7, 0, 6, 5, 0 };

            // Convert array to list for easier manipulation
            List<int> lstInt = arrInt.ToList();

            // Sort the list
            lstInt.Sort();

            // Create two separate lists for non-zero and zero elements
            List<int> lstSub1 = new List<int>();
            List<int> lstSub2 = new List<int>();

            foreach (int a in lstInt)
            {
                if (a == 0)
                    lstSub2.Add(a);
                else
                    lstSub1.Add(a);
            }

            // Combine the non-zero and zero lists
            List<int> lstOutput = new List<int>(lstSub1);
            lstOutput.AddRange(lstSub2);

            // Convert the output list back to an array
            int[] outputArray = lstOutput.ToArray();

            // Print the output
            Console.WriteLine("Output: {" + string.Join(", ", outputArray) + "}");
        }
    }
}
