using LawwlUp.Data;
using Microsoft.AspNetCore.Mvc;

namespace LawwlUp.Controllers
{
    public class PassedTestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PassedTestController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Tests = _context.PassedTests.ToList();
            return View(Tests);
        }
    }
}
