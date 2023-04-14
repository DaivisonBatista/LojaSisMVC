using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using LojaSisMVC.Data;
using System.Configuration;
using Microsoft.AspNetCore.Hosting;


var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration.GetConnectionString("LojaSisMVCContext"); // Conecção com Context
var serverversion = new MySqlServerVersion( new Version(8, 0, 31)); // avisa a versão que está o MySql

builder.Services.AddDbContext<LojaSisMVCContext>(options => options.UseMySql(connString, serverversion, builder => builder.MigrationsAssembly("LojaSisMVC")));

builder.Services.AddScoped<SeedingService>();
// Add services to the container.
builder.Services.AddControllersWithViews();

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
