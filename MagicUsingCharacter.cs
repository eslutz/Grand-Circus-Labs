using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._1
{
	class MagicUsingCharacter : GameCharacter
	{
		private int __magicalEnergy;

		public int MagicalEnergy
		{
			get { return __magicalEnergy; }
			set { __magicalEnergy = value; }
		}

		public MagicUsingCharacter(string name, int strength, int intellegence, int magicalEnergy) : base(name, strength, intellegence)
		{
			MagicalEnergy = magicalEnergy;
		}

		public override void Play()
		{
			Console.WriteLine($"{Name} with her/his mighty magic has the strength of {Strength}, the intelligence of {Intellegence} with {MagicalEnergy} magical energy!");
		}
	}
}