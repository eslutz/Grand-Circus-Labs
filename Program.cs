using System;
using System.Runtime.CompilerServices;

namespace Lab_2._2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Learn your squares and cubes!");

			//loops until the user is ready to quit
			bool keepRunning = true;
			while (keepRunning)
			{
				//asks ang gets an integer from the user
				int number;
				Console.WriteLine("\nEnter an integer:");
				number = int.Parse(Console.ReadLine());

				
				//checks to make sure the entered number is greater than zero, but less than maximum cubed number
				const int MAX_CUBED_VALUE = 1290;
				while(number <= 0 || number > MAX_CUBED_VALUE)
				{
					//determines if the number is less than or equal to zero and asks for a larger number
					if (number <= 0)
					{
						Console.WriteLine($"\nThe number cannot be 0 or smaller.  Please enter a larger number.");
						number = int.Parse(Console.ReadLine());
					}
					//determines if input will result in an out of range cube and asks for a smaller number
					else if (number > MAX_CUBED_VALUE)
					{
						Console.WriteLine($"\nThis number cannot be cubed.  Please enter a number smaller than {MAX_CUBED_VALUE}.");
						number = int.Parse(Console.ReadLine());
					}
				}

				//computes and prints out square and cube up to and including the entered number
				Console.WriteLine(String.Format("\n{0,-10}\t{1,-10}\t{2,-10}", "Number", "Squared", "Cubed"));
				Console.WriteLine(String.Format("{0,-10}\t{1,-10}\t{2,-10}", "==========", "==========", "=========="));
				//loops through 1 to the entered number
				for(int x=1; x<=number; x++)
				{
					//computes the sqaure and cube of the current value of x
					int squared = x * x;
					int cubed = x * x * x;
					Console.WriteLine(String.Format("{0,10}\t{1,10}\t{2,10}", x, squared, cubed));

				}

				//determines is the user wants to keep going or quit
				Console.WriteLine("\nContinue? (y/n):");
				string keepGoing = Console.ReadLine();
				if(keepGoing == "n" || keepGoing == "N")
				{
					keepRunning = false;
				}
				else if(keepGoing != "y" && keepGoing != "Y")
				{
					Console.WriteLine("Invalid input. Defaulting to no.");
					keepRunning = false;
				}
			}
		}
	}
}
