using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._2
{
	class NPC1 : Player
	{
		//Constructor updates the name for the rock only player.
		public NPC1() : base()
		{
			base.Name = "DumbDumb";
		}

		//Updates players Roshambo value and always returns rock.
		public override RPS GenerateRoshambo()
		{
			base.Roshambo = RPS.rock;
			return RPS.rock;
		}
	}
}