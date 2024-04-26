using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using diplom.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace diplom.Data
{
    public class diplomContext : IdentityDbContext<User>
    {
        public diplomContext (DbContextOptions<diplomContext> options)
            : base(options)
        {
        }

        public DbSet<diplom.Models.Material> Material { get; set; } = default!;
      
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            //builder.Entity<Basket>().HasKey(vf => new { vf.Id_material, vf.Id_user });

            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";

            var user = new IdentityRole("user");
            user.NormalizedName = "user";

            builder.Entity<IdentityRole>().HasData(admin, user);
        }
        public DbSet<diplom.Models.Basket> Basket { get; set; } = default!;
       
    }
}
