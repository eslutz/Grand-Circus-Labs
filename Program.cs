using System;
using System.Collections.Generic;

namespace Lab_5._2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Player> players = GetPlayerOptions();
			Console.WriteLine("Welcome to the Grand Circus Rock Paper Scissors World Chamionship!");
			Console.WriteLine();
			Console.Write("Enter your name: ");
			string userName = Console.ReadLine();
			HumanPlayer me = new HumanPlayer(userName);
			Console.WriteLine();
			for (int index = 0; index < players.Count; index++)
			{
				Console.WriteLine($"{index + 1}. {players[index].Name}");
			}
			Console.Write("Choose a number for the player you would like to play against. ");
			bool isValid = int.TryParse(Console.ReadLine(), out int playerChoice);
			while (!isValid || !(playerChoice > 0 && playerChoice <= players.Count))
			{
				Console.Write("That is not a valid choice.  Try again. ");
				isValid = int.TryParse(Console.ReadLine(), out playerChoice);
			}
			playerChoice--;
			Console.WriteLine();
			while (true)
			{
				me.GenerateRoshambo();
				players[playerChoice].GenerateRoshambo();
				Console.WriteLine();
				Console.WriteLine($"{me.Name}: {me.Roshambo}");
				Console.WriteLine($"{players[playerChoice].Name}: {players[playerChoice].Roshambo}");
				Console.WriteLine();
				me.WinOrLose(GetWinner(me, players[playerChoice]));
				Console.WriteLine($"That makes it {me.Wins} win(s), {me.Losses} losse(s), and {me.Draw} draw(s) for you!");
				Console.WriteLine();

				Console.Write("Play again? (y/n): ");
				string yesOrNo = Console.ReadLine().ToLower();
				while (!(yesOrNo == "yes" || yesOrNo == "y" || yesOrNo == "no" || yesOrNo == "n"))
				{
					Console.Write("Invalid input.  Continue? (y/n): ");
					yesOrNo = Console.ReadLine().ToLower();
				}
				Console.Clear();
				if(yesOrNo == "no" || yesOrNo == "n")
				{
					break;
				}
			}
			Console.WriteLine("Thanks for playing!");
			Console.WriteLine($"As a reminded {me.Name}, you lost {me.Losses} time(s) to {players[playerChoice].Name}!");
		}

		static List<Player> GetPlayerOptions()
		{
			List<Player> players = new List<Player>();
			players.Add(new NPC1());
			players.Add(new NPC2());
			return players;
		}

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