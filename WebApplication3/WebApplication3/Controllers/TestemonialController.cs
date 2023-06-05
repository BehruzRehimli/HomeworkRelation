using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.DAL;

namespace WebApplication3.Controllers
{
    public class TestemonialController : Controller
    {
        readonly RelationDbContext _context;
        public TestemonialController(RelationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TestDetails(int id) {
            var data=_context.Testimonials.Include(x=>x.Profession).ToList().Find(x=>x.Id==id);

            return View(data);
        }
    }
}
