using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._2
{
	//Enum for the different moves of Roshambo.
	enum RPS
	{
		rock,
		paper,
		scissors
	}

	//Enum for the outcome options of a game.
	enum Outcome
	{
		win,
		lose,
		draw
	}

	abstract class Player
	{
		//Declare the properties for the class.  Protected set so only child classes can modify the values.
		public string Name { get; protected set; }
		public RPS Roshambo { get; protected set; }
		public int Wins { get; protected set; }
		public int Losses { get; protected set; }
		public int Draw { get; protected set; }

		//Empty default contrstuctor;
		public Player()
		{

		}

		public abstract RPS GenerateRoshambo();
	}
}