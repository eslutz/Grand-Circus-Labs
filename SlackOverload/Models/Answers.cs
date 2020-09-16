using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;

namespace SlackOverload.Models
{
	[Table ("Answers")]
	public class Answers
	{
		[Key]
		public long id { get; set; }
		public string Username { get; set; }
		public string Details { get; set; }
		public long QuestionID { get; set; }
		public DateTime Posted { get; set; }
		public int Upvotes { get; set; }

		public static void Create(string username, string Details, long questionID)
		{
			Answers answer = new Answers() { Username = username, Details = Details, QuestionID = questionID, Posted = DateTime.Now, Upvotes = 0 };
			IDbConnection db = new SqlConnection("Server=BW18Q13\\SQLEXPRESS;Database=SlackOverload;user id=test;password=password");               //***Manny***
			//IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=SlackOverload;user id=da;password=P@$$word!@#;");             //***Adam***
			//IDbConnection db = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=SlackOverload;user id=SlackOverloadUser;password=password");  //***Eric***
			db.Insert(answer);
		}

		public static void Update(long id, string username, string Details, long questionID, int upvotes )
		{
			Answers answer = new Answers() {id = id, Username = username, Details = Details, QuestionID = questionID, Posted = DateTime.Now, Upvotes = upvotes };
			IDbConnection db = new SqlConnection("Server=BW18Q13\\SQLEXPRESS;Database=SlackOverload;user id=test;password=password");               //***Manny***
			//IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=SlackOverload;user id=da;password=P@$$word!@#;");             //***Adam***
			//IDbConnection db = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=SlackOverload;user id=SlackOverloadUser;password=password");  //***Eric***
			db.Update(answer);
		}

		public static void Delete(long id)
		{
			IDbConnection db = new SqlConnection("Server=BW18Q13\\SQLEXPRESS;Database=SlackOverload;user id=test;password=password");               //***Manny***
			//IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=SlackOverload;user id=da;password=P@$$word!@#;");             //***Adam***
			//IDbConnection db = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=SlackOverload;user id=SlackOverloadUser;password=password");  //***Eric***
			db.Delete(new Answers() { id = id });
		}

		public static List<Answers> Read()
		{
			IDbConnection db = new SqlConnection("Server=BW18Q13\\SQLEXPRESS;Database=SlackOverload;user id=test;password=password");               //***Manny***
			//IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=SlackOverload;user id=da;password=P@$$word!@#;");             //***Adam***
			//IDbConnection db = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=SlackOverload;user id=SlackOverloadUser;password=password");  //***Eric***
			List<Answers> answers = db.GetAll<Answers>().ToList();
			return answers;
		}

		public static List<Answers> Read(string search)
		{
			IDbConnection db = new SqlConnection("Server=BW18Q13\\SQLEXPRESS;Database=SlackOverload;user id=test;password=password");               //***Manny***
			//IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=SlackOverload;user id=da;password=P@$$word!@#;");             //***Adam***
			//IDbConnection db = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=SlackOverload;user id=SlackOverloadUser;password=password");  //***Eric***
			List<Answers> answers = db.Query<Answers>($"select id, title from Answers where Details like '%{search}%'").AsList();
			return answers;
		}

		public static List<Answers> Read(long id)
		{
			IDbConnection db = new SqlConnection("Server=BW18Q13\\SQLEXPRESS;Database=SlackOverload;user id=test;password=password");               //***Manny***
			//IDbConnection db = new SqlConnection("Server=CXJSN13\\SQLEXPRESS;Database=SlackOverload;user id=da;password=P@$$word!@#;");             //***Adam***
			//IDbConnection db = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=SlackOverload;user id=SlackOverloadUser;password=password");  //***Eric***
			List<Answers> answers = db.Query<Answers>($"select * from Answers where QuestionID = {id}").AsList();
			return answers;
		}
	}
}