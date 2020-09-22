using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab_15._2.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class MoviesController : ControllerBase
	{
		[HttpGet]
		public List<TheMovie> Movie()
		{
			List<TheMovie> movies = TheMovie.Read();
			return movies;
		}

		[HttpGet("Category/{category}")]
		public List<TheMovie> Movie(string category)
		{
			List<TheMovie> movies = TheMovie.Read(category);
			return movies;
		}
	}
}
