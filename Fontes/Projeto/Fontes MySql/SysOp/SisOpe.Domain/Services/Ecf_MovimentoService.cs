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
    public class Ecf_MovimentoService : ServiceBase<Ecf_Movimento>, IEcf_MovimentoService
    {
        private readonly IEcf_MovimentoRepository _ecf_MovimentoRepository;

        public Ecf_MovimentoService(IEcf_MovimentoRepository ecf_MovimentoRepository)
            : base(ecf_MovimentoRepository)
        {
            _ecf_MovimentoRepository = ecf_MovimentoRepository;
        }
    }
}
