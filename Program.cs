using System;

namespace Lab_5._3
{
	class Program
	{
		static void Main(string[] args)
		{
			CarLot lot = GetCars();
			ShowOptions(lot);
		}

		static CarLot GetCars()
		{
			CarLot lot = new CarLot();

			lot.AddCar(new Car("Jeep", "Liberty", 2011, 10000));
			lot.AddCar(new Car("Dodge", "Dart", 2016, 5000));
			lot.AddCar(new UsedCar("Jeep", "Commander", 2019, 20000, 50000));
			lot.AddCar(new Car("Dodge", "Durango", 2015, 3000));
			lot.AddCar(new Car("Chevy", "Tahoe", 2016, 15000));
			lot.AddCar(new UsedCar("Lincoln", "Navigator", 2018, 15000, 30000));
			lot.AddCar(new Car("Subaru", "Ascent", 2020, 45000));
			lot.AddCar(new UsedCar("Cadillac", "Deville", 1988, 10000, 80000));
			lot.AddCar(new UsedCar("Chrysler", "Cordoba", 1983, 10000, 90000));

			return lot;
		}

		static void ShowOptions(CarLot lot)
		{
			Console.WriteLine("Welcome to the Grand Circus Used Car Emporium!");

			bool keepGoing = true;
			do
			{
				Console.WriteLine();
				lot.DisplayCars();
				Console.WriteLine($"{lot.LotCount() + 1 + ".",-4}{"Add A Car"}");
				Console.WriteLine($"{lot.LotCount() + 2 + ".",-4}{"Quit"}");

				Console.Write($"\nWhich car would you like? ");
				bool isValid = int.TryParse(Console.ReadLine(), out int option);
				while (!isValid || !(option > 0 && option <= (lot.LotCount() + 2)))
				{
					Console.Write($"Sorry, that is not a valid option.  Please select 1 - {lot.LotCount() + 2}. ");
					isValid = int.TryParse(Console.ReadLine(), out option);
				}

				
				if (option == (lot.LotCount() + 2))
				{
					keepGoing = false;
					Console.WriteLine("Thanks for shopping with us.  Have a great day!");
				} 
				else if(option == (lot.LotCount() + 1))
				{
					AddACar(lot);
				}
				else
				{
					BuyCar(lot, option - 1);
				}
			} while (keepGoing);
		}

		static void AddACar(CarLot lot)
		{
			double milage;
			decimal price;
			int year;
			string make, model;
			Console.WriteLine();
			Console.WriteLine("Please provide the following details for the car you would like to add.");
			Console.Write("Car make: ");
			make = Console.ReadLine();
			Console.Write("Car model: ");
			model = Console.ReadLine();
			Console.Write("Car year: ");
			bool isValid = int.TryParse(Console.ReadLine(), out year);
			while (!isValid || !(year >= 1886))
			{
				Console.Write($"Sorry, please enter a year after the car was invented (1886). ");
				isValid = int.TryParse(Console.ReadLine(), out year);
			}
			Console.Write("Car price: ");
			isValid = decimal.TryParse(Console.ReadLine(), out price);
			while (!isValid || !(price >= 0))
			{
				Console.Write($"Sorry, please enter non-negitive value. ");
				isValid = decimal.TryParse(Console.ReadLine(), out price);
			}
			Console.Write("Is the car used? (y/n) ");
			string input = Console.ReadLine().ToLower();
			while (!(input == "y" || input == "yes" || input == "n" || input == "no"))
			{
				Console.Write($"Sorry, please enter \"yes\" or \"no\". ");
				input = Console.ReadLine().ToLower();
			}
			if(input == "y" || input == "yes")
			{
				Console.Write("Car milage: ");
				isValid = double.TryParse(Console.ReadLine(), out milage);
				while (!isValid || !(milage >= 0))
				{
					Console.Write($"Sorry, please enter non-negitive value. ");
					isValid = double.TryParse(Console.ReadLine(), out milage);
				}
				lot.AddCar(new UsedCar(make, model, year, price, milage));
				Console.WriteLine("Thank you.  A used car has been added.");
			}
			else
			{
				lot.AddCar(new Car(make, model, year, price));
				Console.WriteLine("Thank you.  A new car has been added.");
			}
		}

		static void BuyCar(CarLot lot, int index)
		{
			Console.WriteLine(lot.ViewCar(index));
			Console.Write("Is this the car you would like to buy? (y/n) ");
			string input = Console.ReadLine().ToLower();
			while (!(input == "y" || input == "yes" || input == "n" || input == "no"))
			{
				Console.Write($"Sorry, please enter \"yes\" or \"no\". ");
				input = Console.ReadLine().ToLower();
			}
			if (input == "y" || input == "yes")
			{
				lot.RemoveCar(index);
				Console.WriteLine("Excellent choice! Our finance department will be with you shortly.");
			}
			else
			{
				Console.WriteLine("No problem!  Lets take another look at what we have to offer.");
			}
		}
	}
}