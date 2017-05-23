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
    public class Ecf_Dav_CabecalhoService : ServiceBase<Ecf_Dav_Cabecalho>, IEcf_Dav_CabecalhoService
    {
        private readonly IEcf_Dav_CabecalhoRepository _ecf_Dav_CabecalhoRepository;

        public Ecf_Dav_CabecalhoService(IEcf_Dav_CabecalhoRepository ecf_Dav_CabecalhoRepository)
            : base(ecf_Dav_CabecalhoRepository)
        {
            _ecf_Dav_CabecalhoRepository = ecf_Dav_CabecalhoRepository;
        }
    }
}
