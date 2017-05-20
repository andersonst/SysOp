using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Departamento
    {
        public Departamento()
        {
            this.ProdutoCotacaos = new List<ProdutoCotacao>();
        }

        public int IdDepartamento { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public virtual ICollection<ProdutoCotacao> ProdutoCotacaos { get; set; }
    }
}
