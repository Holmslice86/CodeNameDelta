using CodeNameDelta.Domain.Interfaces;
using CodeNameDelta.DomainService;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeNameDelta.Service
{
    public class Bootstrapper
    {
        public static IUnityContainer Initialize()
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        }

        private static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IAchievementService, AchievementService>();
        }
    }
}
