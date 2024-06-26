﻿using System;
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

namespace diplom.Pages.merch
{
    [Authorize]
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        private readonly diplom.Data.diplomContext _context;
        private readonly UserManager<User> userManager;
        public User? user;

        public IndexModel(diplom.Data.diplomContext context, UserManager<User> userManager)
        {
            this.userManager = userManager;
            _context = context;
        }

        public IList<Material> Material { get;set; } = default!;

        
        public async Task OnGetAsync()
        {
            var task = userManager.GetUserAsync(User);
            task.Wait();
            user = task.Result;
            Material = await _context.Material.ToListAsync();
        }
        [BindProperty]
        public Basket Basket { get; set; } = default!;
        public async Task<IActionResult> OnPostAsync()
        {
            if (_context.Basket.Where(c => c.Id_material == Basket.Id_material && c.Id_user == Basket.Id_user).Any())
            {
                _context.Basket.First(c => c.Id_material == Basket.Id_material && c.Id_user == Basket.Id_user).Count++;
            }
            else
            {
            Basket.Count ++;
            _context.Basket.Add(Basket);
            }
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");

        }
    }
}
