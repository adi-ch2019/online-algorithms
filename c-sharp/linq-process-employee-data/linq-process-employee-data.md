# 👩‍💼 Employee Data Processing with LINQ in .NET

## 📌 Overview
This project demonstrates how to use **LINQ** in C# to process employee data.  
It groups employees by department, calculates the **average salary**, and identifies the **highest-paid employee** in each department.  
This example reflects my ability to design **clean, efficient, and maintainable solutions**—skills honed over **14+ years of advanced .NET development**.

---

## 🚀 Features
- Groups employees by **Department**.
- Calculates **average salary per department**.
- Identifies the **highest-paid employee** in each department.
- Outputs results in a clear, formatted structure.
- Built with **.NET 9.0** for modern compatibility.

---

## 🧑‍💻 Code Example
```csharp
public class Employee {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Department { get; set; }
    public decimal? Salary { get; set; }
}

class Program {
    static void Main(string[] args) {
        List<Employee> employees = new List<Employee> {
            new Employee { Id = 1, Name = "John Doe", Department = "IT", Salary = 75000 },
            new Employee { Id = 2, Name = "Jane Smith", Department = "HR", Salary = 65000 },
            new Employee { Id = 3, Name = "Bob Johnson", Department = "IT", Salary = 78000 },
            new Employee { Id = 4, Name = "Alice Brown", Department = "Finance", Salary = 70000 },
            new Employee { Id = 5, Name = "Charlie Davis", Department = "HR", Salary = 68000 },
            new Employee { Id = 6, Name = "Eva Wilson", Department = "Finance", Salary = 72000 }
        };

        var result = employees
            .GroupBy(e => e.Department)
            .Select(g => new {
                Department = g.Key,
                AverageSalary = g.Average(e => e.Salary),
                HighestPaidEmployee = g.OrderByDescending(e => e.Salary).First().Name
            })
            .OrderBy(r => r.Department)
            .ToList();

        foreach (var item in result) {
            Console.WriteLine($"Department: {item.Department}");
            Console.WriteLine($"Average Salary: {item.AverageSalary:C}");
            Console.WriteLine($"Highest Paid Employee: {item.HighestPaidEmployee}");
            Console.WriteLine();
        }
    }
}

``` OUTPUT
Department: Finance
Average Salary: ₹71,000.00
Highest Paid Employee: Eva Wilson

Department: HR
Average Salary: ₹66,500.00
Highest Paid Employee: Charlie Davis

Department: IT
Average Salary: ₹76,500.00
Highest Paid Employee: Bob Johnson
