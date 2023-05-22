using Microsoft.AspNetCore.Mvc;
using LawwlUp.Data;

namespace LawwlUp.Controllers
{
    public class GuideController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GuideController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Guides.ToList());
        }

        public IActionResult Detail(int id)
        {
            return View(_context.Guides.FirstOrDefault(guid => guid.Id == id));
        }
    }
}
