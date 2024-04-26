using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using diplom.Data;
using diplom.Models;

namespace diplom.Pages.basket
{
    public class DeleteModel : PageModel
    {
        private readonly diplom.Data.diplomContext _context;

        public DeleteModel(diplom.Data.diplomContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Basket Basket { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basket = await _context.Basket.FirstOrDefaultAsync(m => m.Id == id);

            if (basket == null)
            {
                return NotFound();
            }
            else
            {
                Basket = basket;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basket = await _context.Basket.FindAsync(id);
            if (basket != null)
            {
                Basket = basket;
                _context.Basket.Remove(Basket);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
