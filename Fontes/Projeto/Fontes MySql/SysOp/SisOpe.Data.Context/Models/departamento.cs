using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class departamento
    {
        public departamento()
        {
            this.produtocotacaos = new List<produtocotacao>();
        }

        public int IdDepartamento { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public virtual ICollection<produtocotacao> produtocotacaos { get; set; }
    }
}
