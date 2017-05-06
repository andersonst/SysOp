using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class pessoa
    {
        public pessoa()
        {
            this.ecf_cheque_cliente = new List<ecf_cheque_cliente>();
            this.ecf_operador = new List<ecf_operador>();
            this.ecf_venda_cabecalho = new List<ecf_venda_cabecalho>();
            this.ecf_venda_cabecalho1 = new List<ecf_venda_cabecalho>();
            this.emails = new List<email>();
            this.enderecoes = new List<endereco>();
            this.endereco_2 = new List<endereco_2>();
            this.fornecedorcotacaos = new List<fornecedorcotacao>();
            this.nf2_cabecalho = new List<nf2_cabecalho>();
            this.nf2_cabecalho1 = new List<nf2_cabecalho>();
            this.ordemservicoes = new List<ordemservico>();
            this.pessoafisicas = new List<pessoafisica>();
            this.pessoajuridicas = new List<pessoajuridica>();
            this.telefones = new List<telefone>();
            this.usuarios = new List<usuario>();
        }

        public long IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
        public Nullable<bool> TipoCadastro { get; set; }
        public virtual ICollection<ecf_cheque_cliente> ecf_cheque_cliente { get; set; }
        public virtual ICollection<ecf_operador> ecf_operador { get; set; }
        public virtual ICollection<ecf_venda_cabecalho> ecf_venda_cabecalho { get; set; }
        public virtual ICollection<ecf_venda_cabecalho> ecf_venda_cabecalho1 { get; set; }
        public virtual ICollection<email> emails { get; set; }
        public virtual ICollection<endereco> enderecoes { get; set; }
        public virtual ICollection<endereco_2> endereco_2 { get; set; }
        public virtual ICollection<fornecedorcotacao> fornecedorcotacaos { get; set; }
        public virtual ICollection<nf2_cabecalho> nf2_cabecalho { get; set; }
        public virtual ICollection<nf2_cabecalho> nf2_cabecalho1 { get; set; }
        public virtual ICollection<ordemservico> ordemservicoes { get; set; }
        public virtual ICollection<pessoafisica> pessoafisicas { get; set; }
        public virtual ICollection<pessoajuridica> pessoajuridicas { get; set; }
        public virtual ICollection<telefone> telefones { get; set; }
        public virtual ICollection<usuario> usuarios { get; set; }
    }
}
