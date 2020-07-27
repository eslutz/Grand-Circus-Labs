using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._1
{
	class Wizzard : MagicUsingCharacter
	{
		private int _spellNumber;

		public int SpellNumber
		{
			get { return _spellNumber; }
			set { _spellNumber = value; }
		}

		public Wizzard(string name, int strength, int intellegence, int magicalEnergy, int spellNumber) : base(name, strength, intellegence, magicalEnergy)
		{
			SpellNumber = spellNumber;
		}

		public override void Play()
		{
			Console.WriteLine($"{Name} with her/his mighty magic has the strength of {Strength}, the intelligence of {Intellegence} with {MagicalEnergy} magical energy and {SpellNumber} spells!");
		}
	}
}