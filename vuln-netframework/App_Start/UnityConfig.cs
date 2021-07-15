using DI.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

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
            container.RegisterType<IServerSideRequestForgeryService, ServerSideRequestForgeryService>();

            container.RegisterType<IDummyService, DummyService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}