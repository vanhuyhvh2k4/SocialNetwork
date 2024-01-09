using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace SocialNetwork.API.Registrars
{
	public class SwaggerWebAppRegistrar : IWebApplicationRegistrar
	{
		public SwaggerWebAppRegistrar()
		{
		}

        public void RegisterPinelineComponents(WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

                foreach (var description in provider.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.ApiVersion.ToString());
                }
            });
        }
    }
}

