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
    public class Ecf_Dav_DetalheService : ServiceBase<Ecf_Dav_Detalhe>, IEcf_Dav_DetalheService
    {
        private readonly IEcf_Dav_DetalheRepository _ecf_Dav_DetalheRepository;

        public Ecf_Dav_DetalheService(IEcf_Dav_DetalheRepository ecf_Dav_DetalheRepository)
            : base(ecf_Dav_DetalheRepository)

        {
            _ecf_Dav_DetalheRepository = ecf_Dav_DetalheRepository;
        }
    }
}
