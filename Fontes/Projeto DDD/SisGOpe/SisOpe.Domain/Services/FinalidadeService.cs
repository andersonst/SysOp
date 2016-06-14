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
    public class FinalidadeService : ServiceBase<Finalidade>, IFinalidadeService
    {
        private readonly IFinalidadeRepository _finalidadeRepository;

        public FinalidadeService(IFinalidadeRepository finalidadeRepository)
            : base(finalidadeRepository)
        {
            _finalidadeRepository = finalidadeRepository;
        }
    }
}
