
using Microsoft.AspNetCore.Mvc;
using RunGroupApp.Data;
using RunGroupApp.Models;

namespace RunGroupApp.Controllers
{
    public class clubController : Controller
    {
       private readonly ApplicationDbContext _context;
        public clubController(ApplicationDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            List<club>  clubs  = _context.Clubs.ToList();
            return View(clubs);
        }
    }
}
