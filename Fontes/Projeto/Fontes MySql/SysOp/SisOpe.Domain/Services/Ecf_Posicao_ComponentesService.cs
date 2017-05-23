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
    public class Ecf_Posicao_ComponentesService : ServiceBase<Ecf_Posicao_Componentes>, IEcf_Posicao_ComponentesService
    {
        private readonly IEcf_Posicao_ComponentesRepository _ecf_Posicao_ComponentesRepository;

        public Ecf_Posicao_ComponentesService(IEcf_Posicao_ComponentesRepository ecf_Posicao_ComponentesRepository)
            : base(ecf_Posicao_ComponentesRepository)
        {
            _ecf_Posicao_ComponentesRepository = ecf_Posicao_ComponentesRepository;
        }
    }
}
