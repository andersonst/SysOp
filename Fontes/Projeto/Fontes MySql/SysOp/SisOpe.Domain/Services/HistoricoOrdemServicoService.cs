using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Repositories;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Domain.Services
{
    public class HistoricoOrdemServicoService : ServiceBase<HistoricoOrdemServico>, IHistoricoOrdemServicoService
    {
        private readonly IHistoricoOrdemServicoRepository _historicoOrdemServicoRepository;

        public HistoricoOrdemServicoService(IHistoricoOrdemServicoRepository historicoOrdemServicoRepository)
            : base(historicoOrdemServicoRepository)
        {
            _historicoOrdemServicoRepository = historicoOrdemServicoRepository;
        }
    }
}
