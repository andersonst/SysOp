using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class entradaprodutoMap : EntityTypeConfiguration<EntradaProduto>
    {
        public entradaprodutoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdEntradaProduto);

            // Properties
            // Table & Column Mappings
            this.ToTable("entradaproduto", "sysop");
            this.Property(t => t.IdEntradaProduto).HasColumnName("IdEntradaProduto");
            this.Property(t => t.DataEntrada).HasColumnName("DataEntrada");
            this.Property(t => t.IdUsuario).HasColumnName("IdUsuario");
        }
    }
}
