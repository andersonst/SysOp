using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SysOp.Data.Entidades.Mapping
{
    public class StatusCotacaoMap : EntityTypeConfiguration<StatusCotacaoEnt>
    {
        public StatusCotacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdStatusCotacao);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StatusCotacao");
            this.Property(t => t.IdStatusCotacao).HasColumnName("IdStatusCotacao");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
        }
    }
}
