using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ChromaTally.Site.Data;
using ChromaTally.Site.Models;

namespace ChromaTally.Site.Pages.Nutrions
{
    public class IndexModel : PageModel
    {
        private readonly ChromaTally.Site.Data.ChromaTallyDbContext _context;

        public IndexModel(ChromaTally.Site.Data.ChromaTallyDbContext context)
        {
            _context = context;
        }

        public IList<Nutrition> Nutrition { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Nutrition = await _context.Nutrition.ToListAsync();
        }
    }
}
