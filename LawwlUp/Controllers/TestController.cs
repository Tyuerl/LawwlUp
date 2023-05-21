using LawwlUp.Data;
using Microsoft.AspNetCore.Mvc;

namespace LawwlUp.Controllers
{
    public class TestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Tests = _context.Tests.ToList();
            return View(Tests);
        }
    }
}
