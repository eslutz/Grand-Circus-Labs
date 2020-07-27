using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._1
{
	class Warrior : GameCharacter
	{
		private string _weaponType;

		public string WeaponType
		{
			get { return _weaponType; }
			set { _weaponType = value; }
		}

		public Warrior(string name, int strength, int intellegence, string weaponType) : base(name, strength, intellegence)
		{
			WeaponType = weaponType;
		}

		public override void Play()
		{
			Console.WriteLine($"{Name} with her/his mighty {WeaponType} has the strength of {Strength} and the intelligence of {Intellegence}!");
		}
	}
}