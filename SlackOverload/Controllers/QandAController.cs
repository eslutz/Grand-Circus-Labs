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
		public IActionResult Index(string scope, string field, string search)
		{
			List<Questions> questions = Questions.Read(scope, field, search);
			return View(questions);
		}

		public IActionResult Question() //add or edit question
		{
			ViewBag.PageName = "Add a Question";
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

		public IActionResult SaveQuestion(long id, string username, string title, string details, string category, string tags, int status)
		{
			if (id >= 1)
			{
				Questions.Update(id, username, title, details, category, tags, status);
			}
			else
			{
				Questions.Create(username, title, details, category, tags);
			}
			ViewBag.Message = "Your entry has been saved!";
			List<Questions> blogs = Questions.Read();
			return View("Index", blogs);
		}

		public IActionResult Edit(long id)
		{
			ViewBag.PageName = "Edit a Question";
			Questions question = Questions.Read(id);
			return View("Question", question);
		}
	}
}