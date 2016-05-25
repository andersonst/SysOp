using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class ItemVendaEstoqueMap : EntityTypeConfiguration<ItemVendaEstoqueEnt>
    {
        public ItemVendaEstoqueMap()
        {
            // Primary Key
            this.HasKey(t => t.IdItemVendaEstoque);

            // Properties
            // Table & Column Mappings
            this.ToTable("ItemVendaEstoque");
            this.Property(t => t.IdItemVendaEstoque).HasColumnName("IdItemVendaEstoque");
            this.Property(t => t.IdVendaProduto).HasColumnName("IdVendaProduto");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.Valor).HasColumnName("Valor");
            this.Property(t => t.IdProduto).HasColumnName("IdProduto");
            this.Property(t => t.desconto).HasColumnName("desconto");

            // Relationships
            this.HasOptional(t => t.Produto)
                .WithMany(t => t.ItemVendaEstoques)
                .HasForeignKey(d => d.IdProduto);
            this.HasOptional(t => t.VendaProduto)
                .WithMany(t => t.ItemVendaEstoques)
                .HasForeignKey(d => d.IdVendaProduto);

        }
    }
}
