using System;

namespace Week_3_Exercises
{
	class Program
	{
		static void Main(string[] args)
		{
			//Exercise 31
			bool go = true;
			do
			{
				int[] array = { 2, 8, 0, 24, 51 };
				Console.Write("Enter an index of the array => ");
				int index = int.Parse(Console.ReadLine());
				if (index >= array.Length)
				{
					Console.WriteLine("That number is too big.  Try again!");
					continue;
				}
				else
				{
					Console.WriteLine($"The value of the index at {index} is {array[index]}.");
				}
				
				Console.Write("Would you like to continue (y/n)? ");
				string input = Console.ReadLine();
				if (input == "n")
				{
					go = false;
				}
			} while (go);

			//Exercise 32
			go = true;
			do
			{
				int[] array = { 2, 8, 0, 24, 51 };
				Console.Write("Enter a number => ");
				int input = int.Parse(Console.ReadLine());
				if (Array.IndexOf(array, input) != -1)
				{
					Console.WriteLine($"The value {input} can be found at {Array.IndexOf(array, input)}");
					continue;
				}
				else
				{
					Console.WriteLine($"The value {input} cannot be found.");
				}

				Console.Write("Would you like to continue (y/n)? ");
				string inputCont = Console.ReadLine();
				if (inputCont == "n")
				{
					go = false;
				}
			} while (go);
		}
	}
}
