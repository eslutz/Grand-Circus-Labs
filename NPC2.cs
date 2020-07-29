using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._2
{
	class NPC2 : Player
	{
		private Random rand = new Random();

		public NPC2() : base("RandomMove")
		{

		}

		public override RPS GenerateRoshambo()
		{
			//Generates a random number between 1 and the total number of values in the enum and then casts that number as a RPS value.
			RPS randomMove = (RPS)rand.Next(Enum.GetValues(typeof(RPS)).Length);
			base.ChangeRoshambo(randomMove);
			return randomMove;
		}
	}
}