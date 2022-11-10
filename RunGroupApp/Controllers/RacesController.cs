using Microsoft.AspNetCore.Mvc;

namespace RunGroupApp.Controllers
{
    public class RacesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
