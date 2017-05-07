using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Application.Interfaces;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Application
{
    public class DepartamentoApp : AppServiceBase<Departamento>, IDepartamentoAppService
    {
        private readonly IDepartamentoService _departamentoService;

        public DepartamentoApp(IDepartamentoService departamentoService)
            :base(departamentoService)
        {
            _departamentoService = departamentoService;
        }
    }
}
