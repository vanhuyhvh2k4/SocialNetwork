using System;

namespace SocialNetwork.API.Registrars
{
	public class MvcWebAppRegistrar : IWebApplicationRegistrar
	{
		public MvcWebAppRegistrar()
		{
		}

        public void RegisterPinelineComponents(WebApplication app)
        {
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}

