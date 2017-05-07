using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class entradaprodutonfMap : EntityTypeConfiguration<EntradaProdutoNF>
    {
        public entradaprodutonfMap()
        {
            // Primary Key
            this.HasKey(t => t.IdEntradaProdutoNF);

            // Properties
            // Table & Column Mappings
            this.ToTable("entradaprodutonf", "sysop");
            this.Property(t => t.IdEntradaProdutoNF).HasColumnName("IdEntradaProdutoNF");
            this.Property(t => t.IdEntradaProduto).HasColumnName("IdEntradaProduto");
            this.Property(t => t.IdNotaFisacal).HasColumnName("IdNotaFisacal");
            this.Property(t => t.IdPedidoCompra).HasColumnName("IdPedidoCompra");

            // Relationships
            this.HasOptional(t => t.entradaproduto)
                .WithMany(t => t.entradaprodutonfs)
                .HasForeignKey(d => d.IdEntradaProduto);
            this.HasOptional(t => t.notafiscal)
                .WithMany(t => t.entradaprodutonfs)
                .HasForeignKey(d => d.IdNotaFisacal);
            this.HasOptional(t => t.pedidocompra)
                .WithMany(t => t.entradaprodutonfs)
                .HasForeignKey(d => d.IdPedidoCompra);

        }
    }
}
