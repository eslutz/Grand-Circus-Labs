using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace SlackOverload.Models
{
    [Table ("Questions")]
    public class Questions
    {
        [Key]
        public long id { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DateTime Posted { get; set; }
        public string Category { get; set; }
        public string Tags { get; set; }
        public int Status { get; set; }

        public static void Create(string username, string title, string detail, string category, string tags)
        {
            Questions question = new Questions() { Username = username, Title = title, Detail = detail, Category = category, Tags = tags, Posted = DateTime.Now, Status = 1 };
            IDbConnection db = new SqlConnection("Server=BW18Q13\\SQLEXPRESS;Database=SlackOverload;user id=test;password=password");
            db.Insert(question);
        }

        public static void Update(long id, string username, string title, string detail, string category, string tags, int status)
        {
            Questions question = new Questions() { id = id, Username = username, Title = title, Detail = detail, Category = category, Tags = tags, Posted = DateTime.Now, Status = status };
            IDbConnection db = new SqlConnection("Server=BW18Q13\\SQLEXPRESS;Database=SlackOverload;user id=test;password=password");
            db.Update(question);
        }

        public static void Delete(long id)
        {
            IDbConnection db = new SqlConnection("Server=BW18Q13\\SQLEXPRESS;Database=SlackOverload;user id=test;password=password");
            db.Delete(new Questions() {id = id });
        }
    }


}
