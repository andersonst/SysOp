using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class ItemReservaProdutoMap : EntityTypeConfiguration<ItemReservaProdutoEnt>
    {
        public ItemReservaProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdItemReservaProduto);

            // Properties
            this.Property(t => t.Status)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ItemReservaProduto");
            this.Property(t => t.IdItemReservaProduto).HasColumnName("IdItemReservaProduto");
            this.Property(t => t.IdProduto).HasColumnName("IdProduto");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.DataSeparacao).HasColumnName("DataSeparacao");
            this.Property(t => t.DataAtual).HasColumnName("DataAtual");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.IdVendaProduto).HasColumnName("IdVendaProduto");
            this.Property(t => t.IdTE).HasColumnName("IdTE");
            this.Property(t => t.QtdTotalEstoque).HasColumnName("QtdTotalEstoque");
            this.Property(t => t.IdUnidade).HasColumnName("IdUnidade");
            this.Property(t => t.IdReserva).HasColumnName("IdReserva");

            // Relationships
            this.HasOptional(t => t.Reserva)
                .WithMany(t => t.ItemReservaProdutoes)
                .HasForeignKey(d => d.IdReserva);
            this.HasOptional(t => t.TransferenciaEstoque)
                .WithMany(t => t.ItemReservaProdutoes)
                .HasForeignKey(d => d.IdTE);
            this.HasOptional(t => t.VendaProduto)
                .WithMany(t => t.ItemReservaProdutoes)
                .HasForeignKey(d => d.IdVendaProduto);
            this.HasOptional(t => t.Produto)
                .WithMany(t => t.ItemReservaProdutoes)
                .HasForeignKey(d => d.IdProduto);

        }
    }
}
