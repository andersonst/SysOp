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
    public class TransferenciaEstoqueApp : AppServiceBase<TransferenciaEstoque>, ITransferenciaEstoqueAppService
    {
        private readonly ITransferenciaEstoqueService _transferenciaEstoqueService;

        public TransferenciaEstoqueApp(ITransferenciaEstoqueService transferenciaEstoqueService)
            :base(transferenciaEstoqueService)
        {
            _transferenciaEstoqueService = transferenciaEstoqueService;
        }
    }
}
