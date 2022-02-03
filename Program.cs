using Microsoft.EntityFrameworkCore;
using xbox_ps_mvc_project.Database;
using xbox_ps_mvc_project.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IGamesService, GamesService>();

builder.Services.AddDbContext<AppDbContext>(
    config => config.UseSqlServer(builder.Configuration.GetConnectionString("Application"))
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
