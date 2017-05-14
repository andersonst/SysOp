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
    public class Ecf_ConfiguracaoService : ServiceBase<Ecf_Configuracao>, IEcf_ConfiguracaoService
    {
        private readonly IEcf_ConfiguracaoRepository _ecf_ConfiguracaoRepository;

        public Ecf_ConfiguracaoService(IEcf_ConfiguracaoRepository ecf_ConfiguracaoRepository)
            : base(ecf_ConfiguracaoRepository)
        {
            _ecf_ConfiguracaoRepository = ecf_ConfiguracaoRepository;
        }
    }
}
