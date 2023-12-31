using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyQuickDesk.ApplicationUser;
using MyQuickDesk.DatabaseContext;
using MyQuickDesk.Entities;
using MyQuickDesk.Services;
using System.Data;

namespace MyQuickDesk
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<MyQuickDeskContext>
                (
                    option => option.UseSqlServer(builder.Configuration.GetConnectionString("MyQuickDeskConnectionString"))
                );

            builder.Services.AddDefaultIdentity<Microsoft.AspNetCore.Identity.IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<MyQuickDeskContext>();

            


            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IReservationService,ReservationService>();
            builder.Services.AddScoped<IDeskService, DeskService>();
            builder.Services.AddScoped <IRoomService, RoomService>();
            builder.Services.AddScoped <IParkingService, ParkingService>();
            builder.Services.AddScoped<IUserContext, UserContext>();
            

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

            app.MapRazorPages();

            app.Run();
        }
    }
}