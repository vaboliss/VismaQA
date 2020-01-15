using System;
using System.Globalization;

namespace QaVisma
{
	public class Validator
	{
		private int latestNumber;

		public int LatestNumber => latestNumber;

		public bool Validate(string number)
		{
			try
			{
				latestNumber = int.Parse(number, NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands);
				return true;
			}
			catch (FormatException)
			{
				Console.WriteLine("Bad format");
				return false;
			}
			catch (OverflowException)
			{
				Console.WriteLine("Number can only be in interval [ -2147483648 ; 2147483647 ] ");
				return false;
			}


		}
	}
}
