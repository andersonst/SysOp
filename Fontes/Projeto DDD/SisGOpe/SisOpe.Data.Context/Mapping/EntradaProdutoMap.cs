using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
{
    public class EntradaProdutoMap : EntityTypeConfiguration<EntradaProduto>
    {
        public EntradaProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdEntradaProduto);

            // Properties
            // Table & Column Mappings
            this.ToTable("EntradaProduto");
            this.Property(t => t.IdEntradaProduto).HasColumnName("IdEntradaProduto");
            this.Property(t => t.DataEntrada).HasColumnName("DataEntrada");
            this.Property(t => t.IdUsuario).HasColumnName("IdUsuario");
        }
    }
}
