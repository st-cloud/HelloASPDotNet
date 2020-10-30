using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/welcome'>" +
                "<input type='text' name='name' />" +
                "<select name='language'> <option value='french'>French</option> <option value='english'>English</option> <option value='spanish'>Spanish</option> <option value='italian'>Italian</option> <option value='latin'>Latin</option></select>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";
            return Content(html, "text/html");
        }

        // GET
        [HttpGet("welcome/{name?}")]
        [HttpPost("welcome")]
        public IActionResult Welcome(string name = "World", string language = "english")
        {
           return Content(CreateMessage(name, language), "text/html");
        }

        public static string CreateMessage(string name, string language)
        {
            string greeting = "Hello ";

            if (language == "latin")
            {
                greeting = "Salve ";
            }
            else if (language == "french")
            {
                greeting = "Bonjour ";
            }
            else if (language == "spanish")
            {
                greeting = "Hola ";
            }
            else if (language == "italian")
            {
                greeting = "Ciao ";
            }

            string phrase = greeting + name;
            return phrase;
        }
    }
}
