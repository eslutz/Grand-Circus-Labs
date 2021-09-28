using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._1
{
	class GameCharacter
	{
		private string _name;
		private int _strength;
		private int _intellegence;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public int Strength
		{
			get { return _strength; }
			set { _strength = value; }
		}

		public int Intellegence
		{
			get { return _intellegence; }
			set { _intellegence = value; }
		}

		public GameCharacter(string name, int strength, int intelligence)
		{
			Name = name;
			Strength = strength;
			Intellegence = intelligence;
		}

		public virtual void Play()
		{
			Console.WriteLine($"{Name} has the strength of {Strength} and the intelligence of {Intellegence}!");
		}
	}
}