using System;
namespace SocialNetwork.API.Registrars
{
	public interface IWebApplicationBuilderRegistrar
	{
		void RegisterServices(WebApplicationBuilder builder);
	}
}

