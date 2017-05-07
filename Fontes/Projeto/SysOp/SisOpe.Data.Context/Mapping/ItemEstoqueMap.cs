using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
{
    public class ItemEstoqueMap : EntityTypeConfiguration<ItemEstoque>
    {
        public ItemEstoqueMap()
        {
            // Primary Key
            this.HasKey(t => t.IdItemEstoque);

            // Properties
            // Table & Column Mappings
            this.ToTable("ItemEstoque");
            this.Property(t => t.IdItemEstoque).HasColumnName("IdItemEstoque");
            this.Property(t => t.IdUnidade).HasColumnName("IdUnidade");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.IdProduto).HasColumnName("IdProduto");
            this.Property(t => t.Data).HasColumnName("Data");

            // Relationships
            this.HasOptional(t => t.Produto)
                .WithMany(t => t.ItemEstoques)
                .HasForeignKey(d => d.IdProduto);
            this.HasOptional(t => t.Unidade)
                .WithMany(t => t.ItemEstoques)
                .HasForeignKey(d => d.IdUnidade);

        }
    }
}
