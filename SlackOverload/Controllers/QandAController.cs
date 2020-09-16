using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapper.Contrib.Extensions;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using SlackOverload.Models;

namespace SlackOverload.Controllers
{
	public class QandAController : Controller
	{
		public IActionResult Index(string search)
		{
			List<Questions> questions = Questions.Read(search);
			return View(questions);
		}

		public IActionResult Question() //add or edit question
		{
			return View();
		}

		public IActionResult Answer() //add or edit answer
		{
			return View();
		}

		public IActionResult PageResult(long id) //display questions and associated answers
		{
			Questions question = Questions.Read(id);

			return View(question);
		}
	}
}
