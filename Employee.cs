using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_15._3
{
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

		public static List<Employee> Read(IDbConnection database)
		{
			List<Employee> employees = database.GetAll<Employee>().ToList();
			return employees;
		}

		public static long Create(IDbConnection database, string lastname, string firstname)
		{
			Employee employee = new Employee()
			{
				FirstName = "test",
				LastName = lastname,
				Title = null,
				TitleOfCourtesy = null,
				BirthDate = DateTime.Now,
				HireDate = DateTime.Now,
				Address = null,
				City = null,
				Region = null,
				Country = null,
				HomePhone = null,
				Extension = null,
				ReportsTo = null,
				PhotoPath = null
			};
			long id = database.Insert<Employee>(employee);
			return id;
		}
	}
}
