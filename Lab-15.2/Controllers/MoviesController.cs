using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_15._2.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class MoviesController : ControllerBase
	{
		private static Random rand = new Random();

		[HttpGet]
		public List<TheMovie> Movie()
		{
			List<TheMovie> movies = TheMovie.Read();
			return movies;
		}

		[HttpGet("Category")]
		public List<string> MovieCategories()
		{
			List<string> categories = TheMovie.ReadCategories();
			return categories;
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
			List<TheMovie> movies = TheMovie.Read();
			int randomPick = rand.Next(0, movies.Count);
			long movieID = movies[randomPick].ID;
			TheMovie movie = TheMovie.Read(movieID);
			return movie;
		}

		[HttpGet("Random/List")]
		public List<TheMovie> RandomMovies()
		{
			List<TheMovie> movies = TheMovie.Read();
			int listLength = rand.Next(0, movies.Count);
			List<TheMovie> randomMovieList = new List<TheMovie>();
			for (int x = 0; x < listLength; x++)
			{
				int randomPick = rand.Next(0, movies.Count);
				while (randomMovieList.Any(x => x.ID == movies[randomPick].ID))
				{
					randomPick = rand.Next(0, movies.Count);
				}
				long movieID = movies[randomPick].ID;
				randomMovieList.Add(TheMovie.Read(movieID));
			}
			return randomMovieList;
		}

		[HttpGet("Random/List/{listLength}")]
		public List<TheMovie> RandomMovies(int listLength)
		{
			List<TheMovie> movies = TheMovie.Read();
			List<TheMovie> randomMovieList = new List<TheMovie>();
			//If user enters a length greater than the number of movies that exists, then displays all the movies.
			if (listLength >= movies.Count)
			{
				listLength = movies.Count;
			}
			for (int x = 0; x < listLength; x++)
			{
				int randomPick = rand.Next(0, movies.Count);
				while (randomMovieList.Any(x => x.ID == movies[randomPick].ID))
				{
					randomPick = rand.Next(0, movies.Count);
				}
				long movieID = movies[randomPick].ID;
				randomMovieList.Add(TheMovie.Read(movieID));
			}
			return randomMovieList;
		}

		[HttpGet("Random/{category}")]
		public TheMovie RandomMovie(string category)
		{
			List<TheMovie> movies = TheMovie.Read(category);
			TheMovie movie = null;
			if (movies.Count != 0)
			{
				int randomPick = rand.Next(0, movies.Count);
				long movieID = movies[randomPick].ID;
				movie = TheMovie.Read(movieID);
			}
			return movie;
		}

		[HttpGet("{title}")]
		public List<TheMovie> MovieTitleLookup(string title)
		{
			List<TheMovie> movies = TheMovie.ReadTitle(title);
			return movies;
		}

		[HttpGet("Search/{title}")]
		public List<TheMovie> MovieTitleSearch(string title)
		{
			List<TheMovie> movies = TheMovie.ReadTitleSearch(title);
			return movies;
		}
	}
}