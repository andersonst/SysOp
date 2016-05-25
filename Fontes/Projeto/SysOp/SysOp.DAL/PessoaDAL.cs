using SysOp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysOp.Repository.Base;
using SysOp.Data.Entidades;
using System.Data.SqlClient;

namespace SysOp.DAL
{
    public class PessoaDAL
    {
        public List<Pessoa> ListarPessoa()
        {
            BaseRepositorio<PessoaEnt> repositorio = new BaseRepositorio<PessoaEnt>();

            var query = (from a in repositorio.Selecionar()
                         //where a.IdPessoa == 1
                         select new Pessoa
                         {
                             IdPessoa = a.IdPessoa,
                             Nome = a.Nome,
                             Status = a.Status,
                             TipoCadastro = a.TipoCadastro
                         }).ToList();

            return query;
        }

        public List<Pessoa> ListarPessoaPorProcedure(int id)
        {
            // Chamo direto por Pessoa e não PessoaEnt
            BaseRepositorio<Pessoa> repositorio = new BaseRepositorio<Pessoa>();
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter{ ParameterName = "IdPessoa", SqlDbType = System.Data.SqlDbType.Int, Value = id },
                // new SqlParameter{ ParameterName = "Nome", SqlDbType = System.Data.SqlDbType.VarChar, Value = id },

            };

            List<Pessoa> lista = repositorio.SelecionarDadosProcedimento("spSelecionarPessoasPorID @IdPessoa", parametros).ToList();

            return lista;
        }
    }
}
