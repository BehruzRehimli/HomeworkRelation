
using Microsoft.EntityFrameworkCore;
using WebApplication3.DAL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RelationDbContext>(opt=>opt.UseSqlServer("Server=LAPTOP-RJLDMUKC\\SQLEXPRESS;Database=HomeworkRelations;Integrated Security=true"));

var app = builder.Build();



app.UseStaticFiles();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
