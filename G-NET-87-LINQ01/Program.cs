using System;
using System.Linq;
using System.Collections.Generic;

using System;
using System.Linq;
using System.Collections.Generic;

class Product
{
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
    public string Category { get; set; }
}

class Order
{
    public string CustomerID { get; set; }
    public DateTime OrderDate { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> ProductList = new List<Product>
        {
            new Product { ProductName = "Chai", UnitPrice = 18, UnitsInStock = 39, Category = "Beverages" },
            new Product { ProductName = "Chang", UnitPrice = 19, UnitsInStock = 17, Category = "Beverages" },
            new Product { ProductName = "Aniseed Syrup", UnitPrice = 10, UnitsInStock = 13, Category = "Condiments" },
            new Product { ProductName = "Chef Anton's Cajun Seasoning", UnitPrice = 22, UnitsInStock = 53, Category = "Condiments" },
            new Product { ProductName = "Ikura", UnitPrice = 31, UnitsInStock = 31, Category = "Seafood" },
            new Product { ProductName = "Konbu", UnitPrice = 6, UnitsInStock = 24, Category = "Seafood" },
            new Product { ProductName = "Salmon", UnitPrice = 25, UnitsInStock = 0, Category = "Seafood" },
            new Product { ProductName = "Tofu", UnitPrice = 23.25m, UnitsInStock = 35, Category = "Produce" },
            new Product { ProductName = "Sasquatch Ale", UnitPrice = 14, UnitsInStock = 0, Category = "Beverages" },
            new Product { ProductName = "Louisiana Hot Spiced Okra", UnitPrice = 17, UnitsInStock = 20, Category = "Condiments" }
        };

        List<Order> Orders = new List<Order>
        {
            new Order { CustomerID = "ALFKI", OrderDate = new DateTime(1996, 12, 10) },
            new Order { CustomerID = "ANATR", OrderDate = new DateTime(1997, 1, 15) },
            new Order { CustomerID = "ANTON", OrderDate = new DateTime(1998, 5, 20) },
            new Order { CustomerID = "BERGS", OrderDate = new DateTime(1997, 8, 12) }
        };

        #region Question 1
        //var q1 = ProductList.Where(p => p.Category == "Seafood");
        //foreach (var p in q1)
        //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
        #endregion

        #region Question 2
        //var q2 = ProductList.Select(p => p.ProductName);
        //foreach (var name in q2)
        //    Console.WriteLine(name);
        #endregion

        #region Question 3
        //var q3 = ProductList.OrderBy(p => p.UnitPrice);
        //foreach (var p in q3)
        //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
        #endregion

        #region Question 4
        //var q4 = ProductList.Where(p =>
        //    p.UnitPrice >= 10 && p.UnitPrice <= 30);
        //foreach (var p in q4)
        //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
        #endregion

        #region Question 5
        //var q5 = ProductList.Where(p =>
        //    p.UnitsInStock > 0 && p.Category == "Condiments");
        //foreach (var p in q5)
        //    Console.WriteLine(p.ProductName);
        #endregion

        #region Question 6
        //var q6 = ProductList.Select(p => new
        //{
        //    Name = p.ProductName,
        //    Price = p.UnitPrice,
        //    StockStatus = p.UnitsInStock > 0
        //        ? "Available" : "Out of Stock"
        //});
        //foreach (var p in q6)
        //    Console.WriteLine($"{p.Name} - {p.Price} - {p.StockStatus}");
        #endregion

        #region Question 7
        //var q7 = ProductList.Select((p, index) => new
        //{
        //    Position = index + 1,
        //    Name = p.ProductName
        //});
        //foreach (var p in q7)
        //    Console.WriteLine($"{p.Position}. {p.Name}");
        #endregion

        #region Question 8
        //var q8 = ProductList.OrderBy(p => p.Category)
        //                    .ThenByDescending(p => p.UnitPrice);
        //foreach (var p in q8)
        //    Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
        #endregion

        #region Question 9
        //var q9 = ProductList.Where(p => p.Category == "Beverages")
        //                    .OrderByDescending(p => p.UnitsInStock);
        //foreach (var p in q9)
        //    Console.WriteLine($"{p.ProductName} - Stock: {p.UnitsInStock}");
        #endregion

        #region Question 10
        //var q10 =
        //    from o in Orders
        //    from year in new[] { o.OrderDate.Year }
        //    where year >= 1997
        //    select new { o.CustomerID, o.OrderDate };

        //foreach (var order in q10)
        //    Console.WriteLine($"{order.CustomerID} - {order.OrderDate:d}");
        #endregion

        #region Question 11
        //var q11 = ProductList.Select((p, index) => new
        //{
        //    Position = index + 1,
        //    ProductName = p.ProductName
        //});
        //foreach (var p in q11)
        //    Console.WriteLine($"{p.Position}. {p.ProductName}");
        #endregion

        #region Question 12
        //string[] Arr = {
        //    "aPPLE", "AbAcUs", "bRaNcH",
        //    "BlUeBeRrY", "ClOvEr", "cHeRry"
        //};

        //var q12 = Arr.OrderBy(word => word.Length)
        //             .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);
        //foreach (var word in q12)
        //    Console.WriteLine(word);
        #endregion

        #region Question 13
        //string[] digits = { "eight", "five", "six", "nine", "three" };

        //var q13 = digits.Where(d => d.Length >= 2 && d[1] == 'i')
        //                .Reverse();
        //foreach (var digit in q13)
        //    Console.WriteLine(digit);
        #endregion
    }
}
