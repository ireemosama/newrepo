using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class sController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
