using System;

namespace Week_2_Exercises
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			//Exercise 1
			Console.WriteLine("Enter some text =>");
			string text = Console.ReadLine();
			Console.WriteLine(text);

			//Exercise 2
			Console.WriteLine("Enter a number =>");
			int number = int.Parse(Console.ReadLine());
			Console.WriteLine(number + 1);

			//Exercise 3
			Console.WriteLine("Enter a number =>");
			double number2 = double.Parse(Console.ReadLine());
			Console.WriteLine(number2 + .5);

			//Exercise 4
			Console.WriteLine("Enter a number =>");
			double number3 = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter another number =>");
			double number4 = double.Parse(Console.ReadLine());
			Console.WriteLine($"The sum is {number3 + number4}");

			//Exercise 5
			Console.WriteLine("Enter a number =>");
			double number5 = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter another number =>");
			double number6 = double.Parse(Console.ReadLine());
			Console.WriteLine($"The product is {number5 * number6}");

			//Exercise 6
			bool go = true;
			do
			{
				Console.WriteLine("Hello, World!");
				Console.WriteLine("Would you like to continue (y/n)?");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 7
			bool go2 = true;
			do
			{
				Console.WriteLine("Enter some text =>");
				string text2 = Console.ReadLine();
				Console.WriteLine(text2);
				Console.WriteLine("Would you like to continue (y/n)?");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go2 = false;
				}
			} while (go2);

			//Exercise 8
			bool go3 = true;
			do
			{
				//Exercise 2.2
				Console.WriteLine("Enter a number =>");
				int number7 = int.Parse(Console.ReadLine());
				Console.WriteLine(number7 + 1);

				//Exercise 3.2
				Console.WriteLine("Enter a number =>");
				double number8 = double.Parse(Console.ReadLine());
				Console.WriteLine(number8 + .5);

				//Exercise 4.2
				Console.WriteLine("Enter a number =>");
				double number9 = double.Parse(Console.ReadLine());
				Console.WriteLine("Enter another number =>");
				double number10 = double.Parse(Console.ReadLine());
				Console.WriteLine($"The sum is {number9 + number10}");

				//Exercise 5.2
				Console.WriteLine("Enter a number =>");
				double number11 = double.Parse(Console.ReadLine());
				Console.WriteLine("Enter another number =>");
				double number12 = double.Parse(Console.ReadLine());
				Console.WriteLine($"The product is {number11 * number12}");
				Console.WriteLine("Would you like to continue (y/n)?");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go3 = false;
				}
			} while (go3);

			//Exercise 9
			bool go4 = true;
			do
			{
				Console.WriteLine("Enter a language (English, Spanish, Dutch) =>");
				string language = Console.ReadLine();
				switch (language.ToLower())
				{
					case "english":
						Console.WriteLine("Hello, World!");
						break;
					case "spanish":
						Console.WriteLine("Hola, Mundo!");
						break;
					case "dutch":
						Console.WriteLine("Hallo, Wereld!");
						break;
					default:
						Console.WriteLine("You didn't enter a language I know. :(");
						break;
				}
				Console.WriteLine("Would you like to continue (y/n)?");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go4 = false;
				}
			} while (go4);

			//Exercise 10
			bool go5 = true;
			do
			{
				Console.WriteLine("Enter your height in inches. =>");
				double height = double.Parse(Console.ReadLine());
				if (height < 54)
				{
					Console.WriteLine($"Sorry, you cannot ride the Raptor.  You need {54 - height} more inches.");
				}
				else
				{
					Console.WriteLine("Great, you can ride the Raptor!");
				}
				Console.WriteLine("Would you like to continue (y/n)?");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go5 = false;
				}
			} while (go5);

			//Exercise 11
			bool go6 = true;
			do
			{
				for (int x = 0; x <= 9; x++)
				{
					Console.Write(x + " ");
				}
				Console.WriteLine("\nWould you like to continue (y/n)?");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go6 = false;
				}
			} while (go6);

			//Exercise 12
			bool go7 = true;
			do
			{
				for (int x = 9; x >= 0; x--)
				{
					Console.Write(x + " ");
				}
				Console.WriteLine("\nWould you like to continue (y/n)?");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go7 = false;
				}
			} while (go7);

			//Exercise 13
			bool go8 = true;
			while (go8)
			{
				Console.WriteLine("Enter a number. =>");
				int number13 = int.Parse(Console.ReadLine());
				for (int x = number13; x >= 0; x--)
				{
					Console.Write(x + " ");
				}

				Console.WriteLine("\nWould you like to continue (y/n)?");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go8 = false;
				}
			}

			//Exercise 14
			bool go9 = true;
			while (go9)
			{
				Console.WriteLine("Enter a number. =>");
				int number14 = int.Parse(Console.ReadLine());
				for (int x = 1; x <= number14; x++)
				{
					Console.Write(x + " ");
				}

				Console.WriteLine("\nWould you like to continue (y/n)?");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go9 = false;
				}
			}

			//Exercise 15
			bool go10 = true;
			while (go10)
			{
				Console.WriteLine("Enter a number. =>");
				int number15 = int.Parse(Console.ReadLine());
				for (int x = 1; x <= number15; x++)
				{
					Console.Write(x*x*x + " ");
				}

				Console.WriteLine("\nWould you like to continue (y/n)?");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go10 = false;
				}
			}

			//Exercise 16
			string stars = "";
			for (int x = 0; x < 10; x++)
			{
				stars += "*";
				Console.WriteLine(stars);
			}

			//Exercise 17
			for (int x = 0; x < 10; x++)
			{
				for (int y = 1; y <= 10 - x; y++)
				{
					Console.Write(" ");
				}
				for (int y = 1; y <= 2 * x - 1; y++)
				{
					Console.Write("*");
				}
				Console.Write("\n");
			}

			//Exercise 18
			bool go11 = true;
			while (go11)
			{
				Console.WriteLine("Enter a number. =>");
				int number16 = int.Parse(Console.ReadLine());
				int sum = 0;
				for (int x = 1; x <= number16; x++)
				{
					sum += x;
				}
				Console.WriteLine(sum);

				Console.WriteLine("\nWould you like to continue (y/n)?");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go11 = false;
				}
			}

			//Exercise 19
			bool go12 = true;
			while (go12)
			{
				Console.WriteLine("Enter a number. =>");
				int number17 = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter another number. =>");
				int number18 = int.Parse(Console.ReadLine());
				int sum2 = 0;
				for (int x = number17; x <= number18; x++)
				{
					sum2 += x;
				}
				Console.WriteLine(sum2);

				Console.WriteLine("\nWould you like to continue (y/n)?");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go12 = false;
				}
			}*/

			//Exercise 20
			bool go13 = true;
			while (go13)
			{
				Console.WriteLine("Enter a number. =>");
				int number19 = int.Parse(Console.ReadLine());
				int product = 1;
				for (int x = number19; x >= (number19 - 2); x--)
				{
					product *= x;
				}
				Console.WriteLine($"The product of {number19}, {number19 - 1}, and {number19 - 2} is {product}");

				Console.WriteLine("\nWould you like to continue (y/n)?");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go13 = false;
				}
			}
		}
	}
}
