using System;

namespace Lab_6._2
{
	class Program
	{
		static void Main(string[] args)
		{
			CreateInventory();
			//Loops through new orders until the user is done.
			YesNo yesOrNo;
			do
			{
				NewOrder();
				Console.Write("\nWould you like to start a new order (y/n)? ");

				bool isValid = Validator.YesOrNo(Console.ReadLine(), out yesOrNo);
				while (!isValid)
				{
					Console.Write("Invalid input.  Continue? (y/n): ");
					isValid = Validator.YesOrNo(Console.ReadLine(), out yesOrNo);
				}
				Console.Clear();
			} while (yesOrNo == YesNo.Yes);

		}

		static void CreateInventory()
		{
			Product item1 = new Product("Dawn of the Dead", ProdCategory.Horror, 9.99m, "Zombies are going to get you at the mall.");
			Product item2 = new Product("Aliens", ProdCategory.SciFi, 7.95m, "Zombies are going to get you at during the day.");
			Product item3 = new Product("Die Hard", ProdCategory.Action, 10.99m, "Zombies are going to get you at during the day.");
			Product item4 = new Product("Evil Dead", ProdCategory.Horror, 19.99m, "Zombies are going to get you at during the day.");
			Product item5 = new Product("Back to the Future", ProdCategory.Comedy, 19.95m, "Zombies are going to get you at during the day.");
			Product item6 = new Product("Bill & Ted's Excellent Adventure", ProdCategory.Comedy, 4.99m, "Zombies are going to get you at during the day.");
			Product item7 = new Product("Blade Runner", ProdCategory.SciFi, 19.99m, "Zombies are going to get you at during the day.");
			Product item8 = new Product("The Blues Brothers", ProdCategory.Comedy, 8.99m, "Zombies are going to get you at during the day.");
			Product item9 = new Product("Caddyshack", ProdCategory.Comedy, 9.95m, "Zombies are going to get you at during the day.");
			Product item10 = new Product("Dirty Harry", ProdCategory.Thriller, 6.99m, "Zombies are going to get you at during the day.");
			Product item11 = new Product("The Fifth Element", ProdCategory.SciFi, 16.99m, "Zombies are going to get you at during the day.");
			Product item12 = new Product("Fury", ProdCategory.Action, 14.95m, "Zombies are going to get you at during the day.");
			Product item13 = new Product("Gladiator", ProdCategory.Drama, 7.99m, "Zombies are going to get you at during the day.");
			Product item14 = new Product("Harold and Kumar Go to White Castle", ProdCategory.Comedy, 19.95m, "Zombies are going to get you at during the day.");
			Product item15 = new Product("Idiocracy", ProdCategory.Documentary, 4.99m, "Zombies are going to get you at during the day.");
			Product item16 = new Product("Indiana Jones and the Last Crusade", ProdCategory.Action, 10.99m, "Zombies are going to get you at during the day.");
			Product item17 = new Product("The Martian", ProdCategory.SciFi, 19.99m, "Zombies are going to get you at during the day.");
			Product item18 = new Product("Napolean Dynamite", ProdCategory.Comedy, 25.99m, "Zombies are going to get you at during the day.");
			Product item19 = new Product("Serenity", ProdCategory.SciFi, 15.99m, "Zombies are going to get you at during the day.");
			Product item20 = new Product("Shaun of the Dead", ProdCategory.Comedy, 8.95m, "Zombies are going to get you at during the day.");
		}

		static void NewOrder()
		{
			//Loops through adding items to order until the user is done.
			YesNo yesOrNo;
			CustomerOrder currentOrder = new CustomerOrder();
			do
			{
				Console.WriteLine("Welcome to the Grand Circus DVD Emporium!\n");
				Console.WriteLine(Product.DisplayProducts());

				//Gets input for what the user wants to purchase.
				Console.Write($"Which item would you like to buy (1 - {Product.Products.Count})? ");
				bool isValid = int.TryParse(Console.ReadLine(), out int choice);
				while (!isValid || !(choice > 0 && choice <= Product.Products.Count))
				{
					Console.WriteLine("That is not a valid option.");
					Console.Write($"Which item would you like to buy (1 - {Product.Products.Count})? ");
					isValid = int.TryParse(Console.ReadLine(), out choice);
				}
				//Gets quantity for item being ordered.
				Console.Write("How many of this item would you like? ");
				isValid = int.TryParse(Console.ReadLine(), out int qty);
				while (!isValid || !(qty > 0))
				{
					Console.WriteLine("That is not a valid option.");
					Console.Write("You must purchase at least one. ");
					isValid = int.TryParse(Console.ReadLine(), out qty);
				}
				//Adds item and qty. to order and displays the line total.
				currentOrder.AddToOrder(Product.Products[choice - 1], qty);
				Console.WriteLine($"You have added {qty} of {Product.Products[choice - 1].Name} to your order for {Product.Products[choice - 1].Price * qty:C}.");

				//Asks user if they want to continue.
				Console.Write("\nWould you like to purchase another item (y/n)? ");
				isValid = Validator.YesOrNo(Console.ReadLine(), out yesOrNo);
				while (!isValid)
				{
					Console.Write("Invalid input.  Continue? (y/n): ");
					isValid = Validator.YesOrNo(Console.ReadLine(), out yesOrNo);
				}
				Console.Clear();
			} while (yesOrNo == YesNo.Yes);

			//Displays subtotal, tax, and grand total.
			Console.WriteLine($"Your subtotal is: {currentOrder.SubTotal():C}");
			Console.WriteLine($"Total Tax: {decimal.Round(currentOrder.Subtotal * .06m, 2):C}");
			Console.WriteLine($"Your grand total is: {currentOrder.GrandTotal():C}");
			//Gets payment amount from user.  Must be at least the grand total.
			Console.Write("\nHow much will you be paying? $");
			bool paymentValid = decimal.TryParse(Console.ReadLine(), out decimal payment);
			while (!paymentValid || !(payment >= currentOrder.Total))
			{
				Console.WriteLine($"You must enter an amount of at least {currentOrder.Total:C}.");
				Console.Write("How much will you be paying? $");
				paymentValid = decimal.TryParse(Console.ReadLine(), out payment);
			}
			//Displays the change due to the user.
			currentOrder.AmountPaid(payment);
			Console.WriteLine($"You paid {payment:C}.  Your change is {currentOrder.ChangeDue():C}\n");

			//Displays the users order receipt.
			Console.WriteLine("Here's your receipt:");
			Console.WriteLine(currentOrder.OrderReceipt());
		}
	}
}