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
    public class VendaProdutoService : ServiceBase<VendaProduto>, IVendaProdutoService
    {
        private readonly IVendaProdutoRepository _vendaProdutoRepository;

        public VendaProdutoService(IVendaProdutoRepository vendaProdutoRepository)
            :base(vendaProdutoRepository)
        {
            _vendaProdutoRepository = vendaProdutoRepository;
        }
    }
}