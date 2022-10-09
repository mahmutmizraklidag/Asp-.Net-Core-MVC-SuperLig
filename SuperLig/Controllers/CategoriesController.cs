using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperLig.Data;

namespace SuperLig.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly DatabaseContext _context;

        public CategoriesController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync(int id)
        {
            var categories =await _context.Categories.Include(p=>p.Leagues).Include(t=>t.Teams).FirstOrDefaultAsync(c=>c.Id==id);
            return View(categories);
        }
    }
}
