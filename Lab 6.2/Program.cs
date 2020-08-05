using System;

namespace Lab_6._2
{
	class Program
	{
		static void Main(string[] args)
		{
			CreateInventory();

			foreach(Product x in Product.Products)
			{
				Console.WriteLine(x);
			}

			CustomerOrder newOrder = new CustomerOrder();
			newOrder.AddToOrder(new Product("Dawn of the Dead", ProdCategory.Horror, 9.99m, "Zombies are going to get you at the mall."), 2);
			newOrder.AddToOrder(new Product("Aliens", ProdCategory.SciFi, 7.95m, "Aliens are going to get you at during the day."), 1);

			newOrder.SubTotal();
			newOrder.GrandTotal();
			newOrder.AmountPaid(30);
			newOrder.ChangeDue();
			Console.WriteLine(newOrder.OrderReceipt());
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
	}
}