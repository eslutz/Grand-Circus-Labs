using System;
using System.Collections.Generic;

namespace Lab_5._1
{
	class Program
	{
		static void Main(string[] args)
		{
			List<GameCharacter> players = GetPlayers();
			Console.WriteLine("Welcome to the World of Dev.Buildcraft!\n");

			foreach(GameCharacter player in players)
			{
				player.Play();
			}
		}

		public static List<GameCharacter> GetPlayers()
		{
			List<GameCharacter> players = new List<GameCharacter>();
			players.Add(new Warrior("Boromir", 50, 3, "sword"));
			players.Add(new Warrior("Gimli", 80, 20, "axe"));
			players.Add(new Warrior("Legolas", 40, 30, "bow"));
			players.Add(new Wizzard("Gandlf", 50, 80, 90, 8));
			players.Add(new Wizzard("Dumbledore", 20, 90, 75, 33));

			return players;
		}
	}
}
