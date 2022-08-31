using System;
using System.Collections.Generic;
using System.Linq;

namespace PlusMinus
{
	class Result
	{
		public static void plusMinus(List<int> arr)
		{
			int total = arr.Count;
			decimal positiveNum = arr.Where(n => n > 0).Count();
			Console.WriteLine($"Positive numbers ratio: {(positiveNum / total).ToString("0.000000")}"); 

			decimal negativeNum = arr.Where(n => n < 0).Count();
			Console.WriteLine($"Negative numbers ratio: {(negativeNum / total).ToString("0.000000")}");

			decimal zerroNum = arr.Where(n => n == 0).Count();
			Console.WriteLine($"Zerros ratio: {(zerroNum / total).ToString("0.000000")}");

		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine().Trim());

			List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

			Result.plusMinus(arr);

			Console.ReadKey();
		}
	}
}
