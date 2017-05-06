using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class endereco_2
    {
        public endereco_2()
        {
            this.vendaprodutoes = new List<vendaproduto>();
        }

        public int IdEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string PontoReferencia { get; set; }
        public Nullable<bool> Primario { get; set; }
        public Nullable<long> IdPessoa { get; set; }
        public virtual pessoa pessoa { get; set; }
        public virtual ICollection<vendaproduto> vendaprodutoes { get; set; }
    }
}
