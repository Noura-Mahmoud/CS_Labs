using L2O___D09;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            #region LINQ - Restriction Operators
            #region Find all products that are out of stock
            //products = ListGenerators.ProductList.Where(product => product.UnitsInStock == 0).ToList();
            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("=========================================\n");

            #endregion

            #region Find all products that are in stock and cost more than 3.00 per unit.
            //products = ListGenerators.ProductList.Where(product => product.UnitPrice > 3 && product.UnitsInStock > 0).ToList();
            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("=========================================\n"); 
            #endregion

            #region Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //for (int i =0;i<Arr.Length;i++)
            //{
            //    if (Arr[i].Length<i)
            //    {
            //        Console.WriteLine(Arr[i]);
            //    }
            //}
            //Console.WriteLine("=========================================\n");
            #endregion

            #endregion
            #region LINQ - Element Operators
            #region Get first Product out of Stock 
            //var prod = ListGenerators.ProductList.Where(product => product.UnitsInStock == 0).FirstOrDefault();
            //Console.WriteLine(prod); 
            #endregion

            #region Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var prod = ListGenerators.ProductList.Where(product => product.UnitPrice>1000).FirstOrDefault();
            //Console.WriteLine(prod);
            #endregion

            #region Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondGt5 = Arr.Where(i => i > 5).ElementAt(1);
            //Console.WriteLine(secondGt5);
            #endregion
            #endregion
            #region LINQ - Set Operators
            #region Find the unique Category names from Product List
            //var catNames = ListGenerators.ProductList.Select(prod => prod.Category).Distinct();
            //foreach (var item in catNames)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Produce a Sequence containing the unique first letter from both product and customer names.
            //var prod = ListGenerators.ProductList.Select(prod=> prod.ProductName[0]);
            //var cust = ListGenerators.CustomerList.Select(cust => cust.CompanyName[0]);
            //var prodCustCom = prod.Union(cust);
            //foreach (var item in prodCustCom)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Create one sequence that contains the common first letter from both product and customer names.
            //var prod = ListGenerators.ProductList.Select(prod => prod.ProductName[0]);
            //var cust = ListGenerators.CustomerList.Select(cust => cust.CompanyName[0]);
            //var prodCustCom = prod.Intersect(cust);
            //foreach (var item in prodCustCom)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var prod = ListGenerators.ProductList.Select(prod => prod.ProductName[0]);
            //var cust = ListGenerators.CustomerList.Select(cust => cust.CompanyName[0]);
            //var prodCustCom = prod.Except(cust);
            //foreach (var item in prodCustCom)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates
            //var prod = ListGenerators.ProductList.Select(prod => prod.ProductName[^3..]);
            //var cust = ListGenerators.CustomerList.Select(cust => cust.CompanyName[^3..]);
            //var prodCustCom = prod.Concat(cust);
            //foreach (var item in prodCustCom)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #endregion
            #region LINQ - Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int countOdd = Arr.Count(num => num % 2 != 0);
            //Console.WriteLine(countOdd);
            #endregion

            #region 2. Return a list of customers and how many orders each has.
            //var custOrder = ListGenerators.CustomerList.Select(cust => new {Customer = cust, Orders = cust.Orders.Length});
            ////Console.WriteLine(custOrder);
            //foreach (var item in custOrder)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("=========================================\n");
            #endregion

            #region 3. Return a list of categories and how many products each has
            //var catProd = ListGenerators.ProductList.Select(prod => new {category = prod.Category, count = prod.Category.Count()}).Distinct();
            //foreach (var item in catProd)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("=========================================\n");
            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Console.WriteLine(Arr.Sum()) ;
            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] lines = File.ReadAllLines(@"dictionary_english.txt", Encoding.UTF8);
            //double chCount = lines.Sum(line => line.Length);
            //Console.WriteLine(chCount);
            #endregion

            #region 6. Get the total units in stock for each product category.
            //var unitsCat = ListGenerators.ProductList.GroupBy(prod => prod.Category);
            //var unitsPerCat = unitsCat.Select(i => new{Category = i.Select(j => j.Category).ToArray()[0] , num = i.Sum(j => j.UnitsInStock)});
            //foreach (var item in unitsPerCat)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine();
            //}
            #endregion

            #region 7. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] lines = File.ReadAllLines(@"dictionary_english.txt", Encoding.UTF8);
            //var minWord = lines.Min(l => l.Length);
            //Console.WriteLine(minWord);
            #endregion

            #region 8. Get the cheapest price among each category's products
            //var prices = ListGenerators.ProductList.GroupBy(prod => prod.Category);
            //var cheapest = prices.Select(i => new { Category = i.Select(j => j.Category).ToArray()[0], minPrice = i.Min(j => j.UnitPrice) });
            //foreach (var item in cheapest)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("=========================================\n");
            #endregion

            #region 9. Get the products with the cheapest price in each category (Use Let)  // imp
            #region cat + price
            //var cheapest = from prod in ListGenerators.ProductList
            //               group prod by prod.Category into prices
            //               let minPrice = prices.Min(p => p.UnitPrice)
            //               select (new { category = prices.Key,products = prices., minPrice = minPrice });
            //foreach (var prod in cheapest)
            //{
            //    Console.WriteLine(prod);
            //} 
            #endregion
            #region cat + cheapest product
            //var result = ListGenerators.ProductList.GroupBy(x => x.Category)
            //            .Select(y => new
            //            {
            //                Category = y.Key,
            //                CheapestProduct = y.OrderBy(z => z.UnitPrice).FirstOrDefault().ProductName
            //            });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine();
            //} 
            #endregion
            #region category + list of products that have min price in each category
            //var result = ListGenerators.ProductList.GroupBy(x => x.Category)
            //            .Select(y => new
            //            {
            //                Category = y.Key,
            //                CheapestProducts = y.Where(z => z.UnitPrice == y.Min(a => a.UnitPrice))
            //            });

            //foreach (var item in result)
            //{
            //    Console.WriteLine("Category: " + item.Category);
            //    foreach (var product in item.CheapestProducts)
            //    {
            //        Console.WriteLine("Cheapest Product: " + product.ProductName);
            //        Console.WriteLine("Price: " + product.UnitPrice);
            //    }
            //} 
            #endregion

            #endregion

            #region 10. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] lines = File.ReadAllLines(@"dictionary_english.txt", Encoding.UTF8);
            //var maxWord = lines.Max(l => l.Length);
            //Console.WriteLine(maxWord);
            #endregion

            #region 11. Get the most expensive price among each catsegory's products.
            //var prices = ListGenerators.ProductList.GroupBy(prod => prod.Category);
            //var expensive = prices.Select(i => new { Category = i.Select(j => j.Category).ToArray()[0], maxPrice = i.Max(j => j.UnitPrice) });
            //foreach (var item in expensive)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("=========================================\n");
            #endregion

            #region 12. Get the products with the most expensive price in each category.  // imp
            //var expensive = ListGenerators.ProductList.GroupBy(p => p.Category)
            //    .Select(p => new { Category = p.Key, ExpensiveProducts = p.Where(prod => prod.UnitPrice == p.Max(i => i.UnitPrice)).ToList() });
            //foreach(var item in expensive)
            //{
            //    Console.WriteLine(item.Category);
            //    foreach (var product in item.ExpensiveProducts) { Console.WriteLine(product.ProductName); }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("=========================================\n");
            #endregion

            #region 13. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] lines = File.ReadAllLines(@"dictionary_english.txt", Encoding.UTF8);
            //var avgWord = lines.Average(w => w.Length);
            //Console.WriteLine(Math.Ceiling( avgWord));
            #endregion

            #region 14. Get the average price of each category's products.
            //var avg = ListGenerators.ProductList.GroupBy(i => i.Category)
            //    .Select(p => new { Category = p.Key, avgPrice = p.Average(i => i.UnitPrice) });
            //foreach ( var item  in avg ) {
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #region LINQ - Ordering Operators
            #region 1. Sort a list of products by name
            //var prods = ListGenerators.ProductList.OrderBy(p => p.ProductName);
            //foreach(var item in prods)
            //{
            //    Console.WriteLine($"{item.ProductName}\n");
            //}
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var ordered = Arr.OrderBy(w => w, new CaseInsensitiveComparer());
            //foreach (var item in ordered) { Console.WriteLine(item); }
            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var sorted = ListGenerators.ProductList.OrderByDescending(p=>p.UnitsInStock).ToList();
            //foreach (var product in sorted) { Console.WriteLine($"{product}\n"); }
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var ordered = Arr.OrderBy(x => x.Length).ThenBy(x => x);
            //foreach (var i in ordered) { Console.WriteLine(i); }
            #endregion

            #region 5. Sort first by word length and then by a case-insensitive sort of the words in an array.
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sorted = words.OrderBy(w => w.Length).ThenBy(w=>w,new CaseInsensitiveComparer());
            //foreach (var word in sorted) { Console.WriteLine(word); }
            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var sorted = ListGenerators.ProductList.OrderBy(p => p.Category).ThenByDescending(d => d.UnitPrice);
            //foreach (var product in sorted) { Console.WriteLine($"{product}\n"); }
            #endregion

            #region 7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sorted = Arr.OrderBy(w => w.Length).ThenByDescending(w => w, new CaseInsensitiveComparer());
            //foreach (var item in sorted) { Console.WriteLine($"{item}\n"); }
            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where(d => d[1] == 'i').Reverse();
            //foreach (var item in result) { Console.WriteLine(item); }
            #endregion
            #endregion
            #region LINQ - Partitioning Operators
            #region 1. Get the first 3 orders from customers in Washington // London
            //var res = ListGenerators.CustomerList.Where(c => c.City == "London").Select(c => c.Orders.Take(3));
            //foreach (var cust in res)
            //{
            //    foreach (var i in cust)
            //        Console.WriteLine(i);
            //    Console.WriteLine();
            //}
            #region another way
            //var res = ListGenerators.CustomerList.Where(c => c.City == "London").SelectMany(c => c.Orders.Take(3));
            //foreach (var cust in res)
            //{
            //    Console.WriteLine(cust);
            //    Console.WriteLine();
            //} 
            #endregion
            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington. //London
            //var res = ListGenerators.CustomerList.Where(c => c.City == "London").Select(c => c.Orders.Skip(2));
            //foreach (var cust in res)
            //{
            //    foreach (var i in cust)
            //        Console.WriteLine(i);
            //    Console.WriteLine();
            //}
            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array. //nice
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = numbers.TakeWhile((x, i) => x > i);
            //foreach(var i in res)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 4. Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile(x=>x%3 !=0);
            //foreach (var x in result) { Console.WriteLine(x); }
            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = numbers.SkipWhile((x,i) => x > i);
            //foreach (var x in res) { Console.WriteLine(x); }
            #endregion
            #endregion
            #region LINQ - Projection Operators
            #region 1. Return a sequence of just the names of a list of products.
            //var res = ListGenerators.ProductList.Select(p=>p.ProductName);
            //foreach (var x in res) { Console.WriteLine(x); }
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var res = words.Select(w => new { upper = w.ToUpper(), lower = w.ToLower() });
            //foreach (var x in res) { Console.WriteLine(x); }
            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var res = ListGenerators.ProductList.Select(p => new { p.ProductName, Price = p.UnitPrice, p.UnitsInStock });
            //foreach (var i in res) { Console.WriteLine(i); }
            #endregion

            #region 4. Determine if the value of ints in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Select((x,i)=> new {x, equality = x==i? true : false});
            //Console.WriteLine("Number: In-place?");
            //foreach (var x in res) { Console.WriteLine($"{x.x}:{x.equality}"); }

            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB. // imp**
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var pairs = numbersA.SelectMany(a => numbersB, (a, b) => new { a, b }).Where(arg => arg.a < arg.b);
            //Console.WriteLine("Pairs where a < b:");
            //foreach (var pair in pairs) { Console.WriteLine($"{pair.a} is less than {pair.b}"); }
            #endregion

            #region 6. Select all orders where the order total is less than 500.00.
            //var res = ListGenerators.CustomerList.SelectMany(c => c.Orders).Where(o => o.Total < 500);
            //foreach (var o in res) { Console.WriteLine(o); }
            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.
            //var res = ListGenerators.CustomerList.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >=1998);
            //foreach (var o in res) { Console.WriteLine(o); }
            #endregion
            #endregion
            #region LINQ - Quantifiers
            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //string[] lines = File.ReadAllLines(@"dictionary_english.txt", Encoding.UTF8);
            //var check = lines.Any(line=>line.Contains("ei"));
            //Console.WriteLine(check);
            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var res = ListGenerators.ProductList.GroupBy(p => p.Category).Where(p => p.Any(p => p.UnitsInStock > 0));
            //foreach (var c in res) { Console.WriteLine(c.Key);
            //    foreach (var p in c) { Console.WriteLine(p); }
            //    Console.WriteLine();
            //}
            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var res = ListGenerators.ProductList.GroupBy(p => p.Category).Where(p => p.All(p => p.UnitsInStock > 0));
            //foreach (var c in res)
            //{
            //    Console.WriteLine(c.Key);
            //    foreach (var p in c) { Console.WriteLine(p); }
            //    Console.WriteLine();
            //}
            #endregion
            #endregion
            #region LINQ - Grouping Operators
            #region 1. Use group by to partition a list of numbers by their remainder when divided by 5 //nice
            //int [] nums =  Enumerable.Range(1, 14).ToArray(); ;
            //var res = nums.GroupBy(x => x % 5).OrderBy(x=>x.Key);
            //foreach (var x in res) {
            //    Console.WriteLine($"Numbers with a remainder of {x.Key} when divided by 5:");
            //    foreach (var i in x)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 2.Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input
            //string[] lines = File.ReadAllLines(@"dictionary_english.txt", Encoding.UTF8);
            //var res = lines.GroupBy(l => l[0]).SelectMany(i=>i);
            //foreach (var x in res) { Console.WriteLine(x); }
            #endregion

            #region 3. Consider this Array as an Input , Use Group By with a custom comparer that matches words that are consists of the same Characters Together // re imp**
            string[] Arr = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };
            var res = Arr.GroupBy(w => w, new WordComparer()).OrderBy(g=>g.Key);
            foreach (var item in res) { 
                Console.WriteLine("..."); 
                foreach(var i in item)
                    Console.WriteLine(i.Trim()); }
            #endregion
            #endregion
        }
    }
    public class CaseSensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.Ordinal);
        }
    }
    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.Ordinal);
        }
    }

    class WordComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return new string(x.Trim().OrderBy(c => c).ToArray()) ==
                   new string(y.Trim().OrderBy(c => c).ToArray());
        }

        public int GetHashCode(string obj)
        {
            return new string(obj.Trim().OrderBy(c => c).ToArray()).GetHashCode();
        }
    }

}