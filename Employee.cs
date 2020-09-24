using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_15._3
{
	[Table("Employees")]
	public class Employee
	{
		[Key]
		public long EmployeeID { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string Title { get; set; }
		public string TitleOfCourtesy { get; set; }
		public DateTime BirthDate { get; set; }
		public DateTime HireDate { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Region { get; set; }
		public string Country { get; set; }
		public string HomePhone { get; set; }
		public string Extension { get; set; }
		public string ReportsTo { get; set; }
		public string PhotoPath { get; set; }

		//Returns a list of all employees
		public static List<Employee> Read(IDbConnection database)
		{
			List<Employee> employees = database.GetAll<Employee>().ToList();
			return employees;
		}

		//Adds a new employee to the database and returns their employee ID
		public static long Create(IDbConnection database, Employee employee)
		{
			//Database reqquire a min DateTime value of 1/1/1753 12:00:00 AM
			//If date is set before then, increases date to minimum requirement
			if (employee.BirthDate < DateTime.Parse("1/1/1753 12:00:00 AM"))
			{
				employee.BirthDate = DateTime.Parse("1/1/1753 12:00:00 AM");
			}
			if (employee.HireDate < DateTime.Parse("1/1/1753 12:00:00 AM"))
			{
				employee.HireDate = DateTime.Parse("1/1/1753 12:00:00 AM");
			}
			long id = database.Insert<Employee>(employee);
			return id;
		}
	}
}
