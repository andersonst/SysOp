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
    public class Ecf_ResolucaoService : ServiceBase<Ecf_Resolucao>, IEcf_ResolucaoService
    {
        private readonly IEcf_ResolucaoRepository _ecf_ResolucaoRepository;

        public Ecf_ResolucaoService(IEcf_ResolucaoRepository ecf_ResolucaoRepository)
            : base(ecf_ResolucaoRepository)
        {
            _ecf_ResolucaoRepository = ecf_ResolucaoRepository;
        }
    }
}
