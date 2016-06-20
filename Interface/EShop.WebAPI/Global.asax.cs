using SimpleInjector; 
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Web; 
using System.Web.Http; 
using System.Web.Routing; 
using EShop.Business.IRepositories;
using EShop.Business.Repositories; 
using SimpleInjector.Integration.WebApi;
using EShop.Business.IRepositories.IProduct;
using EShop.Business.Repositories.Product; 


namespace EShop.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            // Create the container as usual. 
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();


            container.Register<IProductRepository, ProductRepository>(Lifestyle.Scoped);
            container.Register<IProductService, ProductService>(Lifestyle.Scoped);

            // This is an extension method from the integration package. 
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);


            container.Verify();


            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);

        }
    }
}