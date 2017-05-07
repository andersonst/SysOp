using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class itemtransferenciaestoqueMap : EntityTypeConfiguration<ItemTransferenciaEstoque>
    {
        public itemtransferenciaestoqueMap()
        {
            // Primary Key
            this.HasKey(t => t.IdItemTransferenciaEstoque);

            // Properties
            this.Property(t => t.Status)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("itemtransferenciaestoque", "sysop");
            this.Property(t => t.IdItemTransferenciaEstoque).HasColumnName("IdItemTransferenciaEstoque");
            this.Property(t => t.IdProduto).HasColumnName("IdProduto");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.IdLocalOrigem).HasColumnName("IdLocalOrigem");
            this.Property(t => t.IdLocalDestino).HasColumnName("IdLocalDestino");
            this.Property(t => t.IdTE).HasColumnName("IdTE");

            // Relationships
            this.HasOptional(t => t.produto_2)
                .WithMany(t => t.itemtransferenciaestoques)
                .HasForeignKey(d => d.IdProduto);
            this.HasOptional(t => t.transferenciaestoque)
                .WithMany(t => t.itemtransferenciaestoques)
                .HasForeignKey(d => d.IdTE);
            this.HasOptional(t => t.unidade)
                .WithMany(t => t.itemtransferenciaestoques)
                .HasForeignKey(d => d.IdLocalDestino);
            this.HasOptional(t => t.unidade1)
                .WithMany(t => t.itemtransferenciaestoques1)
                .HasForeignKey(d => d.IdLocalOrigem);

        }
    }
}
