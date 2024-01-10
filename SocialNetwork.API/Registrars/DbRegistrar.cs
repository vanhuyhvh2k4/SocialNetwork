using System;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Infrashstructure;

namespace SocialNetwork.API.Registrars
{
    public class DbRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            var cs = builder.Configuration.GetConnectionString("Default");

            builder.Services.AddDbContext<DataContext>(options => options.UseMySql(cs, new MySqlServerVersion(new Version(10, 4, 25))));
        }
    }
}

