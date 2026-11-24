using GymMngementSystem.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymMangmentSystem.Controllers
{
    public class PlansController : Controller
    {

        // BaseUr1/Plans/Test
        //public IActionResult Test()
        //{
        //    return View(); // Razor Page
        //}
        public async Task<IActionResult> Index()
        {
            using GymDbContext context = new GymDbContext();

            var plans = await context.Plans.ToListAsync();

            return View(plans); // Passing Plans To The Index View

        }
    }
}