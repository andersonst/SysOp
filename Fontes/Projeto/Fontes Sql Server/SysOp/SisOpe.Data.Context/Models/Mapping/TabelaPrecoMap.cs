using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class TabelaPrecoMap : EntityTypeConfiguration<TabelaPreco>
    {
        public TabelaPrecoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdTabelaPreco);

            // Properties
            // Table & Column Mappings
            this.ToTable("tabelapreco", "sysop");
            this.Property(t => t.IdTabelaPreco).HasColumnName("IdTabelaPreco");
            this.Property(t => t.IdProduto).HasColumnName("IdProduto");
            this.Property(t => t.ValorUnitarioVenda).HasColumnName("ValorUnitarioVenda");
            this.Property(t => t.DataVenda).HasColumnName("DataVenda");

            // Relationships
            this.HasOptional(t => t.produto_2)
                .WithMany(t => t.tabelaprecoes)
                .HasForeignKey(d => d.IdProduto);

        }
    }
}
