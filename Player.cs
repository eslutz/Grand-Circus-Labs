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
		public string Name { get; protected set; }
		public RPS Roshambo { get; protected set; }

		public Player()
		{
			Name = "test";
			Roshambo = GenerateRoshambo();
		}

		public abstract RPS GenerateRoshambo();
	}
}