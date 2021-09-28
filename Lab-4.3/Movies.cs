using System;

namespace Lab_4._3
{
	class Movies
	{
		//Fields
		private string _title;
		private string _category;
		private int _releaseYear;
		private int _runtime;

		//Properties
		public string Title
		{
			get { return _title; }
		}

		public string Category
		{
			get { return _category; }
		}
		public int ReleaseYear
		{
			get { return _releaseYear; }
		}

		public int Runtime
		{
			get { return _runtime; }
		}

		//Constructors
		public Movies(string title, string category, int year, int runtime)
		{
			_title = title;
			_category = category;
			_releaseYear = year;
			_runtime = runtime;
		}
	}
}
