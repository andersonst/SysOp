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
    public class OrdemServicoService : ServiceBase<OrdemServico>, IOrdemServicoService
    {
        private readonly IOrdemServicoRepository _ordemServicoRepository;

        public OrdemServicoService(IOrdemServicoRepository ordemServicoRepository)
            : base(ordemServicoRepository)
        {
            _ordemServicoRepository = ordemServicoRepository;
        }
    }
}
