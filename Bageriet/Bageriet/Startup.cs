using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Bageriet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;

namespace Bageriet
{
    public class Startup //Konfigurerar applikationen
    {
        public IConfiguration Configuration { get; } //Används för databasen
        public Startup(IConfiguration configuration) // Detta är en konstruktor
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) //metod
        { 
            /* registrerar services/tjänster genom Dependency injection
            instanser av olika klasser skapas här */
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))); //GetConnectionString hämtar info från appsettings.json filen
            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>(); //identifierings funktion
            /* registrerar och konfigurerar även databasen, i detta fall entity framework.
              AppDbContext är en modelklass för databasen
            */


            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
            services.AddHttpContextAccessor();
            services.AddSession();
            services.AddControllersWithViews(); // lägger till stöd för MVC
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //Detta kallas för middlewear och måste läggas till i rätt ordning
            app.UseHttpsRedirection(); // hämtar stöd för HttpRedirection, http.request omdirigeras
            app.UseStaticFiles(); // hämtar stöd för statiska filer, css, javascript osv. Som finns i mappen wwwroot
            app.UseSession(); 

            app.UseRouting(); // hämtar stöd för Routing, dvs kunna navigera genom hemsidan.
            app.UseAuthentication(); // hämtar stöd för authentication, för identifiering och inloggning
            app.UseAuthorization(); // hämtar stöd för authorization, för att kunna göra så man måste tillexempel vara inloggad för att skriva kommentarer.

            app.UseEndpoints(endpoints =>
            {
            
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"); // Standard när man startar applikationen, Home Controller med index-action, alltså start-sidan. Kan byta default till en annan start sida. 
                endpoints.MapRazorPages();   //endpoints för indentiferingsfunktioner                                                           // {id?} innebär att id är ett fritt option, pga frågetecknet. Annars hade de varit obligatoriskt med ett ID i url.
            });
        }
    }
}
