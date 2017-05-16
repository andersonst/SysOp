using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class ItemProdutoNotaFiscalMap : EntityTypeConfiguration<ItemProdutoNotaFiscal>
    {
        public ItemProdutoNotaFiscalMap()
        {
            // Primary Key
            this.HasKey(t => t.IdItemProdutoNotaFiscal);

            // Properties
            // Table & Column Mappings
            this.ToTable("itemprodutonotafiscal", "sysop");
            this.Property(t => t.IdItemProdutoNotaFiscal).HasColumnName("IdItemProdutoNotaFiscal");
            this.Property(t => t.IdProduto).HasColumnName("IdProduto");
            this.Property(t => t.Lote).HasColumnName("Lote");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.ValorUnitario).HasColumnName("ValorUnitario");
            this.Property(t => t.ValorFrete).HasColumnName("ValorFrete");
            this.Property(t => t.ValorDesconto).HasColumnName("ValorDesconto");
            this.Property(t => t.ValorSeguro).HasColumnName("ValorSeguro");
            this.Property(t => t.IPI).HasColumnName("IPI");
            this.Property(t => t.ICMS).HasColumnName("ICMS");
            this.Property(t => t.IdNotaFiscal).HasColumnName("IdNotaFiscal");

            // Relationships
            this.HasOptional(t => t.notafiscal)
                .WithMany(t => t.itemprodutonotafiscals)
                .HasForeignKey(d => d.IdNotaFiscal);
            this.HasOptional(t => t.produto)
                .WithMany(t => t.itemprodutonotafiscals)
                .HasForeignKey(d => d.IdProduto);

        }
    }
}
