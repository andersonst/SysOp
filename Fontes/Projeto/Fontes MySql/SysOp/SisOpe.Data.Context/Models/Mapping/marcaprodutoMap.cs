using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class MarcaProdutoMap : EntityTypeConfiguration<MarcaProduto>
    {
        public MarcaProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdMarcaProduto);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("marcaproduto", "sysop");
            this.Property(t => t.IdMarcaProduto).HasColumnName("IdMarcaProduto");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
