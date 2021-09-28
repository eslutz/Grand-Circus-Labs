using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Data;

namespace Lab_15._3.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly ILogger<ProductController> _logger;
		private IDbConnection _db;

		public ProductController(ILogger<ProductController> logger, IDbConnection db)
		{
			_logger = logger;
			_db = db;
		}

		//Returns All Products
		[HttpGet]
		public List<Product> ProductRead()
		{
			List<Product> result = Product.Read(_db);//_db.GetAll<Blog2>().ToList();
			return result;
		}

		//Returns products with <= Units in Stocks
		[HttpGet("Stock/{UnitsInStock}")]
		public List<Product> Stock(int UnitsInStock)
		{
			List<Product> products = Product.CheckStockUnder(_db, UnitsInStock);
			return products;
		}

		[HttpPost("Stock/UpdateStock")]
		[Consumes("application/json")]
		public Product UpdateStock([FromBody] Product product)
		{
			Product updatedProduct = Product.UpdateStock(_db, product);
			return updatedProduct;
		}
	}
}