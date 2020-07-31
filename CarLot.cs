using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Lab_5._3
{
	class CarLot
	{
		//Delcares list to store all the car and used car objects.
		private List<Car> CarLotList = new List<Car>();

		//Method to add a car or used car object to the list.
		public void AddCar(Car addMe)
		{
			CarLotList.Add(addMe);
		}

		//Method to remove a car or used car object from the list based on that objects index which is passed in.
		public void RemoveCar(int index)
		{
			CarLotList.RemoveAt(index);
		}

		//Method to display all cars in the current CarLot object.
		public void DisplayCars()
		{
			Console.WriteLine($"{"",-4}{"Make",-14}{"Model",-14}{"Year",-4}{"Price",14}{"New/Used",10}{"\tMiles",-18}");
			Console.WriteLine(new string('*',78));
			for (int index = 0; index < CarLotList.Count; index++)
			{
				Console.WriteLine($"{index+1+".",-4}{CarLotList[index]}");
			}
		}

		//Method to return a single car from the list.
		public string ViewCar(int index)
		{
			Console.WriteLine($"{"Make",-14}{"Model",-14}{"Year",-4}{"Price",14}{"New/Used",10}{"\tMiles",-18}");
			Console.WriteLine(new string('*', 78));
			return CarLotList[index].ToString();
		}

		//Method to return a count of the number of car and used car objects in the list.
		public int LotCount()
		{
			return CarLotList.Count;
		}

		//Method to edit a car.
		public void EditCar(int index)
		{
			//Sets index argument to zero based index.
			index--;
			Console.Write("What would you like to change? (make/model/year/price/used) ");
			string input = Console.ReadLine().ToLower();
			while(!(input == "make" || input == "model" || input == "year" || input == "price" || input == "used"))
			{
				Console.Write("Invalid input.  Try again. (make/model/year/price/used) ");
				input = Console.ReadLine().ToLower();
			}
			switch (input)
			{
				case "make":
					Console.Write("Enter a new make: ");
					input = Console.ReadLine();
					CarLotList[index].Make = input;
					break;
				case "model":
					break;
				case "year":
					break;
				case "price":
					break;
				case "used":
					break;
			}

		}
	}
}