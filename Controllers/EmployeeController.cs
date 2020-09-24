using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Lab_15._3.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		private IDbConnection _database;
		public EmployeeController(IDbConnection database)
		{
			_database = database;
		}

		//Default route returns list of all employees by default
		[HttpGet]
		public List<Employee> Get()
		{
			List<Employee> employees = Employee.Read(_database);
			return employees;
		}

		//Employee/Country returns list of employees ordered by country
		//Employee/Country?country=<<user input>> returns list of employees in that country
		[HttpGet("Country")]
		public List<Employee> EmployeeCountry(string country)
		{
			List<Employee> employees;
			if (country == null)
			{
				employees = Employee.Read(_database).OrderBy(x => x.Country).ToList();
			}
			else
			{
				employees = Employee.Read(_database).Where(x => x.Country == country).ToList();
			}
			return employees;
		}

		[HttpPost("AddEmployee")]
		[Consumes("application/json")]
		public long AddEmployee([FromBody] Employee employee)
		{
			long employeeID = Employee.Create(_database, employee);
			return employeeID;
		}
	}
}
