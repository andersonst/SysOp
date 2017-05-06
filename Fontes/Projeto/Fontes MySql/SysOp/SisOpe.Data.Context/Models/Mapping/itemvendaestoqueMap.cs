using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class itemvendaestoqueMap : EntityTypeConfiguration<itemvendaestoque>
    {
        public itemvendaestoqueMap()
        {
            // Primary Key
            this.HasKey(t => t.IdItemVendaEstoque);

            // Properties
            // Table & Column Mappings
            this.ToTable("itemvendaestoque", "sysop");
            this.Property(t => t.IdItemVendaEstoque).HasColumnName("IdItemVendaEstoque");
            this.Property(t => t.IdVendaProduto).HasColumnName("IdVendaProduto");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.Valor).HasColumnName("Valor");
            this.Property(t => t.IdProduto).HasColumnName("IdProduto");
            this.Property(t => t.desconto).HasColumnName("desconto");

            // Relationships
            this.HasOptional(t => t.produto)
                .WithMany(t => t.itemvendaestoques)
                .HasForeignKey(d => d.IdProduto);
            this.HasOptional(t => t.vendaproduto)
                .WithMany(t => t.itemvendaestoques)
                .HasForeignKey(d => d.IdVendaProduto);

        }
    }
}
