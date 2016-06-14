using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp.Models
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }

        // ? Indica propriedade pode ser nula
        public bool? TipoCadastro { get; set; }
    }
}
