using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lab_6._2.Test
{
	public class CustomerOrderTest
	{
		[Fact]
		public void AddToOrderTest()
		{
			CustomerOrder newOrder = new CustomerOrder();
			newOrder.AddToOrder(new Product("Dawn of the Dead", ProdCategory.Horror, 9.99m, "Zombies are going to get you at the mall."), 2);

			Assert.Single(newOrder.Order);
		}

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
			newOrder.SubTotal();

			Assert.Equal(29.61m, newOrder.GrandTotal());
		}

		[Fact]
		public void AmmountPaidTest()
		{
			CustomerOrder newOrder = new CustomerOrder();
			newOrder.AmountPaid(30);

			Assert.Equal(30, newOrder.PayementAmount);
		}

		[Fact]
		public void ChangeDueTest()
		{
			CustomerOrder newOrder = new CustomerOrder();
			newOrder.AddToOrder(new Product("Dawn of the Dead", ProdCategory.Horror, 9.99m, "Zombies are going to get you at the mall."), 2);
			newOrder.AddToOrder(new Product("Aliens", ProdCategory.SciFi, 7.95m, "Aliens are going to get you at during the day."), 1);
			newOrder.SubTotal();
			newOrder.GrandTotal();
			newOrder.AmountPaid(30);

			Assert.Equal(0.39m, newOrder.ChangeDue());
		}

		[Fact]
		public void ReceiptTest()
		{
			CustomerOrder newOrder = new CustomerOrder();
			newOrder.AddToOrder(new Product("Dawn of the Dead", ProdCategory.Horror, 9.99m, "Zombies are going to get you at the mall."), 2);
			newOrder.AddToOrder(new Product("Aliens", ProdCategory.SciFi, 7.95m, "Aliens are going to get you at during the day."), 1);
			newOrder.SubTotal();
			newOrder.GrandTotal();
			newOrder.AmountPaid(30);
			newOrder.ChangeDue();
			string result = "Item                                    Category     Price  Qty.       Total\n****************************************************************************\nDawn of the Dead                        Horror       $9.99     2      $19.98\nAliens                                  SciFi        $7.95     1       $7.95\n\n------------------------------\nSubtotal:           $27.93\nTotal (6% tax):     $29.61\nAmount Paid:        $30.00\nChange Due:         $0.39";

			Assert.Equal(result, newOrder.OrderReceipt());
		}
	}
}