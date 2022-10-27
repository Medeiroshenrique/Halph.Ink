using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebCRUDMVCSQL.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Contexto>
    (options => options.UseSqlServer
("Data Source=DESKTOP-S68PG1C;Initial Catalog=halphinkdb; Integrated Security= False; User ID=sa;Password=Senha123#@!;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"));
//("Data Source=DESKTOP-S68PG1C;Initial Catalog=halphinkdb;Integrated Security=True"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
