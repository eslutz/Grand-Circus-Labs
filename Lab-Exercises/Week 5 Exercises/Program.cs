using System;

namespace Week_5_Exercises
{
	class Program
	{
		static void Main(string[] args)
		{
			//Exercise 64
			bool go = true;
			do
			{
				Validator valid = new Validator();
				Console.Write("Enter a number: ");
				string input = Console.ReadLine();
				if (valid.IsInt(input))
				{
					Console.WriteLine($"{input} can be parsed as an integer.");
				}
				else
				{
					Console.WriteLine($"{input} cannot be parsed as an integer.");
				}

				Console.Write("Would you like to continue (y/n)? ");
				input = Console.ReadLine();
				if (input == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 65
			go = true;
			do
			{
				Validator valid = new Validator();
				Console.Write("Enter a number: ");
				string input = Console.ReadLine();
				if (valid.IsInt(input, 3, 12))
				{
					Console.WriteLine($"{input} can be parsed as an integer between 3 and 12.");
				}
				else
				{
					Console.WriteLine($"{input} cannot be parsed as an integer between 3 and 12.");
				}

				Console.Write("Would you like to continue (y/n)? ");
				input = Console.ReadLine();
				if (input == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 66
			go = true;
			do
			{
				Validator valid = new Validator();
				Console.Write("Enter a number: ");
				int num = int.Parse(Console.ReadLine());
				Console.WriteLine($"The sqaure root of {num} is {valid.SquareRoot(num)}.");

				Console.Write("Would you like to continue (y/n)? ");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go = false;
				}
			} while (go);
		}
	}
}