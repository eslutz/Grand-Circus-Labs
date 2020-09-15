using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapper.Contrib.Extensions;
using Dapper;
using System.Data;
using System.Data.SqlClient;


namespace SlackOverload.Controllers
{
    //dude
    public class QandAController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
