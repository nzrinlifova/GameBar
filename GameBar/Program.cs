using GameBar.DAL;
using Microsoft.EntityFrameworkCore;
using System;

namespace GameBar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(oB => oB.UseSqlServer("Server=DESKTOP-KA8SSD4;DataBase=GameBar;Trusted_Connection=True;TrustServerCertificate=True;"));
            var app = builder.Build();
            app.UseStaticFiles();
                   
            app.MapControllerRoute(
               name: "Admin",
               pattern: "{area:exists}/{controller=Dashboard}/{action=index}/{id?}");

            app.MapControllerRoute(
                name: "Default",
                pattern: "{controller=home}/{action=index}/{id?}");
            app.Run();
           
        }
    }
    

 
}
