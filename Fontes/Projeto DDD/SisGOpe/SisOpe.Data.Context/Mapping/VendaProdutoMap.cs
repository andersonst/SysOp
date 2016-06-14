using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
{
    public class VendaProdutoMap : EntityTypeConfiguration<VendaProduto>
    {
        public VendaProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdVendaProduto);

            // Properties
            // Table & Column Mappings
            this.ToTable("VendaProduto");
            this.Property(t => t.IdVendaProduto).HasColumnName("IdVendaProduto");
            this.Property(t => t.DataVenda).HasColumnName("DataVenda");
            this.Property(t => t.IdVendedor).HasColumnName("IdVendedor");
            this.Property(t => t.IdCliente).HasColumnName("IdCliente");
            this.Property(t => t.IdEndereco).HasColumnName("IdEndereco");
            this.Property(t => t.IdUnidade).HasColumnName("IdUnidade");
            this.Property(t => t.CodigoVenda).HasColumnName("CodigoVenda");

            // Relationships
            this.HasOptional(t => t.Endereco)
                .WithMany(t => t.VendaProdutoes)
                .HasForeignKey(d => d.IdEndereco);
            this.HasOptional(t => t.Unidade)
                .WithMany(t => t.VendaProdutoes)
                .HasForeignKey(d => d.IdUnidade);

        }
    }
}
