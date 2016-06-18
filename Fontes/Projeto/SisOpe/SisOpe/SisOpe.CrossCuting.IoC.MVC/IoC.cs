using Ninject;
using SisOpe.CrossCuting.IoC.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisOpe.CrossCuting.IoC
{
    public class IoC
    {
        public IKernel Kernel { get; private set; }

        public IoC()
        {
            Kernel = GetNinjectModules();
            //ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(Kernel));
            //ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(Kernel));
        }

        public StandardKernel GetNinjectModules()
        {
            return new StandardKernel(
                new RepositoryModuleNinject(),
                new ServiceModuleNinject(),
                new ApplicationModuleNinject());
        }
    }
}