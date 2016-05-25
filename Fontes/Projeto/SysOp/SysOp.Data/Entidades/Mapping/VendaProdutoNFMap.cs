using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class VendaProdutoNFMap : EntityTypeConfiguration<VendaProdutoNFEnt>
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
