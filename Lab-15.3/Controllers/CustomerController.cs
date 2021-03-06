using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Data;

namespace Lab_15._3.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private readonly ILogger<CustomerController> _logger;
		private IDbConnection _db;

		public CustomerController(ILogger<CustomerController> logger, IDbConnection db)
		{
			_logger = logger;
			_db = db;
		}

		[HttpPost("Add")]
		public void Add(Customers cust)
		{
			Customers.AddCustomer(_db, cust);
		}

		[HttpDelete("Delete")]
		public void Delete(Customers cust)
		{
			string customerid = cust.CustomerID;
			Customers.DeleteCustomer(_db, customerid);
		}

		[HttpGet("CustInfo/{startswith}")]
		public List<Customers> Get(string startswith)
		{
			List<Customers> customerlist = Customers.GetCustomers(_db, startswith);
			return customerlist;
		}

		[HttpGet("CustInfo/Region")]
		public List<Customers> GetNullRegion()
		{
			List<Customers> regionlist = Customers.GetNullRegionCustomers(_db);
			return regionlist;
		}

		[HttpGet("CustInfo/Region/{Region}")]
		public List<Customers> GetRegion(string region)
		{
			List<Customers> regionlist = Customers.GetRegionCustomers(_db, region);
			return regionlist;
		}
	}
}