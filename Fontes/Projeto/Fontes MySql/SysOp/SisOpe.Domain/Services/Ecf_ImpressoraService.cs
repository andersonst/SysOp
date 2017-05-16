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
    public class Ecf_ImpressoraService : ServiceBase<Ecf_Impressora>, IEcf_ImpressoraService
    {
        private readonly IEcf_ImpressoraRepository _ecf_ImpressoraRepository;

        public Ecf_ImpressoraService(IEcf_ImpressoraRepository ecf_ImpressoraRepository)
            : base(ecf_ImpressoraRepository)
        {
            _ecf_ImpressoraRepository = ecf_ImpressoraRepository;
        }
    }
}
