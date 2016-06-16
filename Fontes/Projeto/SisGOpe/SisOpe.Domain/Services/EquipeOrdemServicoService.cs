﻿using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Repositories;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Domain.Services
{
    public class EquipeOrdemServicoService : ServiceBase<EquipeOrdemServico>, IEquipeOrdemServicoService
    {
        private readonly IEquipeOrdemServicoRepository _equipeOrdemServicoRepository;

        public EquipeOrdemServicoService(IEquipeOrdemServicoRepository equipeOrdemServicoRepository)
            : base(equipeOrdemServicoRepository)
        {
            _equipeOrdemServicoRepository = equipeOrdemServicoRepository;
        }
    }
}
