using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Ecf_Pre_Venda_DetalheMap : EntityTypeConfiguration<Ecf_Pre_Venda_Detalhe>
    {
        public Ecf_Pre_Venda_DetalheMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ecf_pre_venda_detalhe", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_PRODUTO).HasColumnName("ID_PRODUTO");
            this.Property(t => t.ID_ECF_PRE_VENDA_CABECALHO).HasColumnName("ID_ECF_PRE_VENDA_CABECALHO");
            this.Property(t => t.QUANTIDADE).HasColumnName("QUANTIDADE");
            this.Property(t => t.VALOR_UNITARIO).HasColumnName("VALOR_UNITARIO");
            this.Property(t => t.VALOR_TOTAL).HasColumnName("VALOR_TOTAL");

            // Relationships
            this.HasRequired(t => t.ecf_pre_venda_cabecalho)
                .WithMany(t => t.ecf_pre_venda_detalhe)
                .HasForeignKey(d => d.ID_ECF_PRE_VENDA_CABECALHO);
            this.HasRequired(t => t.produto)
                .WithMany(t => t.ecf_pre_venda_detalhe)
                .HasForeignKey(d => d.ID_PRODUTO);

        }
    }
}
