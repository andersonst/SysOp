using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysOp.Repository.Base.Interfaces;
using SysOp.Data.Entidades;
using System.Data.Entity;

namespace SysOp.Repository.Base
{
    public class BaseRepositorio<T> : IDisposable, IBaseRepositorio<T> where T : class
    {

        SysOpContext ctx = new SysOpContext();

        public IQueryable<T> Selecionar()
        {
            return ctx.Set<T>();
        }

        public IQueryable<T> Obter(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public T ObterPorId(params object[] key)
        {
            return ctx.Set<T>().Find(key);
        }

        public void Atualizar(T obj)
        {
            ctx.Entry(obj).State = EntityState.Modified;
        }

        public void SalvarTodos()
        {
            ctx.SaveChanges();
        }

        public void Adicionar(T obj)
        {
            ctx.Set<T>().Add(obj);
        }

        public void Excluir(T obj)
        {
            ctx.Set<T>().Remove(obj);
        }

        public void ExecutarProcedimento(string query, params  object[] parametros)
        {
            ctx.Database.ExecuteSqlCommand(query, parametros);
        }

        public List<T> SelecionarDadosProcedimento(string query, object[] parametros)
        {
            return ctx.Database.SqlQuery<T>(query, parametros).ToList();
        }

        public void Dispose()
        {
            ctx.Dispose();
        }
    }
}
