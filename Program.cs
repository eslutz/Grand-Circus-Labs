using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_3._2
{
	class Program
	{
		static void Main(string[] args)
		{
			//Declared all neccessary lists.
			Dictionary<string, decimal> items = new Dictionary<string, decimal>
			{
				["Pizza"] = 6.99m,
				["Beets"] = 1.99m,
				["Hamburger"] = 4.99m,
				["Hot Dog"] = 3.99m,
				["Pineapple"] = 5.99m,
				["Apple"] = 0.99m,
				["Cheese"] = 2.99m,
				["Ham"] = 4.99m,
				["Ice Cream"] = 8.99m,
				["Cookie"] = 3.99m
			};
			ArrayList orderItem = new ArrayList();
			ArrayList orderPrice = new ArrayList();

			Console.WriteLine("Welcome to Dwight's Market!");
		}
	}
}
