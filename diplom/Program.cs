using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using diplom.Data;
using Microsoft.AspNetCore.Identity;
using diplom.Models;
using diplom;
using Microsoft.Extensions.Options;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<diplomContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("diplomContext") ?? throw new InvalidOperationException("Connection string 'diplomContext' not found.")));
builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = false).AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<diplomContext>()
    .AddErrorDescriber<AppErrorDescriber>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
