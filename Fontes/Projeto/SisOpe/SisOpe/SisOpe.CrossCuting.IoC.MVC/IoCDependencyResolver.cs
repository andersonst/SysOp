using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SisOpe.CrossCuting.IoC
{
    public class IoCDependencyResolver : IDependencyResolver
    {

        private readonly IKernel _kernel;


        public IoCDependencyResolver()
        {
            var ioc = new IoC();
            _kernel = ioc.Kernel;
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }
    }
}