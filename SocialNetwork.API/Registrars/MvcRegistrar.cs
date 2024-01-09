using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace SocialNetwork.API.Registrars
{
	public class MvcRegistrar : IWebApplicationBuilderRegistrar
	{
		public MvcRegistrar()
		{
		}

        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();

            // config api version
            builder.Services.AddVersionedApiExplorer(config =>
            {
                config.GroupNameFormat = "'v'VVV";
                config.SubstituteApiVersionInUrl = true;
            });

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
                config.ApiVersionReader = new UrlSegmentApiVersionReader();
            });
        }
    }
}

