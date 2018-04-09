using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace dojoSurvey.Controllers
{
    public class dojoSurveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
                return View("index");
        }
        [HttpPost]
        [Route("method")]
        public IActionResult results(string name, string loc, string lang, string comments)
        {
                ViewBag.Test = "Test?";
                ViewBag.name = name;
                ViewBag.loc = loc;
                ViewBag.lang = lang;
                ViewBag.comments = comments;
                return View();
        }
        // [HttpGet]
        // [Route("results")]
        // public IActionResult results()
        // {
        //         ViewBag.Test = "Test?";
                
        //         return View();
        // }
    }
}