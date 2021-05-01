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
        public IConfiguration Configuration { get; } //Anv�nds f�r databasen
        public Startup(IConfiguration configuration) // Detta �r en konstruktor
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) //metod
        { 
            /* registrerar services/tj�nster genom Dependency injection
            instanser av olika klasser skapas h�r */
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))); //GetConnectionString h�mtar info fr�n appsettings.json filen
            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>(); //identifierings funktion
            /* registrerar och konfigurerar �ven databasen, i detta fall entity framework.
              AppDbContext �r en modelklass f�r databasen
            */


            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
            services.AddHttpContextAccessor();
            services.AddSession();
            services.AddControllersWithViews(); // l�gger till st�d f�r MVC
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //Detta kallas f�r middlewear och m�ste l�ggas till i r�tt ordning
            app.UseHttpsRedirection(); // h�mtar st�d f�r HttpRedirection, http.request omdirigeras
            app.UseStaticFiles(); // h�mtar st�d f�r statiska filer, css, javascript osv. Som finns i mappen wwwroot
            app.UseSession(); 

            app.UseRouting(); // h�mtar st�d f�r Routing, dvs kunna navigera genom hemsidan.
            app.UseAuthentication(); // h�mtar st�d f�r authentication, f�r identifiering och inloggning
            app.UseAuthorization(); // h�mtar st�d f�r authorization, f�r att kunna g�ra s� man m�ste tillexempel vara inloggad f�r att skriva kommentarer.

            app.UseEndpoints(endpoints =>
            {
            
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"); // Standard n�r man startar applikationen, Home Controller med index-action, allts� start-sidan. Kan byta default till en annan start sida. 
                endpoints.MapRazorPages();   //endpoints f�r indentiferingsfunktioner                                                           // {id?} inneb�r att id �r ett fritt option, pga fr�getecknet. Annars hade de varit obligatoriskt med ett ID i url.
            });
        }
    }
}
