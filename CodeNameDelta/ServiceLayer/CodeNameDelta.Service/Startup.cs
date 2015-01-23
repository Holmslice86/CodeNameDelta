using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(CodeNameDelta.Service.Startup))]

namespace CodeNameDelta.Service
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var bootstrap = Bootstrapper.Initialize();
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
