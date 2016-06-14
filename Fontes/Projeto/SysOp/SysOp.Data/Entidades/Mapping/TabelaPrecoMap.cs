using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class TabelaPrecoMap : EntityTypeConfiguration<TabelaPrecoEnt>
    {
        public TabelaPrecoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdTabelaPreco);

            // Properties
            // Table & Column Mappings
            this.ToTable("TabelaPreco");
            this.Property(t => t.IdTabelaPreco).HasColumnName("IdTabelaPreco");
            this.Property(t => t.IdProduto).HasColumnName("IdProduto");
            this.Property(t => t.ValorUnitarioVenda).HasColumnName("ValorUnitarioVenda");
            this.Property(t => t.DataVenda).HasColumnName("DataVenda");

            // Relationships
            this.HasOptional(t => t.Produto)
                .WithMany(t => t.TabelaPrecoes)
                .HasForeignKey(d => d.IdProduto);

        }
    }
}
