using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using diplom.Data;
using diplom.Models;

namespace diplom.Pages.basket
{
    public class CreateModel : PageModel
    {
        private readonly diplom.Data.diplomContext _context;

        public CreateModel(diplom.Data.diplomContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Basket Basket { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Basket.Add(Basket);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
