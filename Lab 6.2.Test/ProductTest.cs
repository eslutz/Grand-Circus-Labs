using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lab_6._2.Test
{
	public class ProductTest
	{
		[Fact]
		public void ToStringOverrideTest()
		{
			Product test = new Product("Dawn of the Dead", ProdCategory.Horror, 19.99m, "Zombies are going to get you at the mall.");

			Assert.Equal("Dawn of the Dead                        Horror      $19.99  Zombies are going to get you at the mall.", test.ToString());
		}

		[Fact]
		public void ProductDisplayTest()
		{
			Product.Products.Clear();
			Product item1 = new Product("Dawn of the Dead", ProdCategory.Horror, 9.99m, "Zombies are going to get you at the mall.");
			Product item2 = new Product("Aliens", ProdCategory.SciFi, 7.95m, "Zombies are going to get you at during the day.");
			string result = "Item                                        Category     Price  Description\n**********************************************************************************************************************\n1.  Dawn of the Dead                        Horror       $9.99  Zombies are going to get you at the mall.\n2.  Aliens                                  SciFi        $7.95  Zombies are going to get you at during the day.\n";

			Assert.Equal(result, Product.DisplayProducts());
		}
	}
}