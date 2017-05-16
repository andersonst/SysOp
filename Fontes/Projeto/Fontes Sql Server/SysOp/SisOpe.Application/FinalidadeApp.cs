using SisOpe.Domain.Entidades;
using SisOpe.Application.Interfaces;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Application
{
    public class FinalidadeApp : AppServiceBase<Finalidade>, IFinalidadeAppService
    {
        private readonly IFinalidadeService _finalidadeService;

        public FinalidadeApp(IFinalidadeService finalidadeService)
            : base(finalidadeService)
        {
            _finalidadeService = finalidadeService;
        }
    }
}
