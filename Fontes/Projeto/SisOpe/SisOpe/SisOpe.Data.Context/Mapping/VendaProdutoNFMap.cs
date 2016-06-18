using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
{
    public class VendaProdutoNFMap : EntityTypeConfiguration<VendaProdutoNF>
    {
        public VendaProdutoNFMap()
        {
            // Primary Key
            this.HasKey(t => t.IdVendaProdutoNF);

            // Properties
            // Table & Column Mappings
            this.ToTable("VendaProdutoNF");
            this.Property(t => t.IdVendaProdutoNF).HasColumnName("IdVendaProdutoNF");
            this.Property(t => t.IdVendaProduto).HasColumnName("IdVendaProduto");
            this.Property(t => t.IdNotaFiscal).HasColumnName("IdNotaFiscal");
        }
    }
}