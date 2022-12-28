using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using User_Api.Web.Repository;

namespace User_Api.Test
{
    public class TestingWebAppFactory<TEntryPoint> : WebApplicationFactory<Program> where TEntryPoint : Program
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<UserContext>));
                if (descriptor != null) services.Remove(descriptor);

                services.AddEntityFrameworkInMemoryDatabase().AddDbContext<UserContext>(options => 
                {
                    options.UseInMemoryDatabase("InMemoryUserTest");
                });

                var sp = services.BuildServiceProvider();
                var scope = sp.CreateScope();

                var appContext = scope.ServiceProvider.GetRequiredService<UserContext>();
                appContext.Database.EnsureCreated();

            });
        }
    }
}