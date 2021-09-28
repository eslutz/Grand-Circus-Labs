using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._2
{
	class HumanPlayer : Player
	{
		//Human player constructor changes the default name to whatever the user entered.
		public HumanPlayer(string name) : base()
		{
			base.Name = name;
		}

		//Gets the users input for their move and updates the Roshambo field.
		public override RPS GenerateRoshambo()
		{
			Console.Write("Rock, paper, or scissors? ");
			RPS choice = Validator.GetRoshamboInput();
			base.Roshambo = choice;
			return choice;
		}

		//Increments values of the humans players wins, losses, and draws.
		public void WinOrLose(Outcome x)
		{
			if(x == Outcome.win)
			{
				base.Wins++;
			}
			if(x == Outcome.lose)
			{
				base.Losses++;
			}
			if(x == Outcome.draw)
			{
				base.Draw++;
			}
		}
	}
}