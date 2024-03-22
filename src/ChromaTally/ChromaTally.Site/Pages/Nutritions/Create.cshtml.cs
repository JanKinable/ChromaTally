using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ChromaTally.Site.Data;
using ChromaTally.Site.Models;

namespace ChromaTally.Site.Pages.Nutrions
{
    public class CreateModel : PageModel
    {
        private readonly ChromaTally.Site.Data.ChromaTallyDbContext _context;

        public CreateModel(ChromaTally.Site.Data.ChromaTallyDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Nutrition Nutrition { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Nutrition.Add(Nutrition);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
