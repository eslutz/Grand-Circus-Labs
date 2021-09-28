using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SlackOverload.Models
{
	[Table("Questions")]
	public class Questions
	{
		[Key]
		public long id { get; set; }
		public string Username { get; set; }
		public string Title { get; set; }
		public string Details { get; set; }
		public DateTime Posted { get; set; }
		public string Category { get; set; }
		public string Tags { get; set; }
		public int Status { get; set; }

		public static void Create(string username, string title, string details, string category, string tags)
		{
			Questions question = new Questions() { Username = username, Title = title, Details = details, Category = category, Tags = tags, Posted = DateTime.Now, Status = 0 };
			//IDbConnection db = new SqlConnection("Server=BW18Q13\\SQLEXPRESS;Database=SlackOverload;user id=test;password=password");               //***Manny***
			//IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=SlackOverload;user id=da;password=P@$$word!@#;");             //***Adam***
			IDbConnection db = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=SlackOverload;user id=SlackOverloadUser;password=password");  //***Eric***
			db.Insert(question);
		}

		public static void Update(long id, string username, string title, string details, string category, string tags, int status)
		{
			Questions question = new Questions() { id = id, Username = username, Title = title, Details = details, Category = category, Tags = tags, Posted = DateTime.Now, Status = status };
			//IDbConnection db = new SqlConnection("Server=BW18Q13\\SQLEXPRESS;Database=SlackOverload;user id=test;password=password");               //***Manny***
			//IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=SlackOverload;user id=da;password=P@$$word!@#;");             //***Adam***
			IDbConnection db = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=SlackOverload;user id=SlackOverloadUser;password=password");  //***Eric***
			db.Update(question);
		}

		public static void Delete(long id)
		{
			//IDbConnection db = new SqlConnection("Server=BW18Q13\\SQLEXPRESS;Database=SlackOverload;user id=test;password=password");               //***Manny***
			//IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=SlackOverload;user id=da;password=P@$$word!@#;");             //***Adam***
			IDbConnection db = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=SlackOverload;user id=SlackOverloadUser;password=password");  //***Eric***
			db.Delete(new Questions() { id = id });
		}

		public static List<Questions> Read()
		{
			//IDbConnection db = new SqlConnection("Server=BW18Q13\\SQLEXPRESS;Database=SlackOverload;user id=test;password=password");               //***Manny***
			//IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=SlackOverload;user id=da;password=P@$$word!@#;");             //***Adam***
			IDbConnection db = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=SlackOverload;user id=SlackOverloadUser;password=password");  //***Eric***
			List<Questions> questions = db.GetAll<Questions>().ToList();
			return questions;
		}

		public static List<Questions> Read(string scope, string field, string search)
		{
			//IDbConnection db = new SqlConnection("Server=BW18Q13\\SQLEXPRESS;Database=SlackOverload;user id=test;password=password");               //***Manny***
			//IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=SlackOverload;user id=da;password=P@$$word!@#;");             //***Adam***
			IDbConnection db = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=SlackOverload;user id=SlackOverloadUser;password=password");  //***Eric***
			List<Questions> questions;
			if (scope == "Questions")
			{
				if (field == "All")
				{
					questions = db.Query<Questions>($"select id, title from Questions where Details like '%{search}%' or Title like '%{search}%' or Category like '%{search}%' or Username like '%{search}%' or Tags like '%{search}%'").AsList();
				}
				else
				{
					questions = db.Query<Questions>($"select id, title from Questions where {field} like '%{search}%'").AsList();
				}
			}
			else if (scope == "Answers")
			{
				if (field == "Title" || field == "Category" || field == "Tags")
				{
					questions = new List<Questions>();
				}
				else if (field == "All")
				{
					questions = db.Query<Questions>($"select distinct Questions.id, title from Questions join Answers on Questions.id = Answers.QuestionID where Answers.Details like '%{search}%' or Answers.Username like '%{search}%'").AsList();
				}
				else
				{
					questions = db.Query<Questions>($"select distinct Questions.id, title from Questions join Answers on Questions.id = Answers.QuestionID where Answers.{field} like '%{search}%'").AsList();
				}
			}
			else if (scope == "Q/A")
			{
				if (field == "Title" || field == "Category" || field == "Tags")
				{
					questions = db.Query<Questions>($"select distinct Questions.id, title from Questions join Answers on Questions.id = Answers.QuestionID where Questions.{field} like '%{search}%'").AsList();
				}
				else if (field == "All")
				{
					questions = db.Query<Questions>($"select distinct Questions.id, title from Questions join Answers on Questions.id = Answers.QuestionID where Questions.Details like '%{search}%' or Questions.Username like '%{search}%' or Answers.Details like '%{search}%' or Answers.Username like '%{search}%'").AsList();
				}
				else
				{
					questions = db.Query<Questions>($"select distinct Questions.id, title from Questions join Answers on Questions.id = Answers.QuestionID where Questions.{field} like '%{search}%' or Answers.{field} like '%{search}%'").AsList();
				}
			}
			else
			{
				questions = db.GetAll<Questions>().ToList();
			}
			return questions;
		}

		public static Questions Read(long id)
		{
			//IDbConnection db = new SqlConnection("Server=BW18Q13\\SQLEXPRESS;Database=SlackOverload;user id=test;password=password");               //***Manny***
			//IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=SlackOverload;user id=da;password=P@$$word!@#;");             //***Adam***
			IDbConnection db = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=SlackOverload;user id=SlackOverloadUser;password=password");  //***Eric***
			Questions question = db.Get<Questions>(id);
			return question;
		}

		public static List<string> ReadCategories()
		{
			//IDbConnection db = new SqlConnection("Server=BW18Q13\\SQLEXPRESS;Database=SlackOverload;user id=test;password=password");               //***Manny***
			//IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=SlackOverload;user id=da;password=P@$$word!@#;");             //***Adam***
			IDbConnection db = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=SlackOverload;user id=SlackOverloadUser;password=password");  //***Eric***
			List<Questions> questions = db.Query<Questions>($"select distinct Category from Questions").AsList();
			List<string> categories = new List<string>();
			foreach(Questions question in questions)
			{
				categories.Add(question.Category);
			}
			return categories;
		}
	}
}