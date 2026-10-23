using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Ngay2.Controllers
{
    public class HelloController : Controller
    {
        [Route("Hello")]

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }

    }
     
}
