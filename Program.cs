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
			players.Add(new Wizard("Gandlf", 50, 80, 90, 8));
			players.Add(new Wizard("Blake Henderson", 5, 100, 100, 100));
			players.Add(new Wizard("Anders Holmvik", 15, 80, 90, 90));
			players.Add(new Wizard("Adam DeMamp", 20, 60, 85, 70));

			return players;
		}
	}
}
