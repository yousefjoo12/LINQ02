﻿using LINQ01;
using System.Collections;
using static LINQ01.ListGenerator;
namespace LINQ02
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Element Operators
			#region 1
			//var Res = ProductsList.First(p => p.UnitsInStock == 0);
			//         Console.WriteLine(Res);
			#endregion
			#region 2
			//var Res = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
			//Console.WriteLine(Res);
			#endregion
			#region 3
			//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
			//var Res = Arr.Where(n => n > 5).Skip(1).First();
			//Console.WriteLine(Res);
			#endregion
			#endregion
			#region Aggregate Operators
			#region 1
			//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
			//var Result = Arr.Where(p => p % 2 != 0).Count();
			//Console.WriteLine(Result);
			#endregion
			#region 2
			//var Result = CustomersList.Select(c => new
			//{
			//	Id = c.CustomerID,
			//	Name = c.CustomerName,
			//	orderNumbers = c.Orders.Count()
			//});
			//foreach (var item in Result)
			//{
			//	Console.WriteLine(item);
			//}
			#endregion
			#region 3
			//var Result = ProductsList.GroupBy(C => C.Category).Select(P => new
			//{
			//	ProductKey = P.Key,
			//	productNumbers = P.Count()
			//});

			//foreach (var Item in Result)
			//{
			//	Console.WriteLine(Item);
			//}
			#endregion
			#region 4
			//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

			//var Res = Arr.Sum();
			//Console.WriteLine($"Result :: {Res}");
			#endregion
			//string[] word = File.ReadAllLines("dictionary_english.txt");
			#region 5
			//int totalChar = word.Sum(w => w.Length);
			//Console.WriteLine($"totalChar: {totalChar}");
			#endregion
			#region 9
			//var Result = ProductsList.GroupBy(P => P.Category).Select(C => new
			//{
			//	Category = C.Key,
			//	UnitsInStock = C.Sum(p => p.UnitsInStock)
			//});
			//foreach (var item in Result)
			//{
			//    Console.WriteLine($"Category: {item.Category}, Total of Stock: {item.UnitsInStock}");
			//}
			#endregion
			#region 10
			//var Result = ProductsList.GroupBy(P => P.Category).Select(C => new
			//{
			//	Category = C.Key,
			//	UnitPrice = C.Min(p => p.UnitPrice)
			//});
			//foreach (var item in Result)
			//{
			//	Console.WriteLine($"Category: {item.Category}, Total of Stock: {item.UnitPrice}");
			//}
			#endregion
			#region 11
			//var Result = from P in ProductsList

			//			 group P by P.Category into C

			//			 let CheapProduct = C.OrderBy(p => p.UnitPrice).FirstOrDefault()

			//			 select new
			//			 {
			//				 Category = C.Key,
			//				 CheapProduct = CheapProduct
			//			 };
			//foreach (var price in Result)
			//{
			//	Console.WriteLine($"Category: {price.Category}, Product: {price.CheapProduct?.ProductName}, Price: {price.CheapProduct?.UnitPrice}");
			//}

			#endregion
			#region 12

			//var Result = from product in ProductsList
			//			 group product by product.Category into productGroup
			//			 select new
			//			 {
			//				 Category = productGroup.Key,
			//				 ExpensivePrice = productGroup.Max(p => p.UnitPrice)
			//			 };

			//foreach (var item in Result)
			//{
			//	Console.WriteLine($"Category: {item.Category}, Most Expensive Price: {item.ExpensivePrice}");
			//}

			#endregion
			#region 13

			//var Result = from P in ProductsList
			//			 group P by P.Category into o
			//			 let ExpensiveProduct = o.OrderByDescending(p => p.UnitPrice).FirstOrDefault()
			//			 select new
			//			 {
			//				 Category = o.Key,
			//				 ExpensiveProduct = ExpensiveProduct
			//			 };

			//foreach (var item in Result)
			//{
			//	Console.WriteLine($"Category: {item.Category}, Product: {item.ExpensiveProduct?.ProductName}, Price: {item.ExpensiveProduct?.UnitPrice}");
			//}

			#endregion
			#region 14

			//var Result = ProductsList.GroupBy(P => P.Category).Select(C => new
			//{
			//	Category = C.Key,
			//	AveragePrice = C.Average(p => p.UnitPrice)
			//});

			//foreach (var item in Result)
			//{
			//	Console.WriteLine($"Category: {item.Category}, Average Price: {item.AveragePrice}");
			//}
			#endregion
			#endregion
			#region Set Operators
			#region 1
			//var Result = ProductsList.Select(p => p.Category).Distinct();

			//foreach (var item in Result)
			//{
			//    Console.WriteLine(item);
			//}
			#endregion
			var list01 = ProductsList.Select(P => P.ProductName[0]);
			var list02 = CustomersList.Select(C => C.CustomerName[0]);
			#region 2
			//var Result = list01.Union(list02);
			//foreach (var item in Result)
			//{
			//	Console.WriteLine(item);
			//}
			#endregion
			#region 3
			//var Result = list01.Intersect(list02);

			//foreach (var item in Result)
			//{
			//	Console.WriteLine(item);
			//}
			#endregion
			#region 4
			//var Result = list01.Except(list02);

			//foreach (var item in Result)
			//{
			//	Console.WriteLine(item);
			//}
			#endregion
			#endregion
			#region  Partitioning Operators
			#region 1

			//var Result = CustomersList.Where(C => C.Region == "WA").SelectMany(C => C.Orders).Take(3); ;

			//foreach (var item in Result)
			//{
			//	Console.WriteLine(item);
			//}

			#endregion
			#region 2

			//var Result = CustomersList.Where(C => C.Region == "WA").SelectMany(C => C.Orders).Skip(2); ;

			//foreach (var item in Result)
			//{
			//	Console.WriteLine(item);
			//}
			#endregion
			#region 3
			//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

			//var Result = numbers.TakeWhile((v, i) => v > i);
			//foreach (var item in Result)
			//{
			//	Console.WriteLine(item);
			//}
			#endregion
			#region 4
			//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

			//var Result = numbers.Where(p => p % 3 == 0 && p != 0);
			//foreach (var item in Result)
			//{
			//	Console.WriteLine(item);
			//}
			#endregion
			#region 5

			//int[] nums = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

			//var Result = nums.SkipWhile((v, i) => v >= i);
			//foreach (var item in Result)
			//{
			//	Console.WriteLine(item);
			//}
			#endregion
			#endregion
			#region Quantifiers

			#region 2

			//var Result = ProductsList.GroupBy(p => p.Category).Where(I => I.Count(p => p.UnitsInStock == 0) > 0);
			//foreach (var item in Result)
			//{
			//	Console.WriteLine(item);
			//	foreach (var prod in item)
			//		Console.WriteLine(prod);
			//}

			#endregion
			#region 3

			//var result = ProductsList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock > 0));
			//foreach (var category in result)
			//{
			//	Console.WriteLine(category.Key);
			//	foreach (var product in category)
			//	{
			//		Console.WriteLine(product);
			//	}
			//}

			#endregion
			#endregion
			#region Grouping Operators

			#region 1

			//List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

			//var Result = numbers.GroupBy(n => n % 5);

			//foreach (var item in Result)
			//{
			//	Console.WriteLine($"remainder of {item.Key}  divided by 5:");
			//	foreach (var number in item)
			//	{
			//		Console.WriteLine(number);
			//	}
			//}

			#endregion
			#region 2

			#endregion

			#region 3
			string[] arr = { "from", "salt", "earn", "last", "near", "form" };

			var groupedWords = arr.GroupBy(word => new string(word.OrderBy(c => c).ToArray()));

			foreach (var group in groupedWords)
			{
				Console.WriteLine($"*********************");
				foreach (var word in group)
				{
					Console.WriteLine(word);
				}
			}
			#endregion

			#endregion

		}
	}
}
