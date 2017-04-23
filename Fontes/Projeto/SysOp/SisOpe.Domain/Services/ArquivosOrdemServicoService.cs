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
    public class ArquivosOrdemServicoService : ServiceBase<ArquivosOrdemServico>, IArquivosOrdemServicoService
    {
        private readonly IArquivosOrdemServicoRepository _arquivosOrdemServicoRepository;

        public ArquivosOrdemServicoService(IArquivosOrdemServicoRepository arquivosOrdemServicoRepository)
            : base(arquivosOrdemServicoRepository)
        {
            _arquivosOrdemServicoRepository = arquivosOrdemServicoRepository;
        }


    }
}
