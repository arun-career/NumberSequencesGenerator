using Generator.Business;
using Generator.Business.Core;
using Microsoft.Practices.Unity;
using System.Web.Mvc;
using Unity.Mvc5;

namespace Generator.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            CoreDependency.Register(container);

            container.RegisterInstance<IGeneratorService>(new GeneratorService(container.ResolveAll<IGenerator>()));

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}