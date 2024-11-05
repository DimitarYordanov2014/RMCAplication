using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RMCAplication.Data;
using RMCAplication.Data.Models;
using RMCAplication.Data.Repository;
using RMCAplication.Data.Repository.Interfaces;
using RMCAplication.Services.Mapping;
using RMCAplication.ViewModels;

namespace RMCAplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<RMCApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            })
                .AddEntityFrameworkStores<RMCApplicationDbContext>();
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IRepository<Warehouse, int>, Repository<Warehouse, int>>();
                       
            var app = builder.Build();

            AutoMapperConfig.RegisterMappings(typeof(ErrorViewModel).Assembly);

            //============== Reset database and seed data =============
            //using (var scope = app.Services.CreateScope())
            //{
            //    var service = scope.ServiceProvider;
            //    var context = service.GetService<RMCApplicationDbContext>();
            //    ResetDatabase(context);
            //}



            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
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
        static void ResetDatabase(RMCApplicationDbContext dbContext)
        {
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
        }
    }
}
