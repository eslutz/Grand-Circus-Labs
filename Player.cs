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

	enum Outcome
	{
		win,
		lose,
		draw
	}

	abstract class Player
	{
		public string Name { get; protected set; }
		public RPS Roshambo { get; protected set; }
		public int Wins { get; protected set; }
		public int Losses { get; protected set; }
		public int Draw { get; protected set; }

		public Player()
		{
			Name = "test";
		}

		public abstract RPS GenerateRoshambo();
	}
}