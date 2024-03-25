using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class saraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
