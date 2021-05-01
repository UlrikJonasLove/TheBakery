using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Bageriet
{
    public class Program
    {
        public static void Main(string[] args) // main funktion som k�r applikationen
        {
            CreateHostBuilder(args).Build().Run(); // s�tter upp applikationen
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => //host i en egen lokal webserver
                {
                    webBuilder.UseStartup<Startup>(); //konfigurationerna av applikationen
                });
    }
}
