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
    public class Ecf_OperadorService : ServiceBase<Ecf_Operador>, IEcf_OperadorService
    {
        private readonly IEcf_OperadorRepository _ecf_OperadorRepository;

        public Ecf_OperadorService(IEcf_OperadorRepository ecf_OperadorRepository)
            : base(ecf_OperadorRepository)
        {
            _ecf_OperadorRepository = ecf_OperadorRepository;
        }
    }
}
