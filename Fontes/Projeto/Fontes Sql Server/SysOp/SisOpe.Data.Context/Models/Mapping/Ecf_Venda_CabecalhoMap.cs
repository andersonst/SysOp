using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Ecf_Venda_CabecalhoMap : EntityTypeConfiguration<Ecf_Venda_Cabecalho>
    {
        public Ecf_Venda_CabecalhoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SINCRONIZADO)
                .HasMaxLength(1);

            this.Property(t => t.STATUS_VENDA)
                .HasMaxLength(1);

            this.Property(t => t.NOME_CLIENTE)
                .HasMaxLength(100);

            this.Property(t => t.CPF_CNPJ_CLIENTE)
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("ecf_venda_cabecalho", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_CFOP).HasColumnName("ID_CFOP");
            this.Property(t => t.ID_ECF_DAV).HasColumnName("ID_ECF_DAV");
            this.Property(t => t.ID_ECF_PRE_VENDA_CABECALHO).HasColumnName("ID_ECF_PRE_VENDA_CABECALHO");
            this.Property(t => t.ID_CLIENTE).HasColumnName("ID_CLIENTE");
            this.Property(t => t.ID_ECF_FUNCIONARIO).HasColumnName("ID_ECF_FUNCIONARIO");
            this.Property(t => t.ID_ECF_MOVIMENTO).HasColumnName("ID_ECF_MOVIMENTO");
            this.Property(t => t.COO).HasColumnName("COO");
            this.Property(t => t.CCF).HasColumnName("CCF");
            this.Property(t => t.DATA_HORA_VENDA).HasColumnName("DATA_HORA_VENDA");
            this.Property(t => t.VALOR_VENDA).HasColumnName("VALOR_VENDA");
            this.Property(t => t.TAXA_DESCONTO).HasColumnName("TAXA_DESCONTO");
            this.Property(t => t.DESCONTO).HasColumnName("DESCONTO");
            this.Property(t => t.TAXA_ACRESCIMO).HasColumnName("TAXA_ACRESCIMO");
            this.Property(t => t.ACRESCIMO).HasColumnName("ACRESCIMO");
            this.Property(t => t.VALOR_FINAL).HasColumnName("VALOR_FINAL");
            this.Property(t => t.VALOR_RECEBIDO).HasColumnName("VALOR_RECEBIDO");
            this.Property(t => t.TROCO).HasColumnName("TROCO");
            this.Property(t => t.VALOR_CANCELADO).HasColumnName("VALOR_CANCELADO");
            this.Property(t => t.SINCRONIZADO).HasColumnName("SINCRONIZADO");
            this.Property(t => t.TOTAL_PRODUTOS).HasColumnName("TOTAL_PRODUTOS");
            this.Property(t => t.TOTAL_DOCUMENTO).HasColumnName("TOTAL_DOCUMENTO");
            this.Property(t => t.BASE_ICMS).HasColumnName("BASE_ICMS");
            this.Property(t => t.ICMS).HasColumnName("ICMS");
            this.Property(t => t.ICMS_OUTRAS).HasColumnName("ICMS_OUTRAS");
            this.Property(t => t.ISSQN).HasColumnName("ISSQN");
            this.Property(t => t.PIS).HasColumnName("PIS");
            this.Property(t => t.COFINS).HasColumnName("COFINS");
            this.Property(t => t.ACRESCIMO_ITENS).HasColumnName("ACRESCIMO_ITENS");
            this.Property(t => t.DESCONTO_ITENS).HasColumnName("DESCONTO_ITENS");
            this.Property(t => t.STATUS_VENDA).HasColumnName("STATUS_VENDA");
            this.Property(t => t.NOME_CLIENTE).HasColumnName("NOME_CLIENTE");
            this.Property(t => t.CPF_CNPJ_CLIENTE).HasColumnName("CPF_CNPJ_CLIENTE");

            // Relationships
            this.HasOptional(t => t.cfop)
                .WithMany(t => t.ecf_venda_cabecalho)
                .HasForeignKey(d => d.ID_CFOP);
            this.HasOptional(t => t.ecf_dav_cabecalho)
                .WithMany(t => t.ecf_venda_cabecalho)
                .HasForeignKey(d => d.ID_ECF_DAV);
            this.HasRequired(t => t.ecf_movimento)
                .WithMany(t => t.ecf_venda_cabecalho)
                .HasForeignKey(d => d.ID_ECF_MOVIMENTO);
            this.HasOptional(t => t.ecf_pre_venda_cabecalho)
                .WithMany(t => t.ecf_venda_cabecalho)
                .HasForeignKey(d => d.ID_ECF_PRE_VENDA_CABECALHO);
            this.HasOptional(t => t.pessoa)
                .WithMany(t => t.ecf_venda_cabecalho)
                .HasForeignKey(d => d.ID_ECF_FUNCIONARIO);
            this.HasOptional(t => t.pessoa1)
                .WithMany(t => t.ecf_venda_cabecalho1)
                .HasForeignKey(d => d.ID_CLIENTE);

        }
    }
}
