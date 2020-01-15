using System;

namespace QaVisma
{
	internal class Program
	{
		private const string Menu =
			"[1] Add numbers to collection\n" +
			"[2] Size of collection\n" +
			"[3] All numbers in collection\n" +
			"[4] Clear console\n" +
			"[5] Clear collection\n" +
			"[6] Exit\n" +
			"Choose the option: ";

		public static NumberList numberList = new NumberList();

		private static void Main(string[] args)
		{
			bool showMainMenu = true;
			while (showMainMenu)
			{
				showMainMenu = MainMenu();
			}
		}

		private static bool MainMenu()
		{
			Console.WriteLine(Menu);
			switch (Console.ReadLine())
			{
				case "1":
					Console.WriteLine("Enter number and press enter (0 to get the sum of all number divided by the day number )");
					string number = Console.ReadLine();
					bool collect = true;
					while (collect)
					{
						switch (number)
						{
							case "0":
								collect = false;
								numberList.CalculateResult();
								break;
							default:
								numberList.Add(number);
								number = Console.ReadLine();
								break;
						}
					}
					return true;
				case "2":
					numberList.PrintSize();
					return true;
				case "3":
					numberList.PrintNumbers();
					return true;
				case "4":
					Console.Clear();
					return true;
				case "5":
					numberList = new NumberList();
					return true;
				case "6":
					return false;
				default:
					return true;
			}


		}
	}
}
