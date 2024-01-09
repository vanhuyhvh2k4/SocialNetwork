namespace SocialNetwork.API.Registrars
{
	public interface IWebApplicationBuilderRegistrar : IRegistrar
	{
		void RegisterServices(WebApplicationBuilder builder);
	}
}

