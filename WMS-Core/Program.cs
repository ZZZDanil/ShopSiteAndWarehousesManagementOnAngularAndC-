using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WMS_Core.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});


builder.Services.AddDbContext<ApplicationContext>( options => 
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCors();

app.UseAuthorization();

/*
app.MapControllerRoute(
    name: "info",
    pattern: "contact/info",
    defaults: new { controller = "Home", action = "TestData" });
*/
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();     // нет определенных маршрутов
});

app.Run();

