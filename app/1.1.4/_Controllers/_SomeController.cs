using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
//
using Microsoft.EntityFrameworkCore;
using <%= namespace %>.Models;
using System.Linq;
//
using Microsoft.AspNetCore.Identity;

namespace <%= namespace %>.Controllers
{
    public class SomeController : Controller
    {
        private Context _context;
 
        public SomeController(Context context)
        {
            _context = context;
        }

        //Current datetime
        public DateTime now()
        {
            DateTime now = DateTime.Now;
            return now;
        }

        public bool CheckLoggedIn()
        {
            int? id = HttpContext.Session.GetInt32("LOGGED_IN_USER");
            User LoggedIn = _context.Users.SingleOrDefault(user => user.userid == id);
            ViewBag.User = LoggedIn;
            if(ViewBag.User != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // GET: /Home/
        [HttpGet]
        [Route("/dashboard")]
        public IActionResult Index()
        {
            if(!CheckLoggedIn())
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
