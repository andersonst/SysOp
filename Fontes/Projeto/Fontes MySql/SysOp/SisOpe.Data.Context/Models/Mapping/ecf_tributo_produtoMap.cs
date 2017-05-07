using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Ecf_Tributo_ProdutoMap : EntityTypeConfiguration<Ecf_Tributo_Produto>
    {
        public Ecf_Tributo_ProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.DESCRICAO)
                .HasMaxLength(50);

            this.Property(t => t.ECF_ICMS)
                .HasMaxLength(5);

            this.Property(t => t.CST)
                .HasMaxLength(3);

            this.Property(t => t.TOTALIZADOR_PARCIAL)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ecf_tributo_produto", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DESCRICAO).HasColumnName("DESCRICAO");
            this.Property(t => t.TAXA_IPI).HasColumnName("TAXA_IPI");
            this.Property(t => t.TAXA_ISSQN).HasColumnName("TAXA_ISSQN");
            this.Property(t => t.TAXA_PIS).HasColumnName("TAXA_PIS");
            this.Property(t => t.TAXA_COFINS).HasColumnName("TAXA_COFINS");
            this.Property(t => t.TAXA_ICMS).HasColumnName("TAXA_ICMS");
            this.Property(t => t.ECF_ICMS).HasColumnName("ECF_ICMS");
            this.Property(t => t.CST).HasColumnName("CST");
            this.Property(t => t.TOTALIZADOR_PARCIAL).HasColumnName("TOTALIZADOR_PARCIAL");
        }
    }
}
