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
			protected set { _make = value; }
		}

		public string Model
		{
			get { return _model; }
			protected set { _model = value; }
		}

		public int Year
		{
			get { return _year; }
			protected set { _year = value; }
		}

		public decimal Price
		{
			get { return _price; }
			protected set { _price = value; }
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

		//Method to edit a car.
		public virtual void EditCar()
		{
			Console.Write("What would you like to change (make/model/year/price)? ");
			string input = Console.ReadLine().ToLower();
			while (!(input == "make" || input == "model" || input == "year" || input == "price" || input == "used"))
			{
				Console.Write("Invalid input. What would you like to change (make/model/year/price)? ");
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
			}
		}
	}
}