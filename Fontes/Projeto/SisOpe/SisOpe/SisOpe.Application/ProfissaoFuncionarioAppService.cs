﻿using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Repositories;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Application
{
    public class ProfissaoFuncionarioAppService : AppServiceBase<ProfissaoFuncionario>, IProfissaoFuncionarioAppService
    {
        private readonly IProfissaoFuncionarioService _profissaoFuncionarioService;

        public ProfissaoFuncionarioAppService(IProfissaoFuncionarioService profissaoFuncionarioService)
            :base(profissaoFuncionarioService)
        {
            _profissaoFuncionarioService = profissaoFuncionarioService;
        }
    }
}
