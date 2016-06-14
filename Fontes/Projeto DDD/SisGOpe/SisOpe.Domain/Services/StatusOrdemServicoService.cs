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
    public class StatusOrdemServicoService : ServiceBase<StatusOrdemServico>, IStatusOrdemServicoService
    {
        private readonly IStatusOrdemServicoRepository _statusOrdemServicoRepository;

        public StatusOrdemServicoService(IStatusOrdemServicoRepository statusOrdemServicoRepository)
            :base(statusOrdemServicoRepository)
        {
            _statusOrdemServicoRepository = statusOrdemServicoRepository;
        }
    }
}
