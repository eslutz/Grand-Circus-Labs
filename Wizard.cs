using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._1
{
	class Wizard : MagicUsingCharacter
	{
		private int _spellNumber;

		public int SpellNumber
		{
			get { return _spellNumber; }
			set { _spellNumber = value; }
		}

		public Wizard(string name, int strength, int intellegence, int magicalEnergy, int spellNumber) : base(name, strength, intellegence, magicalEnergy)
		{
			SpellNumber = spellNumber;
		}

		public override void Play()
		{
			Console.WriteLine($"{Name} with some mighty magic has the strength of {Strength}, the intelligence of {Intellegence}, and {MagicalEnergy} magical energy with {SpellNumber} spells!");
		}
	}
}