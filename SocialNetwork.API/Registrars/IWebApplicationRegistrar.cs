namespace SocialNetwork.API.Registrars
{
    public interface IWebApplicationRegistrar : IRegistrar
    {
        public void RegisterPinelineComponents(WebApplication app);
    }
}

