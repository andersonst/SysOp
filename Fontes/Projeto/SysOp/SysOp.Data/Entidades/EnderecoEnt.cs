using System;
using System.Collections.Generic;

namespace SysOp.Data.Entidades
{
    public partial class EnderecoEnt
    {
        public EnderecoEnt()
        {
            this.VendaProdutoes = new List<VendaProdutoEnt>();
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
        public virtual PessoaEnt Pessoa { get; set; }
        public virtual ICollection<VendaProdutoEnt> VendaProdutoes { get; set; }
    }
}
