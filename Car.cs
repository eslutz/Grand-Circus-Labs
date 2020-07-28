using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._3
{
	class Car
	{
		//Private set for fields so they cannot be accessed outside the class.
		private string _make;
		private string _model;
		private int _year;
		private decimal _price;

		//Private set for all properties so the values cannot be changed outside of the class.
		public string Make
		{
			get { return _make; }
			private set { _make = value; }
		}

		public string Model
		{
			get { return _model; }
			private set { _model = value; }
		}

		public int Year
		{
			get { return _year; }
			private set { _year = value; }
		}

		public decimal Price
		{
			get { return _price; }
			private set { _price = value; }
		}

		//Default constructor.
		public Car()
		{
			Make = "unknown";
			Model = "unknown";
			Year = 9999;
			Price = 0m;
		}
		
		//Constructor taking in arguments for all values.
		public Car(string make, string model, int year, decimal cost)
		{
			Make = make;
			Model = model;
			Year = year;
			Price = cost;
		}

		//Override ToString() do display info about the car.
		public override string ToString()
		{
			return $"{Make,-14}{Model,-14}{Year,-4}{Price,14:C}";
		}
	}
}