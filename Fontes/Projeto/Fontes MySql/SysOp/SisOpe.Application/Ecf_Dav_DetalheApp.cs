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
    public class Ecf_Dav_DetalheApp : AppServiceBase<Ecf_Dav_Detalhe>, IEcf_Dav_DetalheAppService
    {
        private readonly IEcf_Dav_DetalheService _ecf_Dav_DetalheService;

        public Ecf_Dav_DetalheApp(IEcf_Dav_DetalheService ecf_Dav_DetalheService)
            : base(ecf_Dav_DetalheService)
        {
            _ecf_Dav_DetalheService = ecf_Dav_DetalheService;
        }
    }
}
