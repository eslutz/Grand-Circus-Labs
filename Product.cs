using Dapper;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Lab_15._3
{
	[Table("Products")]
	public class Product
	{
		[Key]
		public string ProductID { get; set; }
		public string ProductName { get; set; }
		public int SupplierId { get; set; }
		public int CategoryID { get; set; }
		public int QuantityPerUnit { get; set; }
		public decimal UnitPrice { get; set; }
		public string UnitsInStock { get; set; }
		public int UnitsOnOrder { get; set; }
		public int ReorderLevel { get; set; }
		public int Discontinued { get; set; }

		public static List<Product> Read(IDbConnection _db)
		{
			List<Product> result = _db.GetAll<Product>().ToList();
			return result;
		}

		public static List<string> ReadProductNames(IDbConnection _db)
		{
			List<Product> result = _db.GetAll<Product>().ToList();
			List<string> productnames = new List<string>();

			foreach (Product product in result)
			{
				productnames.Add(product.ProductName);
			}
			return productnames;
		}

		public static List<Product> CheckStockUnder(IDbConnection _db, int UnitsInStock)
		{
			List<Product> products = (List<Product>)_db.Query<Product>($"SELECT * FROM Products WHERE UnitsInStock <= {UnitsInStock}");
			return products;
		}

		public static Product UpdateStock(IDbConnection _db, Product product)
		{
			_db.Query<Product>($"UPDATE Products SET UnitsInStock = {product.UnitsInStock} WHERE ProductId = {product.ProductID}");
			Product updatedProduct = _db.Get<Product>(product.ProductID);
			return updatedProduct;
		}
	}
}