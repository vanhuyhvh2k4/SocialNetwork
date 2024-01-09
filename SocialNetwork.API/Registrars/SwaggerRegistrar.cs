using SocialNetwork.API.Options;

namespace SocialNetwork.API.Registrars
{
    public class SwaggerRegistrar : IWebApplicationBuilderRegistrar
    {
        public SwaggerRegistrar()
        {
        }

        public void RegisterServices(WebApplicationBuilder builder)
        {

            builder.Services.AddSwaggerGen();

            builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
        }
    }
}

