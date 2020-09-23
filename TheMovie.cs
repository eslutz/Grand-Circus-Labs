using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_15._2
{
	[Table("Movie")]
	public class TheMovie
	{
		public long ID { get; set; }
		public string Title { get; set; }
		public string Category { get; set; }
		public int ReleaseYear { get; set; }
		public int Runtime { get; set; }

		private static string connection = "Server=BCKW433\\SQLEXPRESS;Database=Movie;user id=MovieUser;password=ILikeMovies";
		//Create
		public static TheMovie Create(string title, string category, int releaseYear, int runtime)
		{
			TheMovie movie = new TheMovie() { Title = title, Category = category, ReleaseYear = releaseYear, Runtime = runtime };
			IDbConnection database = new SqlConnection(connection);
			long id = database.Insert<TheMovie>(movie);
			movie.ID = id;
			return movie;
		}

		//Read
		public static TheMovie Read(long id)
		{
			IDbConnection database = new SqlConnection(connection);
			TheMovie movie = database.Get<TheMovie>(id);
			return movie;
		}

		public static List<TheMovie> Read(string category)
		{
			IDbConnection database = new SqlConnection(connection);
			List<TheMovie> movies = database.Query<TheMovie>($"select * from Movie where Category = '{category}'").ToList();
			return movies;
		}

		public static List<string> ReadCategories()
		{
			IDbConnection database = new SqlConnection(connection);
			List<TheMovie> movies = database.Query<TheMovie>($"select distinct Category from Movie").AsList();
			List<string> categories = new List<string>();
			foreach (TheMovie movie in movies)
			{
				categories.Add(movie.Category);
			}
			return categories;
		}

		public static List<TheMovie> ReadTitle(string title)
		{
			IDbConnection database = new SqlConnection(connection);
			List<TheMovie> movies = database.Query<TheMovie>($"select * from Movie where Title = '{title}'").AsList();
			return movies;
		}

		public static List<TheMovie> Read()
		{
			IDbConnection database = new SqlConnection(connection);
			List<TheMovie> movies = database.GetAll<TheMovie>().ToList();
			return movies;
		}

		//Update
		public void Save()
		{
			IDbConnection database = new SqlConnection(connection);
			database.Update(this);
		}

		//Delete
		public static void Delete(long id)
		{
			IDbConnection database = new SqlConnection(connection);
			database.Delete(new TheMovie() { ID = id });
		}
	}
}
