using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Services;

namespace SisOpe.Application
{
    public class ArquivosOrdemServicoAppService : AppServiceBase<ArquivosOrdemServico>, IArquivosOrdemServicoAppService
    {
        private readonly IArquivosOrdemServicoService _arquivosOrdemServicoService;

        public ArquivosOrdemServicoAppService(IArquivosOrdemServicoService arquivosOrdemServicoService)
            : base(arquivosOrdemServicoService)
        {
            _arquivosOrdemServicoService = arquivosOrdemServicoService;
        }


    }
}
