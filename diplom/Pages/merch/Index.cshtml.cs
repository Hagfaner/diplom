using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using diplom.Data;
using diplom.Models;

namespace diplom.Pages.merch
{
    public class IndexModel : PageModel
    {
        private readonly diplom.Data.diplomContext _context;

        public IndexModel(diplom.Data.diplomContext context)
        {
            _context = context;
        }

        public IList<Material> Material { get;set; } = default!;
        
        public async Task OnGetAsync()
        {
            Material = await _context.Material.ToListAsync();
        }
    }
}
