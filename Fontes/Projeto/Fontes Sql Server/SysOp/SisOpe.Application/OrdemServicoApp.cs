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
    public class OrdemServicoApp : AppServiceBase<OrdemServico>, IOrdemServicoAppService
    {
        private readonly IOrdemServicoService _ordemServicoService;

        public OrdemServicoApp(IOrdemServicoService ordemServicoService)
            : base(ordemServicoService)
        {
            _ordemServicoService = ordemServicoService;
        }
    }
}
