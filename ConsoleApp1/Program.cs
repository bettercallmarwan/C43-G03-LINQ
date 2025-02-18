using static LinqDemo.ListGenerator;
using LinqDemo;
namespace ConsoleApp1
{
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
        }
    }
}
