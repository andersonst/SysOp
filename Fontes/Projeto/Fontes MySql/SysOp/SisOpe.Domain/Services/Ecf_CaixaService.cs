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
    public class Ecf_CaixaService : ServiceBase<Ecf_Caixa>, IEcf_CaixaService
    {
        private readonly IEcf_CaixaRepository _ecf_CaixaRepository;

        public Ecf_CaixaService(IEcf_CaixaRepository ecf_CaixaRepository)
            : base(ecf_CaixaRepository)
        {
            _ecf_CaixaRepository = ecf_CaixaRepository;
        }
    }
}
