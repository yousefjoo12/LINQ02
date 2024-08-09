using LINQ01;
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
			#region 5

			#endregion
			#endregion

		}
	}
}
