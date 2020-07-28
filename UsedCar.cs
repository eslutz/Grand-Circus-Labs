using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._3
{
	class UsedCar : Car
	{
		private double _mileage;

		public double Mileage
		{
			get { return _mileage; }
			private set { _mileage = value; }
		}

		public UsedCar() : base ()
		{
			Mileage = 0;
		}

		public UsedCar(string make, string model, int year, decimal cost, double mileage) : base(make, model, year, cost)
		{
			Mileage = mileage;
		}

		public override string ToString()
		{
			return $"{base.ToString()}{"(Used)",8}{Mileage.ToString("N")+" miles",18}";
		}
	}
}