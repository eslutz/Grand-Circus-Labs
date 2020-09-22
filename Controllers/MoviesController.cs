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

		[HttpGet("Random")]
		public TheMovie RandomMovie()
		{
			Random rand = new Random();
			List<TheMovie> movies = TheMovie.Read();
			int randomPick = rand.Next(0, movies.Count);
			long movieID = movies[randomPick].ID;
			TheMovie movie = TheMovie.Read(movieID);
			return movie;
		}

		[HttpGet("Random/{category}")]
		public TheMovie RandomMovie(string category)
		{
			Random rand = new Random();
			List<TheMovie> movies = TheMovie.Read(category);
			int randomPick = rand.Next(0, movies.Count);
			long movieID = movies[randomPick].ID;
			TheMovie movie = TheMovie.Read(movieID);
			return movie;
		}
	}
}
