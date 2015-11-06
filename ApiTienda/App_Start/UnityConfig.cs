using Microsoft.Practices.Unity;
using System.Web.Http;
using Microsoft.Practices.ObjectBuilder2;
using Unity.WebApi;

namespace ApiTienda
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.


            // e.g. container.RegisterType<ITestService, TestService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }

}