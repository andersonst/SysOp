using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class VendaProdutoMap : EntityTypeConfiguration<VendaProduto>
    {
        public VendaProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdVendaProduto);

            // Properties
            // Table & Column Mappings
            this.ToTable("vendaproduto", "sysop");
            this.Property(t => t.IdVendaProduto).HasColumnName("IdVendaProduto");
            this.Property(t => t.DataVenda).HasColumnName("DataVenda");
            this.Property(t => t.IdVendedor).HasColumnName("IdVendedor");
            this.Property(t => t.IdCliente).HasColumnName("IdCliente");
            this.Property(t => t.IdEndereco).HasColumnName("IdEndereco");
            this.Property(t => t.IdUnidade).HasColumnName("IdUnidade");
            this.Property(t => t.CodigoVenda).HasColumnName("CodigoVenda");

            // Relationships
            this.HasOptional(t => t.endereco_2)
                .WithMany(t => t.vendaprodutoes)
                .HasForeignKey(d => d.IdEndereco);
            this.HasOptional(t => t.unidade)
                .WithMany(t => t.vendaprodutoes)
                .HasForeignKey(d => d.IdUnidade);

        }
    }
}
