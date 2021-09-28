using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_3._2
{
	class Program
	{
		static void Main(string[] args)
		{
			//Declared and initialized the items dictionary.  Made the key case insensitive.
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
			//Declared and initialized numerical values for menu options.
			Dictionary<int, string> itemsMenu = new Dictionary<int, string>()
			{
				[1] = "Pizza",
				[2] = "Beets",
				[3] = "Hamburger",
				[4] = "Hot Dog",
				[5] = "Pineapple",
				[6] = "Apple",
				[7] = "Cheese",
				[8] = "Ham",
				[9] = "Ice Cream",
				[10] = "Cookie"
			};
			//Declared the arraylists needed to hold the users order.
			ArrayList orderItem = new ArrayList();
			ArrayList orderPrice = new ArrayList();
			ArrayList orderQuantity = new ArrayList();

			//Loops through allowing the user to order items until they decide they are done.
			bool runAgain = true;
			while (runAgain)
			{
				//Displays out the menu items
				int options = 1;
				Console.WriteLine("Welcome to Dwight's Market!\n");
				Console.WriteLine($"{"#",2} {"Item",-20}{"Price",-20}");
				Console.WriteLine("=============================");
				foreach (KeyValuePair<string, decimal> item in items)
				{
					Console.WriteLine($"{options,2}. {item.Key,-20}${item.Value,-20}");
					options++;
				}

				//Gets the users input and makes sure it's a valid option.
				Console.Write("\nWhat item would you like to order? => ");
				string order = Console.ReadLine();
				int orderNumber = 0;
				//If the input is not in the list you are asked to try again until you pick a valid item.
				while (!(items.ContainsKey(order) || (int.TryParse(order, out orderNumber) && (orderNumber >= 1 && orderNumber <= items.Count))))
				{
					Console.Write("\nSorry, we don't have that item.  Please try again. => ");
					order = Console.ReadLine();
				}

				//Determines the quantity of the item the user wants.
				Console.Write("\nHow many of this item do you want? => ");
				bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
				while (!isValid || quantity <= 0)
				{
					Console.Write("You did not enter a valid number.  Please enter a number greater than 0. => ");
					isValid = int.TryParse(Console.ReadLine(), out quantity);
				}

				//If the user entered the actual item.
				if (orderNumber == 0)
				{
					//Outputs what the user added and how much it is.
					Console.WriteLine($"Adding {order} to the cart for ${items[order]}");
					//Checks to see if item is already on the list before adding it.
					if (!orderItem.Contains(order))
					{
						//Adds the item to the order item arraylist.
						orderItem.Add(order);
						//Adds the price for that item to the order price arraylist.
						orderPrice.Add(items[order]);
						//Adds the quantity of that item to the order quantity arraylist. 
						orderQuantity.Add(quantity);
					}
					else
					{
						//If item already exists and the item was specified by name, the quantity is updated.
						orderQuantity[orderItem.IndexOf(order)] = (int)orderQuantity[orderItem.IndexOf(order)] + quantity;
					}
				}
				//If the user entered the menu number.
				else
				{
					//Outputs what the user added and how much it is.
					Console.WriteLine($"Adding {itemsMenu[orderNumber]} to the cart for ${items[itemsMenu[orderNumber]]}");
					//Checks to see if item is already on the list before adding it.
					if (!orderItem.Contains(itemsMenu[orderNumber]))
					{
						//Adds the item to the order item arraylist.
						orderItem.Add(itemsMenu[orderNumber]);
						//Adds the price for that item to the order price arraylist.
						orderPrice.Add(items[itemsMenu[orderNumber]]);
						//Adds the quantity of that item to the order quantity arraylist. 
						orderQuantity.Add(quantity);
					}
					else
					{
						//If item already exists and the item was specified by number, the quantity is updated.
						orderQuantity[orderItem.IndexOf(itemsMenu[orderNumber])] = (int)orderQuantity[orderItem.IndexOf(itemsMenu[orderNumber])] + quantity;
					}
				}
			
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

			//Prints out the users order.
			Console.WriteLine("\nThanks for your order!");
			Console.WriteLine("Here's what you got:\n");
			Console.WriteLine($"{"qty",-4}{"item", -14}{"price per",-14}{"total",-14}");
			Console.WriteLine("========================================");
			decimal average = 0m, leastExpensive = Decimal.MaxValue, mostExpensive = 0m, itemTotal = 0m, orderTotal = 0m;
			int totalQuantity = 0;
			int leastExpensiveIndex = 0, mostExpensiveIndex = 0;
			for(int x = 0; x < orderItem.Count; x++)
			{
				//Gets the item total and the order total.
				itemTotal += ((decimal)orderPrice[x] * (int)orderQuantity[x]);
				orderTotal += itemTotal;
				//Gets the total quantity of items ordered.
				totalQuantity += (int)orderQuantity[x];
				//Displays info for each item in the order.
				Console.WriteLine($"{orderQuantity[x],-4}{orderItem[x],-14}{"$"+orderPrice[x]+" each",-14}{"$"+ itemTotal,-14}");
				//Sums up individual item prices to computer average later.
				average += (decimal)orderPrice[x];
				//Finds the most expensive item.
				if (mostExpensive < (decimal)orderPrice[x])
				{
					mostExpensive = (decimal)orderPrice[x];
					mostExpensiveIndex = x;
				}
				//Finds the least expensive item.
				if (leastExpensive > (decimal)orderPrice[x])
				{
					leastExpensive = (decimal)orderPrice[x];
					leastExpensiveIndex = x;
				}
			}
			//Computes and display the average item price for the order.
			average /= orderPrice.Count;
			Console.WriteLine($"\nAverage price per item in your order was {average:C}.");
			Console.WriteLine($"The least expensive item ordered was {orderItem[leastExpensiveIndex]} at {leastExpensive:C}.");
			Console.WriteLine($"The most expensive item ordered was {orderItem[mostExpensiveIndex]} at {mostExpensive:C}.");
			Console.WriteLine($"Your total comes to {orderTotal:C} for {totalQuantity} items.");
		}
	}
}