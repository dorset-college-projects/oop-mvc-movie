using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int ID = 1)
        {
            //return "This is the Welcome action method...";

            // return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");

        }
    }
}
