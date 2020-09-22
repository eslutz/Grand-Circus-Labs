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
	public class Movie
	{
		public long ID { get; set; }
		public string Title { get; set; }
		public string Category { get; set; }
		public int ReleaseYear { get; set; }
		public int Runtime { get; set; }

		private static string connection = "Server=BCKW433\\SQLEXPRESS;Database=Movie;user id=MovieUser;password=ILikeMovies";
		//Create
		public static Movie Create(string title, string category, int releaseYear, int runtime)
		{
			Movie movie = new Movie() { Title = title, Category = category, ReleaseYear = releaseYear, Runtime = runtime };
			IDbConnection database = new SqlConnection(connection);
			long id = database.Insert<Movie>(movie);
			movie.ID = id;
			return movie;
		}

		//Read
		public static Movie Read(long id)
		{
			IDbConnection database = new SqlConnection(connection);
			Movie movie = database.Get<Movie>(id);
			return movie;
		}

		public static List<Movie> Read()
		{
			IDbConnection database = new SqlConnection(connection);
			List<Movie> movies = database.GetAll<Movie>().ToList();
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
			database.Delete(new Movie() { ID = id });
		}
	}
}
