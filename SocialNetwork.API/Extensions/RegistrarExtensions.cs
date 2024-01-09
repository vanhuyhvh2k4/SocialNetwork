using SocialNetwork.API.Registrars;

namespace SocialNetwork.API.Extensions
{
	public static class RegistrarExtensions
	{
		public static void RegisterServices(this WebApplicationBuilder builder, Type scanningType)
		{
            var registrars = GetRegistrars<IWebApplicationBuilderRegistrar>(scanningType);

            foreach (var registrar in registrars)
            {
                registrar.RegisterServices(builder);
            }
        }

		public static void RegisterPinelineComponents(this WebApplication app, Type scanningType)
		{
            var registrars = GetRegistrars<IWebApplicationRegistrar>(scanningType);
            foreach (var registrar in registrars)
            {
                registrar.RegisterPinelineComponents(app);
            }
        }

        private static IEnumerable<T> GetRegistrars<T>(Type scanningType) where T : IRegistrar
        {
            return scanningType.Assembly.GetTypes()
                .Where(t => t.IsAssignableTo(typeof(T)) && !t.IsAbstract && !t.IsInterface)
                .Select(Activator.CreateInstance)
                .Cast<T>();
        }
    }
}

