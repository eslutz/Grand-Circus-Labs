using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lab_6._2.Test
{
	public class ProductTest
	{
		[Fact]
		//Tests that ToString override works.
		public void Test1()
		{
			Product test = new Product("Dawn of the Dead", ProdCategory.Horror, 19.99m, "Zombies are going to get you at the mall.");

			Assert.Equal("Dawn of the Dead                        Horror       19.99  Zombies are going to get you at the mall.", test.ToString());
		}

	}
}