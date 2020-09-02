using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Lab_11._2.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Register()
		{
			ViewBag.Message = "Welcome to the registration page.";

			return View();
		}

		public ActionResult Registered(string firstname, string lastname, DateTime birthday, string email, string phonenumber, string state, string password)
		{
			Regex validName = new Regex(@"^[A-Z][A-Za-z]{0,29}$");
			Regex validEmail = new Regex(@"^.{5,30}@\w{5,10}\.\w{2,3}$");
			Regex validPhonenumber = new Regex(@"^\({0,1}\d{3}\){0,1}[-.]\d{3}[-.]\d{4}$");

			if (validName.IsMatch(firstname) && validName.IsMatch(lastname) && validEmail.IsMatch(email) && validPhonenumber.IsMatch(phonenumber))
			{
				ViewBag.ValidRegister = "You have <b>sucessfully</b> registered!";
				ViewBag.Message = $"Welcome <b>{firstname} {lastname}</b> with a b-day on <b>{birthday.ToShortDateString()}</b>!<br />We'll spam you constantly at <b>{email}</b> and text you at <b>{phonenumber}</b>.<br />We're also going to show up at your home in <b>{state}</b>.<br />On a final note, I know your password is <b>{password}</b> so ha!";
			}
			else
			{
				ViewBag.ValidRegister = "You have <b>FAILED</b> to sucessfully register!";
				ViewBag.Message = "Please go back and <a href=\"/Home/Register\">try again!</a>";
			}



			return View();
		}

		public ActionResult TermsAndConditions()
		{
			return View();
		}
	}
}