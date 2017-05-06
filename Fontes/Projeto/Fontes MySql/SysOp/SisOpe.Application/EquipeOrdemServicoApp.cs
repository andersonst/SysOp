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
    public class EquipeOrdemServicoApp : AppServiceBase<EquipeOrdemServico>, IEquipeOrdemServicoAppService
    {
        private readonly IEquipeOrdemServicoService _equipeOrdemServicoService;

        public EquipeOrdemServicoApp(IEquipeOrdemServicoService equipeOrdemServicoService)
            : base(equipeOrdemServicoService)
        {
            _equipeOrdemServicoService = equipeOrdemServicoService;
        }
    }
}
