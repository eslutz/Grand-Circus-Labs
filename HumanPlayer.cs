using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._2
{
	class HumanPlayer : Player
	{
		public HumanPlayer(string name) : base()
		{
			base.Name = name;
		}

		public override RPS GenerateRoshambo()
		{
			Console.Write("Rock, paper, or scissors? ");
			string input = Console.ReadLine().ToLower();
			bool isValid = ((input == "1" || input == "rock" || input == "r") || (input == "2" || input == "paper" || input == "p") || (input == "3" || input == "scissors" || input == "s"));
			while (!isValid)
			{
				Console.Write("That is not a valid choice.  Try again. ");
				input = Console.ReadLine().ToLower();
			}
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
			base.Roshambo = (RPS)choice;
			return (RPS)choice;
		}
	}
}