using System;

namespace Lab_4._1
{
	class Program
	{
		static void Main(string[] args)
		{
			bool keepRolling = true;
			int rollCount = 1;
			Console.WriteLine("Welcome to the Grand Circus Casino!");
			//Gets input from the user and validates it for many sides they want the dice to have.
			Console.Write("How many sides should each dice have? => ");
			bool isValid = int.TryParse(Console.ReadLine(), out int diceSides);
			while (!isValid)
			{
				Console.Write("Sorry, that is not a valid option.  Please choose a positive integer. => ");
				isValid = int.TryParse(Console.ReadLine(), out diceSides);
			}

			while (keepRolling)
			{
				//Declare an array and calls the DiceRoll method to get the values from the dice roll.
				int[] diceValues = DiceRoll(diceSides);
				Console.WriteLine($"\nRoll {rollCount}:");
				Console.WriteLine($"You rolled a {diceValues[0]} and a {diceValues[1]} for a total of {diceValues[0] + diceValues[1]}.");

				//Determines if the user wants to roll again.  If not, quits the program.
				Console.Write("\nKeep rolling? (y/n) => ");
				string yesOrNo = Console.ReadLine().ToLower();
				while(!(yesOrNo == "yes" || yesOrNo == "y" || yesOrNo == "no" || yesOrNo == "n"))
				{
					Console.Write("Invalid input.  Please enter \"yes\" or \"no\". => ");
					yesOrNo = Console.ReadLine().ToLower();
				}
				if(yesOrNo == "yes" || yesOrNo == "y")
				{
					rollCount++;
				}
				else
				{
					keepRolling = false;
					Console.WriteLine("Thanks for playing!!");
				}

			}
		}

		//Takes in the number of sides on the dice, generates a random value for that dice, and returns the values.
		static int[] DiceRoll(int sides)
		{
			Random roll = new Random();
			int[] rollValues = new int[2];

			//Using the Random Class to generate values for the dice between 1 and n.
			rollValues[0] = roll.Next(1, sides + 1);
			rollValues[1] = roll.Next(1, sides + 1);

			return rollValues;
		}


	}
}
