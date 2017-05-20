using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class ItemEntradaEstoqueMap : EntityTypeConfiguration<ItemEntradaEstoque>
    {
        public ItemEntradaEstoqueMap()
        {
            // Primary Key
            this.HasKey(t => t.IdItemEntradaProduto);

            // Properties
            // Table & Column Mappings
            this.ToTable("itementradaestoque", "sysop");
            this.Property(t => t.IdItemEntradaProduto).HasColumnName("IdItemEntradaProduto");
            this.Property(t => t.IdEntradaProduto).HasColumnName("IdEntradaProduto");
            this.Property(t => t.Lote).HasColumnName("Lote");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.ValorUnitarioCusto).HasColumnName("ValorUnitarioCusto");

            // Relationships
            this.HasOptional(t => t.entradaproduto)
                .WithMany(t => t.itementradaestoques)
                .HasForeignKey(d => d.IdEntradaProduto);

        }
    }
}
