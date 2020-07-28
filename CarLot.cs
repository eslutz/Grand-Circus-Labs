using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5._3
{
	class CarLot
	{
		List<Car> CarLotList = new List<Car>();

		public void AddCar(Car addMe)
		{
			CarLotList.Add(addMe);
		}

		public void RemoveCar(int index)
		{
			CarLotList.RemoveAt(index);
		}

		public void DisplayCars()
		{
			for (int index = 0; index < CarLotList.Count; index++)
			{
				Console.WriteLine($"{index+1+".",-4}{CarLotList[index]}");
			}
		}

		public string ViewCar(int index)
		{
			return CarLotList[index].ToString();
		}

		public int LotCount()
		{
			return CarLotList.Count;
		}
	}
}