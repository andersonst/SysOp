using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Pessoa
    {
        public Pessoa()
        {
            this.ecf_cheque_cliente = new List<Ecf_Cheque_Cliente>();
            this.ecf_operador = new List<Ecf_Operador>();
            this.ecf_venda_cabecalho = new List<Ecf_Venda_Cabecalho>();
            this.ecf_venda_cabecalho1 = new List<Ecf_Venda_Cabecalho>();
            this.emails = new List<Email>();
            this.enderecoes = new List<Endereco>();
            this.endereco_2 = new List<Endereco_2>();
            this.fornecedorcotacaos = new List<FornecedorCotacao>();
            this.nf2_cabecalho = new List<Nf2_Cabecalho>();
            this.nf2_cabecalho1 = new List<Nf2_Cabecalho>();
            this.ordemservicoes = new List<OrdemServico>();
            this.pessoafisicas = new List<PessoaFisica>();
            this.pessoajuridicas = new List<PessoaJuridica>();
            this.telefones = new List<Telefone>();
            this.usuarios = new List<Usuario>();
        }

        public long IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
        public Nullable<bool> TipoCadastro { get; set; }
        public virtual ICollection<Ecf_Cheque_Cliente> ecf_cheque_cliente { get; set; }
        public virtual ICollection<Ecf_Operador> ecf_operador { get; set; }
        public virtual ICollection<Ecf_Venda_Cabecalho> ecf_venda_cabecalho { get; set; }
        public virtual ICollection<Ecf_Venda_Cabecalho> ecf_venda_cabecalho1 { get; set; }
        public virtual ICollection<Email> emails { get; set; }
        public virtual ICollection<Endereco> enderecoes { get; set; }
        public virtual ICollection<Endereco_2> endereco_2 { get; set; }
        public virtual ICollection<FornecedorCotacao> fornecedorcotacaos { get; set; }
        public virtual ICollection<Nf2_Cabecalho> nf2_cabecalho { get; set; }
        public virtual ICollection<Nf2_Cabecalho> nf2_cabecalho1 { get; set; }
        public virtual ICollection<OrdemServico> ordemservicoes { get; set; }
        public virtual ICollection<PessoaFisica> pessoafisicas { get; set; }
        public virtual ICollection<PessoaJuridica> pessoajuridicas { get; set; }
        public virtual ICollection<Telefone> telefones { get; set; }
        public virtual ICollection<Usuario> usuarios { get; set; }
    }
}
