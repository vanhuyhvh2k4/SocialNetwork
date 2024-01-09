using System;
namespace SocialNetwork.API.Registrars
{
    public interface IWebApplicationRegistrar
    {
        public void RegisterPinelineComponents(WebApplication app);
    }
}

