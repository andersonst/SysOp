using SisOpe.Data.Contexto;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Data.Repository.Repositories
{
    public class Ecf_Posicao_ComponentesRepository : RepositoryBase<Ecf_Posicao_Componentes>, IEcf_Posicao_ComponentesRepository
    {
        private readonly SysOpContext _db;
        public Ecf_Posicao_ComponentesRepository(SysOpContext db)
            : base(db)
        {
            _db = db;
        }
    }
}
