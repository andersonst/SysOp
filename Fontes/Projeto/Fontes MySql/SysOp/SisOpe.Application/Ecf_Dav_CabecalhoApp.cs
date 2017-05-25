using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Application
{
    public class Ecf_Dav_CabecalhoApp : AppServiceBase<Ecf_Dav_Cabecalho>, IEcf_Dav_CabecalhoAppService
    {
        private readonly IEcf_Dav_CabecalhoService _ecf_Dav_CabecalhoService;

        public Ecf_Dav_CabecalhoApp(IEcf_Dav_CabecalhoService ecf_Dav_CabecalhoService)
            : base(ecf_Dav_CabecalhoService)
        {
            _ecf_Dav_CabecalhoService = ecf_Dav_CabecalhoService;
        }
    }
}
