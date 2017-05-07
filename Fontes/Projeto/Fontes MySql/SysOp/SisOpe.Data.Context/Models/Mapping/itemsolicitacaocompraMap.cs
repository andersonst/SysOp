using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class itemsolicitacaocompraMap : EntityTypeConfiguration<ItemSolicitacaoCompra>
    {
        public itemsolicitacaocompraMap()
        {
            // Primary Key
            this.HasKey(t => t.IdItemSolicitacaoCompra);

            // Properties
            // Table & Column Mappings
            this.ToTable("itemsolicitacaocompra", "sysop");
            this.Property(t => t.IdItemSolicitacaoCompra).HasColumnName("IdItemSolicitacaoCompra");
            this.Property(t => t.IdSolicitacaoCompra).HasColumnName("IdSolicitacaoCompra");
            this.Property(t => t.IdProduto).HasColumnName("IdProduto");
            this.Property(t => t.IdFornecedor).HasColumnName("IdFornecedor");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.ValorUnitario).HasColumnName("ValorUnitario");

            // Relationships
            this.HasOptional(t => t.produto)
                .WithMany(t => t.itemsolicitacaocompras)
                .HasForeignKey(d => d.IdProduto);
            this.HasOptional(t => t.solicitacaocompra)
                .WithMany(t => t.itemsolicitacaocompras)
                .HasForeignKey(d => d.IdSolicitacaoCompra);

        }
    }
}
