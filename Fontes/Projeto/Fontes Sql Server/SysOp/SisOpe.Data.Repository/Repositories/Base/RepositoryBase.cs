using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisOpe.Domain.Interfaces.Repositories;
using SisOpe.Data.Contexto;
using System.Data.SqlClient;

namespace SisOpe.Data.Repository.Repositories
{
    public class RepositoryBase<TEntity>: IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        // SysOpContext db = new SysOpContext();
        private readonly SysOpContext _db;

        public  RepositoryBase(SysOpContext db)
        {
            _db = db;
        }

        public void Add(TEntity obj)
        {
            _db.Set<TEntity>().Add(obj);
            _db.SaveChanges();
        }

        public TEntity GetById(int id)
        {
           return  _db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _db.Set<TEntity>();
        }

        public void Update(TEntity obj)
        {
            _db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            _db.Set<TEntity>().Remove(obj);
            _db.SaveChanges();
        }

        public void ExecuteProcedure(string sql, params SqlParameter[] parameters)
        {
            _db.Database.ExecuteSqlCommand(sql, parameters);
        }

        public List<TEntity> ExecuteToListProcedure(string sql, params SqlParameter[] parameters)
        {
            return _db.Database.SqlQuery<TEntity>(sql, parameters).ToList();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
