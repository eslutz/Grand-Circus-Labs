using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lab_6._2.Test
{
	public class CustomerOrderTest
	{
		[Fact]
		public void SubtotalTest()
		{ 
			CustomerOrder newOrder = new CustomerOrder();
			newOrder.AddToOrder(new Product("Dawn of the Dead", ProdCategory.Horror, 9.99m, "Zombies are going to get you at the mall."), 2);
			newOrder.AddToOrder(new Product("Aliens", ProdCategory.SciFi, 7.95m, "Aliens are going to get you at during the day."), 1);

			Assert.Equal(27.93m, newOrder.SubTotal());
		}

		[Fact]
		public void GrandtotalTest()
		{
			CustomerOrder newOrder = new CustomerOrder();
			newOrder.AddToOrder(new Product("Dawn of the Dead", ProdCategory.Horror, 9.99m, "Zombies are going to get you at the mall."), 2);
			newOrder.AddToOrder(new Product("Aliens", ProdCategory.SciFi, 7.95m, "Aliens are going to get you at during the day."), 1);

			Assert.Equal(29.61m, newOrder.GrandTotal());
		}

		[Fact]
		public void ChangeDueTest()
		{
			CustomerOrder newOrder = new CustomerOrder();
			newOrder.AddToOrder(new Product("Dawn of the Dead", ProdCategory.Horror, 9.99m, "Zombies are going to get you at the mall."), 2);
			newOrder.AddToOrder(new Product("Aliens", ProdCategory.SciFi, 7.95m, "Aliens are going to get you at during the day."), 1);

			//Assert.Equal(0.39m, newOrder.ChangeDue(30));
		}
	}
}
