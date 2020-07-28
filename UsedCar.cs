using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._3
{
	class UsedCar : Car
	{
		//Private set for field so it cannot be accessed outside the class.
		private double _mileage;

		//Private set for property so the value cannot be changed outside of the class.
		public double Mileage
		{
			get { return _mileage; }
			private set { _mileage = value; }
		}

		//Default constructor.
		public UsedCar() : base ()
		{
			Mileage = 0;
		}

		//Constructor taking in arguments for all values.
		public UsedCar(string make, string model, int year, decimal cost, double mileage) : base(make, model, year, cost)
		{
			Mileage = mileage;
		}

		//Override ToString() do display info about the car.
		public override string ToString()
		{
			return $"{base.ToString()}{"(Used)",8}{Mileage.ToString("N")+" miles",18}";
		}
	}
}