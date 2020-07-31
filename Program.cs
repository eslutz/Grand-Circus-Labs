using Microsoft.VisualBasic.FileIO;
using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace Lab_5._3
{
	class Program
	{
		static void Main(string[] args)
		{
			CarLot lot = GetCars();
			ShowOptions(lot);
		}

		//Creates a list of new and used cars and adds them to a car lot that is returned.
		static CarLot GetCars()
		{
			CarLot lot = new CarLot();

			lot.AddCar(new Car("Jeep", "Liberty", 2011, 10000m));
			lot.AddCar(new Car("Dodge", "Dart", 2016, 5000m));
			lot.AddCar(new UsedCar("Jeep", "Commander", 2019, 20000m, 50000));
			lot.AddCar(new Car("Dodge", "Durango", 2015, 3000m));
			lot.AddCar(new Car("Chevy", "Tahoe", 2016, 15000m));
			lot.AddCar(new UsedCar("Lincoln", "Navigator", 2018, 15000m, 30000));
			lot.AddCar(new Car("Subaru", "Ascent", 2020, 45000m));
			lot.AddCar(new UsedCar("Cadillac", "Deville", 1988, 10000m, 80000));
			lot.AddCar(new UsedCar("Chrysler", "Cordoba", 1983, 10000m, 90000));

			return lot;
		}

		//Displays all available cars and asks the user what they would like to do.
		static void ShowOptions(CarLot lot)
		{
			//Loops until the user quits.
			string search = "all";
			bool keepGoing = true;
			do
			{
				Console.WriteLine("Welcome to the Grand Circus Used Car Emporium!\n");

				//Calls DisplayCar method from the CarLot class to show all the cars.
				lot.DisplayCars(search);
				//Adds options to add a car or quit after all the cars are shown.
				Console.WriteLine($"{lot.LotCount() + 1 + ".",-4}{"Search"}");
				Console.WriteLine($"{lot.LotCount() + 2 + ".",-4}{"Admin (add/edit/replace/delete)"}");
				Console.WriteLine($"{lot.LotCount() + 3 + ".",-4}{"Quit"}");

				//Asks the user which car they want and checks that it is a valid option.
				Console.Write($"\nWhich car would you like? ");
				bool isValid = int.TryParse(Console.ReadLine(), out int option);
				while (!isValid || !(option > 0 && option <= (lot.LotCount() + 3)))
				{
					Console.Write($"Sorry, that is not a valid option.  Please select 1 - {lot.LotCount() + 3}. ");
					isValid = int.TryParse(Console.ReadLine(), out option);
				}

				//If the user selects the last option, they want to quit.
				if (option == (lot.LotCount() + 3))
				{
					//Sets to false to break out of the loop.
					keepGoing = false;
					Console.WriteLine("Thanks for shopping with us.  Have a great day!");
				}
				//If the user selects the second to last option, they want to add a car.
				else if (option == (lot.LotCount() + 2))
				{
					Console.Clear();
					//Calls method EditCars, passing the current list of cars in the lot.
					EditCars(lot);
				}
				//If the user selects the third to last option, they want to search for cars.
				else if (option == (lot.LotCount() + 1))
				{
					Console.Clear();
					Console.Write("Enter search criteria (make/year/new/uesd/price/all): ");
					search = Console.ReadLine().ToLower();
					while (!(search == "make" || search == "year" || search == "new" || search == "used" || search == "price" || search == "all"))
					{
						Console.WriteLine($"Invalid input");
						Console.Write("Enter search criteria (make/year/new/uesd/price): ");
						search = Console.ReadLine().ToLower();
					}

				}
				//Else, user selected the car they are interested in buying.
				else
				{
					Console.Clear();
					//Calls method BuyCar, passing the current list of cars in the lot and the index of the car the user selected.
					BuyCar(lot, option - 1);
				}
			} while (keepGoing);
		}

		//Method displaying edit options and getting the users input.
		static void EditCars(CarLot lot)
		{
			Console.WriteLine("1. Add a car");
			Console.WriteLine("2. Edit a car");
			Console.WriteLine("3. Replace a car");
			Console.WriteLine("4. Delete a car");
			Console.WriteLine("5. Back");
			Console.Write("Please select an option (1-5): ");
			bool isValid = int.TryParse(Console.ReadLine(), out int option);
			while(!isValid && !(option >= 1 && option <= 5))
			{
				Console.Write("That is not a valid option.  Select 1-5. ");
				isValid = int.TryParse(Console.ReadLine(), out option);
			}
			switch (option)
			{
				case 1:
					AddACar(lot);
					break;
				case 2:
					EditACar(lot);
					break;
				case 3:
					ReplaceACar(lot);
					break;
				case 4:
					DeleteACar(lot);
					break;
				default:
					Console.Clear();
					break;
			}
		}

		//Displays cars if there are any and gets users choice of car to edit.
		static void EditACar(CarLot lot)
		{
			if (lot.LotCount() != 0)
			{
				Console.WriteLine();
				lot.DisplayCars();
				Console.Write($"\nWhich car do you want to edit (1 - {lot.LotCount()})? ");
				bool isValid = int.TryParse(Console.ReadLine(), out int option);
				while (!isValid && !(option >= 1 && option <= lot.LotCount()))
				{
					Console.Write($"That is not a valid option.  Select 1-{lot.LotCount()}. ");
					isValid = int.TryParse(Console.ReadLine(), out option);
				}
				lot.GetCar(option-1).EditCar();
				Console.Clear();
			}
			else
			{
				Console.WriteLine("There are no cars in this lot.  Please add a car first.");
			}
		}

		//Displays cars if there are any and gets users choice of car to replace.
		static void ReplaceACar(CarLot lot)
		{
			if (lot.LotCount() != 0)
			{
				lot.DisplayCars();
				Console.Write($"\nWhich car do you want to replace (1 - {lot.LotCount()})? ");
				bool isValid = int.TryParse(Console.ReadLine(), out int option);
				while (!isValid && !(option >= 1 && option <= lot.LotCount()))
				{
					Console.Write($"That is not a valid option.  Select 1-{lot.LotCount()}. ");
					isValid = int.TryParse(Console.ReadLine(), out option);
				}
				lot.RemoveCar(option - 1);
				AddACar(lot , option-1);
				Console.Clear();
			}
			else
			{
				Console.WriteLine("There are no cars in this lot.  Please add a car first.");
			}
		}

		//Displays cars if there are any and gets users choice of car to delete.
		static void DeleteACar(CarLot lot)
		{
			if (lot.LotCount() != 0)
			{
				lot.DisplayCars();
				Console.Write($"\nWhich car do you want to delete (1 - {lot.LotCount()})? ");
				bool isValid = int.TryParse(Console.ReadLine(), out int option);
				while (!isValid && !(option >= 1 && option <= lot.LotCount()))
				{
					Console.Write($"That is not a valid option.  Select 1-{lot.LotCount()}. ");
					isValid = int.TryParse(Console.ReadLine(), out option);
				}
				lot.RemoveCar(option - 1);
				Console.Clear();
			}
			else
			{
				Console.WriteLine("There are no cars in this lot.  Please add a car first.");
			}
		}

		//Method to get details from the user of car they want to add.
		static void AddACar(CarLot lot, int optionalIndex = 0)
		{
			double milage;
			decimal price;
			int year;
			string make, model;

			Console.WriteLine("Please provide the following details for the car you would like to add.");
			Console.Write("Car make: ");
			make = Console.ReadLine();
			Console.Write("Car model: ");
			model = Console.ReadLine();
			Console.Write("Car year: ");
			//Validates the year the user entered.
			bool isValid = int.TryParse(Console.ReadLine(), out year);
			while (!isValid || !(year >= 1886))
			{
				Console.Write($"Sorry, please enter a year after the car was invented (1886). ");
				isValid = int.TryParse(Console.ReadLine(), out year);
			}
			Console.Write("Car price: ");
			//Validates that the price is not negative.
			isValid = decimal.TryParse(Console.ReadLine(), out price);
			while (!isValid || !(price >= 0))
			{
				Console.Write($"Sorry, please enter non-negitive value. ");
				isValid = decimal.TryParse(Console.ReadLine(), out price);
			}
			//Asks if the car is used and validates input.
			Console.Write("Is the car used? (y/n) ");
			string input = Console.ReadLine().ToLower();
			while (!(input == "y" || input == "yes" || input == "n" || input == "no"))
			{
				Console.Write($"Sorry, please enter \"yes\" or \"no\". ");
				input = Console.ReadLine().ToLower();
			}
			//If the car is used.
			if(input == "y" || input == "yes")
			{
				//Gets the used cars milage and validates it is non-negative.
				Console.Write("Car milage: ");
				isValid = double.TryParse(Console.ReadLine(), out milage);
				while (!isValid || !(milage >= 0))
				{
					Console.Write($"Sorry, please enter non-negitive value. ");
					isValid = double.TryParse(Console.ReadLine(), out milage);
				}
				//Adds used car object with user entered values to the lot list using AddCar method from CarLot class.
				lot.AddCar(new UsedCar(make, model, year, price, milage), optionalIndex);
				Console.WriteLine("Thank you.  A used car has been added.\n");
			}
			//If the car is new.
			else
			{
				//Adds new car object with user entered values to the lot list using AddCar method from CarLot class.
				lot.AddCar(new Car(make, model, year, price), optionalIndex);
				Console.WriteLine("Thank you.  A new car has been added.\n");
			}
		}

		//Method to confirm user wants to buy the car and remove it from the list.
		static void BuyCar(CarLot lot, int index)
		{
			//Displays the selected car and verifies the user wants to buy it, validating the input.
			Console.WriteLine(lot.ViewCar(index));
			Console.Write("Is this the car you would like to buy? (y/n) ");
			string input = Console.ReadLine().ToLower();
			while (!(input == "y" || input == "yes" || input == "n" || input == "no"))
			{
				Console.Write($"Sorry, please enter \"yes\" or \"no\". ");
				input = Console.ReadLine().ToLower();
			}
			//If yes, they want to buy the car.
			if (input == "y" || input == "yes")
			{
				//Removes car from list using RemoveCar method from CarLot class.
				lot.RemoveCar(index);
				Console.WriteLine("Excellent choice! Our finance department will be with you shortly.\n");
			}
			else
			{
				//User backed out of buying the car so do nothing.
				Console.WriteLine("No problem!  Lets take another look at what we have to offer.\n");
			}
		}
	}
}