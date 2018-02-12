using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Helix.Foundation.Ioc.Extensions;

namespace Helix.Foundation.Ioc.Infrastructure
{
    public class MvcControllerServicesConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMvcControllers("*.Feature.*");
            serviceCollection.AddMvcControllers("*.Foundation.*");
            serviceCollection.AddClassesWithServiceAttribute("*.Feature.*");
            serviceCollection.AddClassesWithServiceAttribute("*.Foundation.*");
        }
    }
}