﻿using Microsoft.AspNetCore.Mvc;
using SlackOverload.Models;
using System.Collections.Generic;

namespace SlackOverload.Controllers
{
	public class QandAController : Controller
	{
		[HttpPost]
		public IActionResult SaveUser(string username)
		{
			HttpContext.Response.Cookies.Append("username", username);
			return Redirect("/QandA");
		}

		public IActionResult Index(string scope, string field, string search, string view)
		{
			List<Questions> questions = Questions.Read(scope, field, search);
			ViewBag.username = HttpContext.Request.Cookies["username"];
			ViewBag.category = view;
			return View(questions);
		}

		public IActionResult PageResult(long id) //display questions and associated answers
		{
			Questions question = Questions.Read(id);
			ViewBag.username = HttpContext.Request.Cookies["username"];
			return View(question);
		}

		[HttpPost]
		public IActionResult Question() //add or edit question
		{
			ViewBag.PageName = "Add a Question";
			ViewBag.username = HttpContext.Request.Cookies["username"];
			return View();
		}

		[HttpPost]
		public IActionResult SaveQuestion(long id, string username, string title, string details, string category, string tags, string status, string submit)
		{
			if (submit == "Delete")
			{
				Questions.Delete(id);
			}
			else if (id >= 1)
			{
				if (status == "on")
				{
					Questions.Update(id, username, title, details, category, tags, 1);
				}
				else
				{
					Questions.Update(id, username, title, details, category, tags, 0);
				}
			}
			else
			{
				Questions.Create(username, title, details, category, tags);
			}
			ViewBag.Message = "Your entry has been saved!";
			List<Questions> questions = Questions.Read();
			ViewBag.username = HttpContext.Request.Cookies["username"];
			return View("Index", questions);
		}

		[HttpPost]
		public IActionResult EditQuestion(long id)
		{
			ViewBag.PageName = "Edit a Question";
			Questions question = Questions.Read(id);
			ViewBag.username = HttpContext.Request.Cookies["username"];
			return View("Question", question);
		}

		[HttpPost]
		public IActionResult Upvote(long id, string vote)
		{
			Answers answer = Answers.ReadSingle(id);
			Questions question;
			if (vote == "Like")
			{
				Answers.Update(id, "upvote");
				question = Questions.Read(answer.QuestionID);
			}
			else if (vote == "Dislike")
			{
				Answers.Update(id, "downvote");
				question = Questions.Read(answer.QuestionID);
			}
			else
			{
				question = Questions.Read(answer.QuestionID);
			}
			ViewBag.username = HttpContext.Request.Cookies["username"];
			return View("PageResult", question);
		}

		[HttpPost]
		public IActionResult Answer(long questionID) //add or edit answer
		{
			ViewBag.questionID = questionID;
			ViewBag.username = HttpContext.Request.Cookies["username"];
			ViewBag.PageName = "Add an Answer";
			return View();
		}

		[HttpPost]
		public IActionResult SaveAnswer(long answerID, string username, string details, long questionID, int upvotes, string submit)
		{
			if (submit == "Save")
			{
				if (answerID >= 1)
				{
					Answers.Update(answerID, username, details, questionID, upvotes);
				}
				else
				{
					Answers.Create(username, details, questionID);
				}
			}
			else
			{
				Answers.Delete(answerID);
			}
			Questions question = Questions.Read(questionID);
			ViewBag.username = HttpContext.Request.Cookies["username"];
			return View("PageResult", question);
		}

		[HttpPost]
		public IActionResult EditAnswer(long answerID)
		{
			ViewBag.PageName = "Edit an Answer";
			Answers answer = Answers.ReadSingle(answerID);
			ViewBag.username = HttpContext.Request.Cookies["username"];
			ViewBag.questionID = answer.QuestionID;
			return View("Answer", answer);
		}
	}
}