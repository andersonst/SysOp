using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Endereco
    {
        public Endereco()
        {
            this.VendaProdutoes = new List<VendaProduto>();
        }

        public int IdEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string PontoReferencia { get; set; }
        public Nullable<bool> Primario { get; set; }
        public Nullable<int> IdPessoa { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual ICollection<VendaProduto> VendaProdutoes { get; set; }
    }
}
