using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_5._2
{
	class Validator
	{
		public string YesOrNo()
		{
			//Gets the users input.
			string yesOrNo = Console.ReadLine().ToLower();
			//Loops until they say yes or no.
			while (!(yesOrNo == "yes" || yesOrNo == "y" || yesOrNo == "no" || yesOrNo == "n"))
			{
				Console.Write("Invalid input.  Continue? (y/n): ");
				yesOrNo = Console.ReadLine().ToLower();
			}
			//Returns yes or no.
			return yesOrNo;
		}

		public int PickOpponent(List<Player> players)
		{
			//Gets input for opponent choice.
			string input = Console.ReadLine().ToLower();
			//Checks if user entered a number.
			bool isValid = int.TryParse(input, out int playerChoice);
			//Checks if user entered a name.
			int index = -1;
			//Loops through player names comparing lower case version to the users input.
			foreach (Player player in players)
			{
				if (player.Name.ToLower() == input)
				{
					index = players.IndexOf(player);
					break;
				}
			}
			bool playerFound = (index != -1);
			//If input is not an int or an int within range, and is not a match for one of the player names, loops until it is.
			while ((!isValid || !(playerChoice > 0 && playerChoice <= players.Count)) && !playerFound)
			{
				Console.Write("That is not a valid option.  Try again. ");
				input = Console.ReadLine().ToLower();
				isValid = int.TryParse(input, out playerChoice);
				foreach (Player player in players)
				{
					if (player.Name.ToLower() == input)
					{
						index = players.IndexOf(player);
						break;
					}
				}
				playerFound = (index != -1);
			}
			//If found by entereing opponents name, returns index of player.
			if (index != -1)
			{
				return index;
			}
			//Else returns zero based value for player number selected.
			else
			{
				return playerChoice - 1;
			}
		}

		public RPS GetRoshamboInput()
		{
			string input = Console.ReadLine().ToLower();
			//Sets bool value to true if input matches one of the below options.  Otherwise sets to false.
			bool isValid = ((input == "1" || input == "rock" || input == "r") || (input == "2" || input == "paper" || input == "p") || (input == "3" || input == "scissors" || input == "s"));
			//Loops through until one of the valid options is picked.
			while (!isValid)
			{
				Console.Write("That is not a valid choice.  Try again. ");
				input = Console.ReadLine().ToLower();
				isValid = ((input == "1" || input == "rock" || input == "r") || (input == "2" || input == "paper" || input == "p") || (input == "3" || input == "scissors" || input == "s"));
			}
			//Assigns an interger value to the users input.
			int choice;
			if (input == "1" || input == "rock" || input == "r")
			{
				choice = 0;
			}
			else if (input == "2" || input == "paper" || input == "p")
			{
				choice = 1;
			}
			else
			{
				choice = 2;
			}
			//Integer value is then casted as a RPS value and returned.
			return (RPS)choice;
		}
	}
}
