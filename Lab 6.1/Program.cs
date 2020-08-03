using System;

namespace Lab_6._1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Grand Circus nth Prime Calculator!!! ");

			Console.WriteLine("\nThis application will find you any prime, in order, from the first prime number (2) on.\n");

			//Loops until the user quits.
			string yesOrNo;
			do
			{
				//Gets user input and validates it.
				Console.Write("Which prime number are you looking for? ");
				bool isValid = int.TryParse(Console.ReadLine(), out int userChoice);
				while (!isValid && !(userChoice > 0))
				{
					Console.Write("Please enter an integer greater than 0. ");
					isValid = int.TryParse(Console.ReadLine(), out userChoice);
				}

				//Displays users choice and the prime number they're looking for.
				Console.WriteLine($"\nThe number {userChoice} prime is {Prime_Numbers.GetPrime(userChoice)}.");

				Console.Write("\nDo you want to find another prime number? (y/n): ");
				yesOrNo = Console.ReadLine().ToLower();
				while (!(yesOrNo == "yes" || yesOrNo == "y" || yesOrNo == "no" || yesOrNo == "n"))
				{
					Console.Write("Invalid input.  Continue? (y/n): ");
					yesOrNo = Console.ReadLine().ToLower();
				}
				Console.Clear();
			} while (yesOrNo == "yes" || yesOrNo == "y");

			Console.WriteLine("Let's end with a joke!  Why is two the oddest prime number?");
			Console.WriteLine("It's the only one that's even!");
			Console.WriteLine("\nThanks for finding some primes!");
		}
	}
}