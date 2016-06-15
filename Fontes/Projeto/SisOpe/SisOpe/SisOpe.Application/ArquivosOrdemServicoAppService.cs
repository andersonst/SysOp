using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Repositories;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
