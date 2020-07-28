using System;
using System.Collections.Generic;
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
			for (int index = 0; index < CarLotList.Count; index++)
			{
				Console.WriteLine($"{index+1+".",-4}{CarLotList[index]}");
			}
		}

		//Method to return a single car from the list.
		public string ViewCar(int index)
		{
			return CarLotList[index].ToString();
		}

		//Method to return a count of the number of car and used car objects in the list.
		public int LotCount()
		{
			return CarLotList.Count;
		}
	}
}