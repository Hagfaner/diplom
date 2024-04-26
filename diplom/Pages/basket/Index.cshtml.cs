using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using diplom.Data;
using diplom.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace diplom.Pages.basket
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public readonly diplom.Data.diplomContext _context;
        private readonly UserManager<User> userManager;
        public User? user;
        public IList<Material> Material { get; set; } = default!;
        public IndexModel(diplom.Data.diplomContext context, UserManager<User> userManager)
        {
            this.userManager = userManager;
            _context = context;
        }

        public IList<Basket> Basket { get; set; } = default!;

        [BindProperty]
        public Basket basket_buf { get; set; } = default!;
     

        public async Task OnGetAsync()
        {
            Basket = await _context.Basket.ToListAsync();
            var task = userManager.GetUserAsync(User);
            task.Wait();
            user = task.Result;
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
                basket_buf = basket;
                _context.Basket.Remove(basket_buf);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}