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
			return $"{base.ToString()}{"(Used)",10}{Mileage.ToString("N")+" miles",18}";
		}

		//Method to edit a used car.
		public override void EditCar()
		{
			Console.Write("What would you like to change (make/model/year/price/milage)? ");
			string input = Console.ReadLine().ToLower();
			while (!(input == "make" || input == "model" || input == "year" || input == "price" || input == "used" || input == "milage"))
			{
				Console.Write("Invalid input. What would you like to change (make/model/year/price/milage)? ");
				input = Console.ReadLine().ToLower();
			}
			switch (input)
			{
				case "make":
					Console.Write("Enter a new make: ");
					input = Console.ReadLine();
					Make = input;
					break;
				case "model":
					Console.Write("Enter a new model: ");
					input = Console.ReadLine();
					Model = input;
					break;
				case "year":
					Console.Write("Enter a new year: ");
					bool isValid = int.TryParse(Console.ReadLine(), out int year);
					while (!isValid || !(year >= 1886))
					{
						Console.Write($"Sorry, please enter a year after the car was invented (1886). ");
						isValid = int.TryParse(Console.ReadLine(), out year);
					}
					Year = year;
					break;
				case "price":
					Console.Write("Enter a new price: ");
					isValid = decimal.TryParse(Console.ReadLine(), out decimal price);
					while (!isValid || !(price >= 0))
					{
						Console.Write($"Sorry, please enter non-negitive value. ");
						isValid = decimal.TryParse(Console.ReadLine(), out price);
					}
					Price = price;
					break;
				case "milage":
					Console.Write("Enter a new milage: ");
					isValid = double.TryParse(Console.ReadLine(), out double milage);
					while (!isValid || !(milage >= 0))
					{
						Console.Write($"Sorry, please enter non-negitive value. ");
						isValid = double.TryParse(Console.ReadLine(), out milage);
					}
					Mileage = milage;
					break;
			}
		}
	}
}