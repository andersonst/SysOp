using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
{
    public class ItemReservaVendaProdutoMap : EntityTypeConfiguration<ItemReservaVendaProduto>
    {
        public ItemReservaVendaProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdItemReservaProduto);

            // Properties
            this.Property(t => t.Status)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ItemReservaVendaProduto");
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
                .WithMany(t => t.ItemReservaVendaProdutoes)
                .HasForeignKey(d => d.IdReserva);
            this.HasOptional(t => t.TransferenciaEstoque)
                .WithMany(t => t.ItemReservaVendaProdutoes)
                .HasForeignKey(d => d.IdTE);
            this.HasOptional(t => t.Unidade)
                .WithMany(t => t.ItemReservaVendaProdutoes)
                .HasForeignKey(d => d.IdUnidade);
            this.HasOptional(t => t.VendaProduto)
                .WithMany(t => t.ItemReservaVendaProdutoes)
                .HasForeignKey(d => d.IdVendaProduto);

        }
    }
}
