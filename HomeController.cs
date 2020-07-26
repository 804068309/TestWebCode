using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using javax.jws;
using Logic;
using Microsoft.AspNetCore.Mvc;
using RIP.Basics;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestWebCode
{
    public class HomeController : BaseController
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public string GetSqlTest()
        {
            UserLogic user = new UserLogic();
            var name = user.GetTest();
            return name;
        }
    }
}
