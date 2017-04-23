using SisOpe.CrossCuting.IoC.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.CrossCuting.IoC
{
    public class IoC
    {
        public IoC()
        {
            RepositoryUnitModule.RegisterComponents();
            ServiceUnitModule.RegisterComponents();
            ApplicationUnitModule.RegisterComponents();           
            
        }
        
        
    }
}
