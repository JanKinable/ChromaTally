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
    public class DetailsModel : PageModel
    {
        private readonly ChromaTally.Site.Data.ChromaTallyDbContext _context;

        public DetailsModel(ChromaTally.Site.Data.ChromaTallyDbContext context)
        {
            _context = context;
        }

        public Nutrition Nutrition { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nutrition = await _context.Nutrition.FirstOrDefaultAsync(m => m.Id == id);
            if (nutrition == null)
            {
                return NotFound();
            }
            else
            {
                Nutrition = nutrition;
            }
            return Page();
        }
    }
}
