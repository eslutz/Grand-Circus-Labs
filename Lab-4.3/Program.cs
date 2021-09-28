using System;
using System.Collections.Generic;

namespace Lab_4._3
{
	class Program
	{
		static void Main(string[] args)
		{
			//Generates a list of movies.
			List<Movies> movieList = GenerateMovies();
			List<string> categories = GetCategories(movieList);

			Console.WriteLine("Welcome to the Movie List Application!");

			string yesOrNo;
			do
			{
				//Shows how many movies and a list of the available categories.
				Console.WriteLine($"\nThere are {movieList.Count} movies in the list of the following categories:");
				for (int index = 0; index < categories.Count; index++)
				{
					Console.WriteLine($"{index + 1}. {categories[index]}");
				}

				//Gets category and displays movies of that category
				int catIndex = GetCategoryInput(categories);
				DisplayMovies(movieList, categories[catIndex]);

				//Asks the user if they want to continue translating and validates their input.
				Console.Write("\nContinue? (y/n): ");
				yesOrNo = Console.ReadLine().ToLower();
				while (!(yesOrNo == "yes" || yesOrNo == "y" || yesOrNo == "no" || yesOrNo == "n"))
				{
					Console.Write("Invalid input.  Continue? (y/n): ");
					yesOrNo = Console.ReadLine().ToLower();
				}
				Console.Clear();
			} while (yesOrNo == "yes" || yesOrNo == "y");
		}

		//Generates a list of movies and returns the list.
		public static List<Movies> GenerateMovies()
		{
			List<Movies> movies = new List<Movies>();
			movies.Add(new Movies("Aliens", "Sci Fi", 1986, 137));
			movies.Add(new Movies("The Matrix", "Sci Fi", 1999, 136));
			movies.Add(new Movies("Die Hard", "Action", 1988, 132));
			movies.Add(new Movies("Evil Dead", "Horror", 1982, 85));
			movies.Add(new Movies("Back to the Future", "Comedy", 1985, 116));
			movies.Add(new Movies("Bad Boys", "Action", 1995, 118));
			movies.Add(new Movies("Bad Santa", "Comedy", 2003, 99));
			movies.Add(new Movies("Bill & Ted's Excellent Adventure", "Comedy", 1989, 89));
			movies.Add(new Movies("Blade Runner", "Sci Fi", 1982, 117));
			movies.Add(new Movies("The Blues Brothers", "Comedy", 1980, 157));
			movies.Add(new Movies("Caddyshack", "Comedy", 1980, 98));
			movies.Add(new Movies("A Christmas Story", "Comedy", 1983, 93));
			movies.Add(new Movies("Dawn of the Dead", "Horror", 1978, 127));
			movies.Add(new Movies("Day of the Dead", "Horror", 1985, 96));
			movies.Add(new Movies("Night of the Living Dead", "Horror", 1968, 88));
			movies.Add(new Movies("Dirty Harry", "Thriller", 1971, 102));
			movies.Add(new Movies("The Fifth Element", "Sci Fi", 1997, 125));
			movies.Add(new Movies("Fury", "Action", 2014, 134));
			movies.Add(new Movies("Gladiator", "Drama", 2000, 155));
			movies.Add(new Movies("Hidden Figures", "Drama", 2016, 127));
			movies.Add(new Movies("Harold and Kumar Go to White Castle", "Comedy", 2004, 88));
			movies.Add(new Movies("Idiocracy", "Documentary", 2007, 84));
			movies.Add(new Movies("Indiana Jones and the Last Crusade", "Action", 1989, 126));
			movies.Add(new Movies("John Wick", "Action", 2014, 101));
			movies.Add(new Movies("Joker", "Drama", 2019, 121));
			movies.Add(new Movies("Jurassic Park", "Action", 1993, 126));
			movies.Add(new Movies("The Martian", "Sci Fi", 2015, 142));
			movies.Add(new Movies("Napoleon Dynamite", "Comedy", 2004, 94));
			movies.Add(new Movies("Office Space", "Comedy", 1999, 89));
			movies.Add(new Movies("Outland", "Sci Fi", 1981, 109));
			movies.Add(new Movies("Predator", "Sci Fi", 1987, 106));
			movies.Add(new Movies("Robocop", "Action", 1987, 103));
			movies.Add(new Movies("Scream", "Horror", 1996, 110));
			movies.Add(new Movies("Gran Torino", "Drama", 2009, 116));
			movies.Add(new Movies("Contagion", "Thriller", 2011, 106));
			movies.Add(new Movies("Outbreak", "Drama", 1995, 122));
			movies.Add(new Movies("Commando", "Action", 1985, 90));
			movies.Add(new Movies("Terminator", "Action", 1984, 107));
			movies.Add(new Movies("Stargate", "Sci Fi", 1994, 121));
			movies.Add(new Movies("Starship Troopers", "Sci Fi", 1997, 129));
			movies.Add(new Movies("Slither", "Horror", 2006, 95));
			movies.Add(new Movies("Ronin", "Thriller", 1998, 121));
			movies.Add(new Movies("Serenity", "Sci Fi", 2005, 118));
			movies.Add(new Movies("Shaun of the Dead", "Comedy", 2004, 99));
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

			//Sorts movies by title.
			sortedMovies.Sort((p, q) => p.Title.CompareTo(q.Title));

			//Displays list of movies of the chosen category.
			Console.WriteLine($"\n{"Title", -40}|{"Category", -12}|{"Release Year", -15}|{"Runtime", -10}");
			Console.WriteLine($"{new String('*', 40)}|{new String('*', 12)}|{new String('*', 15)}|{new String('*', 10)}");
			foreach(Movies movie in sortedMovies)
			{
				Console.WriteLine($"{movie.Title, -40}|{movie.Category, -12}|{movie.ReleaseYear, -15}|{movie.Runtime, -10}");
			}
		}

