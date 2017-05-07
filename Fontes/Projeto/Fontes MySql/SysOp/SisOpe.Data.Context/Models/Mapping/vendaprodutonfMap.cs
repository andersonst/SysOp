using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class vendaprodutonfMap : EntityTypeConfiguration<VendaProdutoNF>
    {
        public vendaprodutonfMap()
        {
            // Primary Key
            this.HasKey(t => t.IdVendaProdutoNF);

            // Properties
            // Table & Column Mappings
            this.ToTable("vendaprodutonf", "sysop");
            this.Property(t => t.IdVendaProdutoNF).HasColumnName("IdVendaProdutoNF");
            this.Property(t => t.IdVendaProduto).HasColumnName("IdVendaProduto");
            this.Property(t => t.IdNotaFiscal).HasColumnName("IdNotaFiscal");
        }
    }
}
