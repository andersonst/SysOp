using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Ecf_Venda_DetalheMap : EntityTypeConfiguration<Ecf_Venda_Detalhe>
    {
        public Ecf_Venda_DetalheMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.TOTALIZADOR_PARCIAL)
                .HasMaxLength(10);

            this.Property(t => t.CST)
                .HasMaxLength(3);

            this.Property(t => t.CANCELADO)
                .HasMaxLength(1);

            this.Property(t => t.MOVIMENTA_ESTOQUE)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ecf_venda_detalhe", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_CFOP).HasColumnName("ID_CFOP");
            this.Property(t => t.ID_ECF_TRIBUTO_PRODUTO).HasColumnName("ID_ECF_TRIBUTO_PRODUTO");
            this.Property(t => t.ID_ECF_PRODUTO).HasColumnName("ID_ECF_PRODUTO");
            this.Property(t => t.ID_ECF_VENDA_CABECALHO).HasColumnName("ID_ECF_VENDA_CABECALHO");
            this.Property(t => t.ITEM).HasColumnName("ITEM");
            this.Property(t => t.QUANTIDADE).HasColumnName("QUANTIDADE");
            this.Property(t => t.VALOR_UNITARIO).HasColumnName("VALOR_UNITARIO");
            this.Property(t => t.VALOR_TOTAL).HasColumnName("VALOR_TOTAL");
            this.Property(t => t.TOTAL_ITEM).HasColumnName("TOTAL_ITEM");
            this.Property(t => t.BASE_ICMS).HasColumnName("BASE_ICMS");
            this.Property(t => t.TAXA_ICMS).HasColumnName("TAXA_ICMS");
            this.Property(t => t.ICMS).HasColumnName("ICMS");
            this.Property(t => t.TAXA_DESCONTO).HasColumnName("TAXA_DESCONTO");
            this.Property(t => t.DESCONTO).HasColumnName("DESCONTO");
            this.Property(t => t.TAXA_ISSQN).HasColumnName("TAXA_ISSQN");
            this.Property(t => t.ISSQN).HasColumnName("ISSQN");
            this.Property(t => t.TAXA_PIS).HasColumnName("TAXA_PIS");
            this.Property(t => t.PIS).HasColumnName("PIS");
            this.Property(t => t.TAXA_COFINS).HasColumnName("TAXA_COFINS");
            this.Property(t => t.COFINS).HasColumnName("COFINS");
            this.Property(t => t.TAXA_ACRESCIMO).HasColumnName("TAXA_ACRESCIMO");
            this.Property(t => t.ACRESCIMO).HasColumnName("ACRESCIMO");
            this.Property(t => t.TOTALIZADOR_PARCIAL).HasColumnName("TOTALIZADOR_PARCIAL");
            this.Property(t => t.CST).HasColumnName("CST");
            this.Property(t => t.CANCELADO).HasColumnName("CANCELADO");
            this.Property(t => t.MOVIMENTA_ESTOQUE).HasColumnName("MOVIMENTA_ESTOQUE");

            // Relationships
            this.HasRequired(t => t.cfop)
                .WithMany(t => t.ecf_venda_detalhe)
                .HasForeignKey(d => d.ID_CFOP);
            this.HasRequired(t => t.ecf_tributo_produto)
                .WithMany(t => t.ecf_venda_detalhe)
                .HasForeignKey(d => d.ID_ECF_TRIBUTO_PRODUTO);
            this.HasRequired(t => t.ecf_venda_cabecalho)
                .WithMany(t => t.ecf_venda_detalhe)
                .HasForeignKey(d => d.ID_ECF_VENDA_CABECALHO);
            this.HasRequired(t => t.produto)
                .WithMany(t => t.ecf_venda_detalhe)
                .HasForeignKey(d => d.ID_ECF_PRODUTO);

        }
    }
}
