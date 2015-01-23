using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeNameDelta.Service.App_Start
{
    public class UnityLazyInit
    {
        private static Lazy<IUnityContainer> _lazyContainer = new Lazy<IUnityContainer>(() => Bootstrapper.Initialize(), isThreadSafe: true);

        public static IUnityContainer Container
        {
            get { return _lazyContainer.Value; }
        }
    }
}
