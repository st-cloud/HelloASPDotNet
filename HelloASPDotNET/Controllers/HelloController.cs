using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//LC version via views-starter:
namespace HelloASPDotNET.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/hello")]
        public IActionResult Welcome(string name = "World")
        {
            ViewBag.person = name;
            return View();
        }
    }
}


//version I tried to make based on their starter code (web page loaded blank):

//namespace HelloASPDotNET.Controllers
//{
//    [Route("/helloworld")]
//    public class HelloController : Controller
//    {
//        // GET: /<controller>/
//        [HttpGet]
//        public IActionResult Index()
//        {
//            //string html = "<form method='post' action='/helloworld/welcome'>" +
//            return View();
//        }

//        // GET
//        //[HttpGet("welcome/{name?}")]
//        //[HttpPost("welcome")]
//        [HttpPost]
//        [Route("/hello")]
//        public IActionResult Welcome(string name = "World", string language = "english")
//        {
//           return Content(CreateMessage(name, language), "text/html");
//        }

//        public static string CreateMessage(string name, string language)
//        {
//            string greeting = "Hello ";

//            if (language == "latin")
//            {
//                greeting = "Salve ";
//            }
//            else if (language == "french")
//            {
//                greeting = "Bonjour ";
//            }
//            else if (language == "spanish")
//            {
//                greeting = "Hola ";
//            }
//            else if (language == "italian")
//            {
//                greeting = "Ciao ";
//            }

//            string phrase = greeting + name;
//            return phrase;
//        }
//    }
//}
