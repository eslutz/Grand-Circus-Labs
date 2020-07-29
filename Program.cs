using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Lab_5._2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Player> players = GetPlayerOptions();
			Console.WriteLine("Welcome to the Grand Circus Rock Paper Scissors World Chamionship!");
			Console.Write("Enter your name: ");
			string userName = Console.ReadLine();
			
			for (int index = 0; index < players.Count; index++)
			{
				Console.WriteLine($"{index+1}. {players[index].Name}");
			}
			Console.Write("Choose a number for the player you would like to play against. ");
			bool isValid = int.TryParse(Console.ReadLine(), out int playerChoice);
			while(!isValid || !(playerChoice > 0 && playerChoice <= players.Count))
			{
				Console.Write("That is not a valid choice.  Try again. ");
				isValid = int.TryParse(Console.ReadLine(), out playerChoice);
			}
			HumanPlayer me = new HumanPlayer(userName);
			playerChoice--;
			me.GenerateRoshambo();
			Console.WriteLine($"{me.Name}: {me.Roshambo}");
			Console.WriteLine($"{players[playerChoice].Name}: {players[playerChoice].Roshambo}");
			GetWinner();
		}

		static List<Player> GetPlayerOptions()
		{
			List<Player> players = new List<Player>();
			players.Add(new NPC1());
			players.Add(new NPC2());
			return players;
		}

		static void GetWinner()
		{
			if()
		}
	}
}