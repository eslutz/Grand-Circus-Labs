using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_3._2
{
	class Program
	{
		static void Main(string[] args)
		{
			//Declared and intinalized the items dictionary.  Made the key case insensitive.
			Dictionary<string, decimal> items = new Dictionary<string, decimal>(StringComparer.CurrentCultureIgnoreCase)
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

			//Loops through allowing the user to order items until they decide they are done.
			bool runAgain = true;
			while (runAgain)
			{
				//Displays out the menu items
				Console.WriteLine("Welcome to Dwight's Market!\n");
				Console.WriteLine($"{"Item",-20}{"Price",-20}");
				Console.WriteLine("=============================");
				foreach (KeyValuePair<string, decimal> item in items)
				{
					Console.WriteLine($"{item.Key,-20}${item.Value,-20}");
				}

				//Gets the users input and makes sure it's a valid option.
				Console.Write("\nWhat item would you like to order? => ");
				string order = Console.ReadLine();
				//If the input is not in the list you are asked to try again until you pick a valid item.
				while (!items.ContainsKey(order))
				{
					Console.Write("\nSorry, we don't have that item.  Please try again. => ");
					order = Console.ReadLine();
				}
				//Outputs what the user added and how much it is.
				Console.WriteLine($"Adding {order} to the cart for ${items[order]}");
				//Adds the item to the order item arraylist.
				orderItem.Add(order);
				//Adds the price for that item to the order price arraylist.
				orderPrice.Add(items[order]);

				//Determines if the user would like to order more items and either runs again or ends the loop.
				Console.Write("\nWould you like to order anything else? (yes/no) => ");
				string orderMore = Console.ReadLine().ToLower();
				while (!(orderMore == "yes" || orderMore == "y" || orderMore == "no" || orderMore == "n"))
				{
					Console.Write("\nInvalid input.  Please enter \"yes\" or \"no\" => ");
					orderMore = Console.ReadLine().ToLower();
				}
				if (orderMore == "no" || orderMore == "n")
				{
					Console.Clear();
					runAgain = false;
				}

				else
				{
					Console.Clear();
				}
			}
		}
	}
}