		//Gets category choice from the user, validates it, and returns it.
		public static int GetCategoryInput(List<string> categories)
		{
			//Create a lower case version of the categories for comparison.
			List<string> lowerCategories = new List<string>();
			foreach(string category in categories)
			{
				lowerCategories.Add(category.ToLower());
			}

			//Get the category input from the user.
			Console.Write($"What category are you interested in? Please select a category 1 - {categories.Count} => ");
			string input = Console.ReadLine().ToLower();
			//Determines if they entered a valid integer.
			bool isValid = int.TryParse(input, out int selection);
			//Determines if they entered a valid category.
			bool catFound = lowerCategories.Contains(input);

			//If there is no valid input or the number entered is not within the required range the user is required to try again.
			while((!isValid || !(selection > 0 && selection <= lowerCategories.Count)) && !catFound)
			{
				Console.WriteLine("That is not a valid category.");
				Console.Write($"What category are you interested in? Please select a category 1 - {lowerCategories.Count} => ");
				input = Console.ReadLine().ToLower();
				isValid = int.TryParse(input, out selection);
				catFound = lowerCategories.Contains(input);
			}

			//If the user entered a number for category, returns the zero based index value.
			if (isValid)
			{
				return selection - 1;
			}
			//If the user entered a category, returns the index value for that category.
			else
			{
				return lowerCategories.IndexOf(input);
			}
		}
	}
}

//Keeping for reference.
//Console.Write($"What category are you interested in? Please select a category 1 - {categories.Count} => ");
//string input = Console.ReadLine();
//bool isValid = int.TryParse(input, out int selection);
//bool catFound = categories.Contains(categories.Find(s => s.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0));

//if (isValid)
//{
//	while (!(selection > 0 && selection <= categories.Count))
//	{
//		Console.WriteLine("That is not a valid category.");
//		selection = GetCategoryInput(categories);
//	}
//}
//else if (!isValid && catFound)
//{
//	selection = categories.FindIndex((s => s.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0));
//}
//else
//{
//	Console.WriteLine("That is not a valid category.");
//	selection = GetCategoryInput(categories);
//}
//return selection;
