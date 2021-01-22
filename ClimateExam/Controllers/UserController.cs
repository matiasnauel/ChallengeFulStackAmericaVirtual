using ClimateExam.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClimateExam.Controllers
{
    public class UserController : Controller
    {
        public ChallengeDevelopmentContext _context;

        public UserController(ChallengeDevelopmentContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult  GetUser(string NameUser, string password)
        {
            var User = _context.User.Where(s => s.NameUser ==  NameUser && s.Password == password);
            if (User.Any())
            {
                if (User.Where(s => s.NameUser == NameUser && s.Password == password).Any())
                {
                    return Json(new{status = true, message = "Welcome"});
                }   
                else
                {
                    return Json(new { status = false, message = "incorrect password" });
                }
            }
            else
            {
                return Json(new { status = false, message = "Wrong user" });
            }
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
