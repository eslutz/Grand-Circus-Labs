using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._2
{
	class NPC1 : Player
	{
		public NPC1() : base("DumbDumb")
		{

		}

		public override RPS GenerateRoshambo()
		{
			//base.ChangeRoshambo(RPS.rock);
			return RPS.rock;
		}
	}
}