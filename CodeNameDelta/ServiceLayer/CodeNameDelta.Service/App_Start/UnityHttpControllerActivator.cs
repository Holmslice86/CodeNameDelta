using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace CodeNameDelta.Service.App_Start
{
    public class UnityHttpControllerActivator : IHttpControllerActivator
    {
        private readonly IUnityContainer _container;

        public UnityHttpControllerActivator(IUnityContainer container)
        {
            _container = container;
        }

        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            var childContainer = _container.CreateChildContainer();
            var iden = Thread.CurrentPrincipal as ClaimsPrincipal;
            //childContainer.RegisterInstance(typeof(NucleusUserIdentity), new NucleusUserIdentity(iden));

            return (IHttpController)childContainer.Resolve(controllerType);
        }
    }
}
