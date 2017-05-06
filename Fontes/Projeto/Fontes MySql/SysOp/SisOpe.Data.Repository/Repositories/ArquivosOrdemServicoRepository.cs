﻿using SisOpe.Data.Contexto;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Data.Repository.Repositories
{
    public class ArquivosOrdemServicoRepository : RepositoryBase<ArquivosOrdemServico>, IArquivosOrdemServicoRepository
    {
        private readonly SysOpContext _db;
        public ArquivosOrdemServicoRepository(SysOpContext db)
           : base(db)
        {
            _db = db;
        }
    }
}
