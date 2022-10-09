using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperLig.Data;

namespace AspNetCoreBlog.ViewComponents
{
    public class Categories : ViewComponent  //.net core da bulunan component yapısını ViewComponent sınıfından miras alarak bu şekilde kullanabiliyoruz.
    {
        private readonly DatabaseContext _context;

        public Categories(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.Categories.ToListAsync());
        }
    }
}
