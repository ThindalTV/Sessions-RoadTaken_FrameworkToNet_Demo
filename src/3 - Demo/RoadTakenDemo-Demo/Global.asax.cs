using System;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;

// This one is weird. It's under Microsoft.AspNet.MVC/Lib/net45 and is downloaded, but it's not available, needs to be manually linked.
using System.Web.Mvc;


namespace RoadTakenDemoTemplate
{
    public class Global : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
        {
            // Code that runs on application startup
            base.OnApplicationStarted();
            
            SetupMVC();
        }

        #region MVC
        private static void SetupMVC()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(c => { c.MapHttpAttributeRoutes(); });
            RegisterRoutes(RouteTable.Routes);
        }

        private static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("*.aspx");
        }
        #endregion

        #region Dependency Injection
        private static void RegisterServices(IKernel kernel)
        {
            // IHttpClientFactory isn't available in .NET Framework
            kernel.Bind<HttpClient>().To<HttpClient>().InTransientScope();
        }
        #endregion

        #region Ninject Setup
        public static IKernel NinjectKernel { get; private set; }

        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);
                NinjectKernel = kernel;
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }
        #endregion
    }
}