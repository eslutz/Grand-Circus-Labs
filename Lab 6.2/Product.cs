using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6._2
{
	public enum ProdCategory
	{
		Action,
		Comedy,
		Documentary,
		Drama,
		Horror,
		SciFi,
		Thriller
	}

	public class Product
	{
		//Stores the list of products.
		private static List<Product> _products = new List<Product>();

		private string _name;
		private ProdCategory _category;
		private string _description;
		private decimal _price;

		//Allows list to be read from outside the class.
		public static List<Product> Products
		{
			get { return _products; }
		}

		public string Name
		{
			get { return _name; }
			private set { _name = value; }
		}

		public ProdCategory Category
		{
			get { return _category; }
			private set { _category = value; }
		}

		public string Description
		{
			get { return _description; }
			private set { _description = value; }
		}

		public decimal Price
		{
			get { return _price; }
			private set { _price = value; }
		}

		//Constructor taking in all the paramaters.
		public Product(string name, ProdCategory cat, decimal price, string description)
		{
			Name = name;
			Category = cat;
			Price = price;
			Description = description;
			Products.Add(this);
		}

		public static string DisplayProducts()
		{
			string allProducts = $"{"Item",-44}{"Category",-12}{"Price",6}{"",2}{"Description"}\n";
			allProducts += $"{new String('*',118)}\n";
			for(int index = 0; index < Products.Count; index++)
			{
				allProducts += $"{(index + 1)+".",-4}{Products[index]}\n";
			}
			return allProducts;
		}

		//Override tostring to display the values of the product.
		public override string ToString()
		{
			return $"{Name, -40}{Category, -12}{Price, 6:C}{"",2}{Description}";
		}
	}
}