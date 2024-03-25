using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using diplom.Data;
using diplom.Models;
using Microsoft.AspNetCore.Authorization;

namespace diplom.Pages.merch
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
        public Material Material { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Material.Add(Material);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
       
       
    }
}
