using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp.Repository.Base.Interfaces
{
    interface IBaseRepositorio<TEntity> where TEntity : class
    {

        IQueryable<TEntity> Selecionar();
        IQueryable<TEntity> Obter(Func<TEntity, bool> predicate);
        TEntity ObterPorId(params object[] key);
        void Atualizar(TEntity obj);
        void SalvarTodos();
        void Adicionar(TEntity obj);
        void Excluir(TEntity obj);
        void ExecutarProcedimento(string query, params object[] parametros);
        List<TEntity> SelecionarDadosProcedimento(string query, object[] parametros);

    }
}
