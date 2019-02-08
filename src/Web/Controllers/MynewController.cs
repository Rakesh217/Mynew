using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class MynewController : Controller
    {
        public IActionResult text()
        {
            return Content("Welcome Bearcats!!");
        }

        public IActionResult JSON()
        {
             return  Json(new {name="Quote", quote="Be Lazy and Thik Crazy!!"});
        }

        public IActionResult HTML(){
            return Content("<!DOCTYPE html><html><body>Good Morning</body></html>", "text/html");
        }
		
        public IActionResult Contact(){
            return View();
        }
    }
}
