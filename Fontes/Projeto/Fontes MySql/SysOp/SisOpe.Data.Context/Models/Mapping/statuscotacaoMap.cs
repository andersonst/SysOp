using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class statuscotacaoMap : EntityTypeConfiguration<statuscotacao>
    {
        public statuscotacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdStatusCotacao);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("statuscotacao", "sysop");
            this.Property(t => t.IdStatusCotacao).HasColumnName("IdStatusCotacao");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
        }
    }
}
