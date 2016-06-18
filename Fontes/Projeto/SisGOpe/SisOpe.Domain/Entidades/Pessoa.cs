using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Pessoa
    {
        public Pessoa()
        {
            this.Emails = new List<Email>();
            this.Enderecoes = new List<Endereco>();
            this.FornecedorCotacaos = new List<FornecedorCotacao>();
            this.OrdemServicoes = new List<OrdemServico>();
            this.PessoaFisicas = new List<PessoaFisica>();
            this.PessoaJuridicas = new List<PessoaJuridica>();
            this.Telefones = new List<Telefone>();
            this.Usuarios = new List<Usuario>();
        }

        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
        public Nullable<bool> TipoCadastro { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<Endereco> Enderecoes { get; set; }
        public virtual ICollection<FornecedorCotacao> FornecedorCotacaos { get; set; }
        public virtual ICollection<OrdemServico> OrdemServicoes { get; set; }
        public virtual ICollection<PessoaFisica> PessoaFisicas { get; set; }
        public virtual ICollection<PessoaJuridica> PessoaJuridicas { get; set; }
        public virtual ICollection<Telefone> Telefones { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
