using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6._2
{
	enum ProdCategory
	{

	}
	class Product
	{
		private string _name;
		private ProdCategory _category;
		private string _description;
		private decimal _price;

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


	}
}