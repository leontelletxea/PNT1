using Microsoft.EntityFrameworkCore;
using MVC_basico.Context;

var builder = WebApplication.CreateBuilder(args);

//referencia al contexto de la base de datos
builder.Services.AddDbContext<CineDatabaseContext>(
                      options => options.UseSqlServer(builder.Configuration["ConnectionString:EntradaDBConnection"]));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
