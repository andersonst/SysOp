using System;
using System.Collections.Generic;


namespace SysOp.Data.Entidades
{
    public partial class PessoaEnt
    {
        public PessoaEnt()
        {
            this.Emails = new List<EmailEnt>();
            this.Enderecoes = new List<EnderecoEnt>();
            this.FornecedorCotacaos = new List<FornecedorCotacaoEnt>();
            this.OrdemServicoes = new List<OrdemServicoEnt>();
            this.PessoaFisicas = new List<PessoaFisicaEnt>();
            this.PessoaJuridicas = new List<PessoaJuridicaEnt>();
            this.Telefones = new List<TelefoneEnt>();
            this.Usuarios = new List<UsuarioEnt>();
        }

       
       

        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
        public Nullable<bool> TipoCadastro { get; set; }
        public virtual ICollection<EmailEnt> Emails { get; set; }
        public virtual ICollection<EnderecoEnt> Enderecoes { get; set; }
        public virtual ICollection<FornecedorCotacaoEnt> FornecedorCotacaos { get; set; }
        public virtual ICollection<OrdemServicoEnt> OrdemServicoes { get; set; }
        public virtual ICollection<PessoaFisicaEnt> PessoaFisicas { get; set; }
        public virtual ICollection<PessoaJuridicaEnt> PessoaJuridicas { get; set; }
        public virtual ICollection<TelefoneEnt> Telefones { get; set; }
        public virtual ICollection<UsuarioEnt> Usuarios { get; set; }
    }
}
