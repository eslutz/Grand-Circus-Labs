using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._2
{
	enum RPS
	{
		rock,
		paper,
		scissors
	}

	abstract class Player
	{
		public string Name { get; private set; }
		public RPS Roshambo { get; private set; }

		public Player()
		{
			Name = "test";
			Roshambo = GenerateRoshambo();
		}
		public Player(string name)
		{
			Name = name;
		}

		public abstract RPS GenerateRoshambo();

		protected void ChangeRoshambo(RPS newRPS)
		{
			Roshambo = newRPS;
		}
	}
}