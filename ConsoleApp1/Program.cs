using static LinqDemo.ListGenerator;
using LinqDemo;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using Microsoft.VisualBasic;
namespace ConsoleApp1
{
    

    #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
    class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            x.ToLower();
            y.ToLower();

            return x.CompareTo(y);
        }
    }
    #endregion

    

    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Restriction Operators

            #region 1. Find all products that are out of stock.
            //var OutOfStockPriducts = ProductList.Where(product => product.UnitsInStock == 0);
            //foreach(var product in OutOfStockPriducts) Console.WriteLine(product); 
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var InStock3plus = ProductList.Where(product => product.UnitsInStock > 0 && product.UnitPrice > 3);
            //foreach(var product in InStock3plus) Console.WriteLine(product); 
            #endregion

            #region 3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //Dictionary<string, int> dict = new Dictionary<string, int>();
            //for(int i = 0; i <= 9; i++)
            //    dict.Add(Arr[i], i);

            //var res = dict.Where(kv => kv.Key.Length < kv.Value);

            //foreach(var item in res) Console.WriteLine(item); 
            #endregion

            #endregion

            #region LINQ - Element Operators

            #region 1. Get first Product out of Stock 
            //var firstProduct = ProductList.FirstOrDefault(product => product.UnitsInStock == 0, new Product { ProductName = "NA"});
            //Console.WriteLine(firstProduct); 
            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var firstProductOver1000 = ProductList.FirstOrDefault(product => product.UnitPrice > 1000);
            //Console.WriteLine(firstProductOver1000); 
            #endregion

            #region 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var firstNumOver5 = Arr.First(n => n > 5);
            //var secNumOver5 = Arr.First(n => n != firstNumOver5 && n > 5);
            //Console.WriteLine(secNumOver5); 
            #endregion



            #endregion

            #region LINQ - Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var oddCount = Arr.Count(n => n % 2 != 0);
            //Console.WriteLine(oddCount); 
            #endregion

            #region 2. Return a list of customers and how many orders each has.
            //var res = CustomerList.Select(c => new { customerInfo = c, NumberOfOrders = c.Orders.Length});
            //foreach(var item in res) Console.WriteLine(item); 
            #endregion

            #region 3. Return a list of categories and how many products each has
            //var res = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(group => new { category = group.Key, NumberOfProducts = group.Count() });
            //foreach(var item in res) Console.WriteLine(item); 
            #endregion
            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int sum = Arr.Sum();
            //Console.WriteLine(sum); 
            #endregion
            string[] lines = File.ReadAllLines("dictionary_english.txt");

            #region 5. Get the total number of characters of all words in dictionary_english.txt 
            //var res = lines.Select(w => new { word = w, length = w.Length});
            //foreach (var item in res) Console.WriteLine(item); 
            #endregion
            #region 6. Get the length of the shortest word in dictionary_english.txt 
            //var res = lines.Select(w => w.Length).Min();
            //Console.WriteLine(res); 
            #endregion
            #region 7. Get the length of the longest word in dictionary_english.txt
            ////var res = lines.Select(w => w.Length).Max();
            ////Console.WriteLine(res);  
            #endregion
            #region 8. Get the average length of the words in dictionary_english.txt 
            //var res = lines.Select(w => w.Length).Average();
            //Console.WriteLine(res); 
            #endregion

            #endregion

            #region LINQ - Ordering Operators
            #region 1. Sort a list of products by name
            //var res = ProductList.OrderBy(p => p.ProductName);
            //foreach(var item in res) Console.WriteLine(item);
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //Array.Sort(Arr, new CaseInsensitiveComparer());
            //foreach(var item in Arr) Console.WriteLine(item); 
            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var result = ProductList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in result) Console.WriteLine(item);
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var res = Arr.OrderBy(x => x.Length).ThenBy(x => x);
            //foreach(var item in res) Console.WriteLine(item);
            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var res = Arr.OrderBy(x => x.Length).ThenBy(x => x, new CaseInsensitiveComparer());
            //foreach(var item in res) Console.WriteLine(item);
            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var res = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach(var item in res) Console.WriteLine(item);
            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var res = Arr.OrderBy(x => x.Length).ThenBy(x => x, new CaseInsensitiveComparer());
            //foreach(var item in res) Console.WriteLine(item); 
            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var res = Arr.Where(x => x[1] == 'i').Reverse();
            //foreach(var item in res) Console.WriteLine(item); 
            #endregion

            #endregion

            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.
            //var res = ProductList.Select(p => p.ProductName).ToList();
            //foreach(var item in res) Console.WriteLine(item); 
            #endregion
            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types)

            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var res = words.Select(w => new { lower = w.ToLower(), upper = w.ToUpper() });
            //foreach(var item in res) Console.WriteLine(item); 
            #endregion
            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var res = ProductList.Select(p => new { name = p.ProductName, price = p.UnitPrice });
            //foreach(var item in res) Console.WriteLine(item); 
            #endregion

            #region 4. Determine if the value of int in an array matches their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Select(x => $"{x}: {x == Arr[x]}");
            //foreach(var item in res) Console.WriteLine(item); 
            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var res = from a in numbersA
            //          from b in numbersB
            //          where a < b
            //          select $"{a} is less that {b}";

            //foreach(var item in res) Console.WriteLine(item); 
            #endregion

            #region 6. Select all orders where the order total is less than 500.00.
            //var res = CustomerList.SelectMany(c => c.Orders).Where(o => o.Total < 500);
            //foreach(var item in res) Console.WriteLine(item); 
            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.
            //var res = CustomerList.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year < 1998);
            //foreach (var item in res) Console.WriteLine(item); 
            #endregion


            #endregion
        }
    }
}
