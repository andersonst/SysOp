using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class EntradaProdutoNFMap : EntityTypeConfiguration<EntradaProdutoNFEnt>
    {
        public EntradaProdutoNFMap()
        {
            // Primary Key
            this.HasKey(t => t.IdEntradaProdutoNF);

            // Properties
            // Table & Column Mappings
            this.ToTable("EntradaProdutoNF");
            this.Property(t => t.IdEntradaProdutoNF).HasColumnName("IdEntradaProdutoNF");
            this.Property(t => t.IdEntradaProduto).HasColumnName("IdEntradaProduto");
            this.Property(t => t.IdNotaFisacal).HasColumnName("IdNotaFisacal");
            this.Property(t => t.IdPedidoCompra).HasColumnName("IdPedidoCompra");

            // Relationships
            this.HasOptional(t => t.EntradaProduto)
                .WithMany(t => t.EntradaProdutoNFs)
                .HasForeignKey(d => d.IdEntradaProduto);
            this.HasOptional(t => t.NotaFiscal)
                .WithMany(t => t.EntradaProdutoNFs)
                .HasForeignKey(d => d.IdNotaFisacal);
            this.HasOptional(t => t.PedidoCompra)
                .WithMany(t => t.EntradaProdutoNFs)
                .HasForeignKey(d => d.IdPedidoCompra);

        }
    }
}
