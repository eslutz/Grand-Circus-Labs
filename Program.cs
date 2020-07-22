using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_4._3
{
	class Program
	{
		static void Main(string[] args)
		{
			//Generates a list of movies.
			List<Movies> movieList = GenerateMovies();
			List<string> categories = GetCategories(movieList);

			Console.WriteLine("Welcome to the Movie List Application!\n");

			do
			{
				//Shows how many movies and a list of the available categories.
				Console.WriteLine($"There are {movieList.Count} movies in the list of the following categories:");
				for (int index = 0; index < categories.Count; index++)
				{
					Console.WriteLine($"{index + 1}. {categories[index]}");
				}

				//Gets input from the user and validates it for their category choice
				Console.Write($"What category are you interested in? Please select a category 1 - {categories.Count} => ");
				bool isValid = int.TryParse(Console.ReadLine(), out int input);
				while (!isValid || !(input > 0 && input <= categories.Count))
				{
					Console.WriteLine("That is not a valid category.");
					Console.Write($"Please select a category 1 - {categories.Count} => ");
					isValid = int.TryParse(Console.ReadLine(), out input);
				}

				//Calls method to display the movies, passing the list of movies and the chosen category.
				DisplayMovies(movieList, categories[input - 1]);

			} while (true);
		}

		//Generates a list of movies and returns the list.
		public static List<Movies> GenerateMovies()
		{
			List<Movies> movies = new List<Movies>();
			movies.Add(new Movies("Aliens", "Sci Fi"));
			movies.Add(new Movies("The Matrix", "Sci Fi"));
			movies.Add(new Movies("Die Hard", "Action"));
			movies.Add(new Movies("Evil Dead", "Horror"));
			movies.Add(new Movies("Back to the Future", "Comedy"));
			movies.Add(new Movies("Bad Boys", "Action"));
			movies.Add(new Movies("Bad Santa", "Comedy"));
			movies.Add(new Movies("Bill & Ted's Excellent Adventure", "Comedy"));
			movies.Add(new Movies("Blade Runner", "Sci Fi"));
			movies.Add(new Movies("The Blues Brothers", "Comedy"));
			movies.Add(new Movies("Caddyshack", "Comedy"));
			movies.Add(new Movies("A Christmas Story", "Comedy"));
			movies.Add(new Movies("Dawn of the Dead", "Horror"));
			movies.Add(new Movies("Dirty Harry", "Thriller"));
			movies.Add(new Movies("The Fifth Element", "Sci Fi"));
			movies.Add(new Movies("Fury", "Action"));
			movies.Add(new Movies("Gladiator", "Drama"));
			movies.Add(new Movies("Hidden Figures", "Drama"));
			movies.Add(new Movies("Idiocracy", "Documentary"));
			movies.Add(new Movies("Indiana Jones", "Action"));
			movies.Add(new Movies("John Wick", "Action"));
			movies.Add(new Movies("Joker", "Drama"));
			movies.Add(new Movies("Jurassic Park", "Action"));
			movies.Add(new Movies("The Martian", "Sci Fi"));
			movies.Add(new Movies("Napoleon Dynamite", "Comedy"));
			movies.Add(new Movies("Office Space", "Comedy"));
			movies.Add(new Movies("Outland", "Sci Fi"));
			movies.Add(new Movies("Predator", "Sci Fi"));
			movies.Add(new Movies("Robocop", "Action"));
			movies.Add(new Movies("Scream", "Horror"));
			movies.Add(new Movies("Gran Torino", "Drama"));
			movies.Add(new Movies("Contagion", "Thriller"));
			movies.Add(new Movies("Ronin", "Thriller"));
			return movies;
		}

		//Generates a list of categories and returns the list.
		public static List<string> GetCategories(List<Movies> movies)
		{
			//Declares an empty list of caregories.
			List<string> categories = new List<string>();
			//Goes through the list of movies
			foreach (Movies movie in movies)
			{
				//If the movie category is not already in the list, it gets added.
				if (!categories.Contains(movie.Category))
				{
					categories.Add(movie.Category);
				}
			}
			//Returns the list of unique categories.
			categories.Add("All");
			return categories;
		}

		//Displays the movies in the chosen category.
		public static void DisplayMovies(List<Movies> movies, string category)
		{
			//Puts each movies of the chosen category into a list.
			List<Movies> sortedMovies = new List<Movies>();
			if (category == "All")
			{
				sortedMovies = movies;
			}
			else
			{
				foreach (Movies movie in movies)
				{
					if (movie.Category == category)
					{
						sortedMovies.Add(movie);
					}
				}				
			}

			//Sorted movies by title using LINQ.
			sortedMovies.OrderBy(x => x.Title);

			//Displays list of movies of the chosen category.
			Console.WriteLine($"\n{"Title",-25}{"Category",-25}");
			Console.WriteLine(new String('*', 50));
			foreach(Movies movie in sortedMovies)
			{
				Console.WriteLine($"{movie.Title,-25}{movie.Category,-25}");
			}
		}
	}
}
