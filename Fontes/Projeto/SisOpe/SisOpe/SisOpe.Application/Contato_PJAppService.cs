using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Services;

namespace SisOpe.Application
{
    public class Contato_PJAppService : AppServiceBase<Contato_PJ>, IContato_PJAppService
    {
        private readonly IContato_PJService _contato_PJService;

        public Contato_PJAppService(IContato_PJService contato_PJService)
            : base(contato_PJService)
        {
            _contato_PJService = contato_PJService;
        }
    }
}
