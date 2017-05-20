using SisOpe.CrossCuting.IoC.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisOpe.CtrossCuting.IoC
{
    public class IoC
    {
       

        public static void  RegisterComponents()
        {
            RepositoryUnitModule.RegisterComponents();
           // ServiceUnitModule.RegisterComponents();
           // ApplicationUnitModule.RegisterComponents();
        }
    }
}