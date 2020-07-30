using System;
using System.Collections.Generic;

namespace Lab_5._2
{
	class Program
	{
		static void Main(string[] args)
		{
			//Declared a list for storing the opponents and called the method to fill it.
			List<Player> players = GetPlayerOptions();
			Console.WriteLine("Welcome to the Grand Circus Rock Paper Scissors World Chamionship!");
			
			//Gets the users name and creates a human player with their name.
			Console.Write("\nEnter your name: ");
			string userName = Console.ReadLine();
			HumanPlayer me = new HumanPlayer(userName);

			//Displays available opponents to play against and gets the users validated input.
			Console.WriteLine();
			for (int index = 0; index < players.Count; index++)
			{
				Console.WriteLine($"{index + 1}. {players[index].Name}");
			}
			Console.Write("Choose a player you would like to compete against. ");
			int playerChoice = Validator.PickOpponent(players);
			
			//Loops through until the user is done playing against their chosen opponent.
			Console.WriteLine();
			while (true)
			{
				//Gets the users move.
				me.GenerateRoshambo();
				//Gets the opponents move.
				players[playerChoice].GenerateRoshambo();

				//Displays the picked moves for both players.
				Console.WriteLine($"\n{me.Name}: {me.Roshambo}");
				Console.WriteLine($"{players[playerChoice].Name}: {players[playerChoice].Roshambo}");
				
				//Determines and outputs the winner and calls the method to tally the users wins and losses.
				me.WinOrLose(GetWinner(me, players[playerChoice]));
				//Displays the users wins and losses.
				Console.WriteLine($"That makes it {me.Wins} win(s), {me.Losses} losse(s), and {me.Draw} draw(s) for you!");

				//Asks if the user wants to play again and gets validated input.
				Console.Write("\nPlay again? (y/n): ");
				string answer = Validator.YesOrNo();
				Console.Clear();
				if(answer == "no" || answer == "n")
				{
					break;
				}
			}
			//Displays a parting message to the user.
			Console.WriteLine("Thanks for playing!");
			Console.WriteLine($"As a reminded {me.Name}, you lost {me.Losses} time(s) to {players[playerChoice].Name}!");
		}

		//Method returns a list filled with players to compete against.
		static List<Player> GetPlayerOptions()
		{
			List<Player> players = new List<Player>();
			players.Add(new NPC1());
			players.Add(new NPC2());
			return players;
		}

		//Method determines the winner of the match and returns the outcome.
		static Outcome GetWinner(Player p1, Player p2)
		{
			Outcome result = Outcome.draw;
			if ((p1.Roshambo == RPS.rock && p2.Roshambo == RPS.rock) || (p1.Roshambo == RPS.paper && p2.Roshambo == RPS.paper) || (p1.Roshambo == RPS.scissors && p2.Roshambo == RPS.scissors))
			{
				Console.WriteLine("Draw!");
				result = Outcome.draw;
			}
			if ((p1.Roshambo == RPS.rock && p2.Roshambo == RPS.paper) || (p1.Roshambo == RPS.paper && p2.Roshambo == RPS.scissors) || (p1.Roshambo == RPS.scissors && p2.Roshambo == RPS.rock))
			{
				Console.WriteLine($"{p2.Name} wins!");
				result = Outcome.lose;
			}
			if ((p1.Roshambo == RPS.rock && p2.Roshambo == RPS.scissors) || (p1.Roshambo == RPS.paper && p2.Roshambo == RPS.rock) || (p1.Roshambo == RPS.scissors && p2.Roshambo == RPS.paper))
			{
				Console.WriteLine($"{p1.Name} wins!");
				result = Outcome.win;
			}
			return result;
		}
	}
}