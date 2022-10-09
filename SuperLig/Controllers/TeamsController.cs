using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperLig.Data;

namespace SuperLig.Controllers
{
    public class TeamsController : Controller
    {
        private readonly DatabaseContext _context;

        public TeamsController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> DetailAsync(int id)
        {
            var team =await _context.Team.Include(p=>p.Players).FirstOrDefaultAsync(c=>c.Id==id);
            return View(team);
        }
    }
}
