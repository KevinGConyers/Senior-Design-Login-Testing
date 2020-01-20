using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MovieBase.Controllers
{
    public class HelloWorldController : Controller 
    {
        //
        //GET: /HelloWorld/

        public IActionResult Index() {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1) 
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

        public string echoName (string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is : {numTimes}");
        }

        public string id(string name, int ID=1)
        {
            return HtmlEncoder.Default.Encode($"Hello, {name}, ID: {ID}");
        }
    }
}