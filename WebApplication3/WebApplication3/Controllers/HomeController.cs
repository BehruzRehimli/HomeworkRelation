using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication3.DAL;
using WebApplication3.Models;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        readonly RelationDbContext _context;
        public HomeController(RelationDbContext context)
        {
            _context= context;
        }


        public IActionResult Index()
        {
            var data1=_context.Chefs.Include(x=>x.profession).Include(x=>x.Media).ToList();
            var data2=_context.Testimonials.Include(x=>x.Profession).ToList();

            ChefTestemmonialVM data = new()
            {
                Chefs=data1,
                Testemonials=data2
            };
            return View(data);
        }

        public IActionResult Details(int id)
        {
            if (id <= 0) return BadRequest();
            Chef data= _context.Chefs.Include(x => x.profession).Include(x => x.Media).ToList().Find(x=>x.Id==id);

            return View(data);

        }


    }
}