using System;

namespace Lab_4._3
{
	class Movies
	{
		//Fields
		private string _title;
		private string _category;

		//
		public string Title
		{
			get { return _title; }
		}

		public string Category
		{
			get { return _category; }
		}

		//Constructor
		public Movies(string title, string category)
		{
			_title = title;
			_category = category;
		}
	}
}
