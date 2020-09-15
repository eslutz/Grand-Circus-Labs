using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace SlackOverload.Models
{
    [Table ("Answers")]
    public class Answers
    {
        [Key]
        public int id { get; set; }
        public string Username { get; set; }
        public string Detail { get; set; }
        public int QuestionID { get; set; }
        public DateTime Posted { get; set; }
        public int Upvotes { get; set; }
    }
}
