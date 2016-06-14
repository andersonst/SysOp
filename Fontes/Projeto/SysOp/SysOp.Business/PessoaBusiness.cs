using SysOp.DAL;
using SysOp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp.Business
{
    public class PessoaBusiness
    {
        public List<Pessoa> Listar()
        {
            PessoaDAL dalPessoa = new PessoaDAL();
            return dalPessoa.ListarPessoa();
        }
    }
}
