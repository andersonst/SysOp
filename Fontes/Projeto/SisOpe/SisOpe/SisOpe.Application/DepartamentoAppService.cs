using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Services;

namespace SisOpe.Application
{
    public class DepartamentoAppService : AppServiceBase<Departamento>, IDepartamentoAppService
    {
        private readonly IDepartamentoService _departamentoService;

        public DepartamentoAppService(IDepartamentoService departamentoService)
            :base(departamentoService)
        {
            _departamentoService = departamentoService;
        }
    }
}
