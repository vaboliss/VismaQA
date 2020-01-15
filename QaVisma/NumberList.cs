using System;
using System.Collections.Generic;
using System.Linq;

namespace QaVisma
{
	public class NumberList
	{
		private readonly List<int> numberList = new List<int>();

		public void Add(string number)
		{
			Validator validator = new Validator();
			if (validator.Validate(number))
			{
				numberList.Add(validator.LatestNumber);
				Console.WriteLine("Number is successfully added");
			}
		}
		public void PrintSize()
		{
			Console.WriteLine("Collection size : " + numberList.Count);
		}
		public void CalculateResult()
		{
			int total = numberList.Sum();
			DateTime thisDay = DateTime.Today;
			int dateValue = (int)thisDay.DayOfWeek;
			double result = total / (double)dateValue;
			Console.WriteLine("The sum divided by " + dateValue + " because it's " + thisDay.DayOfWeek);
			Console.WriteLine(result);

		}

		public void PrintNumbers()
		{
			Console.WriteLine("All numbers :");
			foreach (var number in numberList)
			{
				Console.WriteLine(number);
			}
		}
	}
}
