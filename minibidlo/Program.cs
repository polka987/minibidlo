using Microsoft.EntityFrameworkCore;
using minibidlo.Models;


var builder = WebApplication.CreateBuilder(args);

// Добавление строки подключения к базе данных

// Добавление контроллеров и представлений
builder.Services.AddDbContext<WindowShopContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WindowShopDb")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Настройка конвейера обработки HTTP-запросов
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Home}/{id?}");

app.Run();
