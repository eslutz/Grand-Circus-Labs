using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._2
{
	class NPC2 : Player
	{
		//Random object for the class.
		private Random rand = new Random();

		//Constructor updates the name for the random player.
		public NPC2() : base()
		{
			base.Name = "RandomMove";
		}

		//Gets random number to cast as players roshambo move.  Updates the Roshambo value.
		public override RPS GenerateRoshambo()
		{
			//Generates a random number between 1 and the total number of values in the enum and then casts that number as a RPS value.
			RPS randomMove = (RPS)rand.Next(Enum.GetValues(typeof(RPS)).Length);
			base.Roshambo = randomMove;
			return randomMove;
		}
	}
}