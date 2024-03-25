using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class SeraviaController : Controller
    {
        // GET: SeraviaController
        public ActionResult Index()
        {
            return View();
        }
        public IActionResult index2()
        {
            return Content("hello again");
        }


    }
}
