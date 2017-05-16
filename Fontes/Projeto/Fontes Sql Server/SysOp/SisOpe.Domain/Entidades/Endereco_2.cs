using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Endereco_2
    {
        public Endereco_2()
        {
            this.vendaprodutoes = new List<VendaProduto>();
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
        public virtual Pessoa pessoa { get; set; }
        public virtual ICollection<VendaProduto> vendaprodutoes { get; set; }
    }
}
