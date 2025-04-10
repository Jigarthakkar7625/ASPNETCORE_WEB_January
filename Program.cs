using ASPNETCORE_WEB.Models;
using Microsoft.EntityFrameworkCore;
using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Connection string 
var conn = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AtcgsaWithoutAspnetauthContext>(x => x.UseSqlServer(conn));


builder.Services.AddTransient<ITransient, DependancyInjection>(); // AddTransient DI

builder.Services.AddScoped<IScoped, DependancyInjection>(); // AddScoped DI

builder.Services.AddSingleton<ISingleton, DependancyInjection>(); // AddSingleton DI

var app = builder.Build();


// SQL (Connection string) + EF >>

//.Net 5 >> Program.cs and Startup.cs

//.Net 6 >> Program.cs



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles(); //Only accessable wwwroot

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
