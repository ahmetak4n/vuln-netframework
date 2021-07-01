using System.Web.Http;
using Unity;
using Unity.WebApi;
using DI.Services;

namespace vuln_netframework
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IInsecureDeserializationService, InsecureDeserializationService>();
            container.RegisterType<IOsCommandInjectionService, OsCommandInjectionService>();
            container.RegisterType<IRegularExpressionService, RegularExpressionService>();
            container.RegisterType<ISqlInjectionService, SqlInjectionService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}