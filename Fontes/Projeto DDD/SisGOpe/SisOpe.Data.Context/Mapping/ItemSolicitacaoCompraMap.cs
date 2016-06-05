using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
{
    public class ItemSolicitacaoCompraMap : EntityTypeConfiguration<ItemSolicitacaoCompra>
    {
        public ItemSolicitacaoCompraMap()
        {
            // Primary Key
            this.HasKey(t => t.IdItemSolicitacaoCompra);

            // Properties
            // Table & Column Mappings
            this.ToTable("ItemSolicitacaoCompra");
            this.Property(t => t.IdItemSolicitacaoCompra).HasColumnName("IdItemSolicitacaoCompra");
            this.Property(t => t.IdSolicitacaoCompra).HasColumnName("IdSolicitacaoCompra");
            this.Property(t => t.IdProduto).HasColumnName("IdProduto");
            this.Property(t => t.IdFornecedor).HasColumnName("IdFornecedor");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.ValorUnitario).HasColumnName("ValorUnitario");

            // Relationships
            this.HasOptional(t => t.SolicitacaoCompra)
                .WithMany(t => t.ItemSolicitacaoCompras)
                .HasForeignKey(d => d.IdSolicitacaoCompra);

        }
    }
}
