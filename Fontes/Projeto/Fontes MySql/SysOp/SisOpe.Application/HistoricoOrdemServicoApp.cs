﻿using SisOpe.Domain.Entidades;                                                                                      
using SisOpe.Application.Interfaces;
using SisOpe.Domain.Interfaces.Services;                                                                                                         
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Application
{
    public class HistoricoOrdemServicoApp : AppServiceBase<HistoricoOrdemServico>, IHistoricoOrdemServicoAppService
    {
        private readonly IHistoricoOrdemServicoService _historicoOrdemServicoService;

        public HistoricoOrdemServicoApp(IHistoricoOrdemServicoService historicoOrdemServicoService)
            : base(historicoOrdemServicoService)
        {
            _historicoOrdemServicoService = historicoOrdemServicoService;
        }
    }
}