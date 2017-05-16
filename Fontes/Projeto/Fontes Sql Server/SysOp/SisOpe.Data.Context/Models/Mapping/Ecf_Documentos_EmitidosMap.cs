using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Ecf_Documentos_EmitidosMap : EntityTypeConfiguration<Ecf_Documentos_Emitidos>
    {
        public Ecf_Documentos_EmitidosMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.TIPO)
                .HasMaxLength(2);

            this.Property(t => t.SINCRONIZADO)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ecf_documentos_emitidos", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_ECF_MOVIMENTO).HasColumnName("ID_ECF_MOVIMENTO");
            this.Property(t => t.DATA_HORA_EMISSAO).HasColumnName("DATA_HORA_EMISSAO");
            this.Property(t => t.TIPO).HasColumnName("TIPO");
            this.Property(t => t.COO).HasColumnName("COO");
            this.Property(t => t.SINCRONIZADO).HasColumnName("SINCRONIZADO");

            // Relationships
            this.HasRequired(t => t.ecf_movimento)
                .WithMany(t => t.ecf_documentos_emitidos)
                .HasForeignKey(d => d.ID_ECF_MOVIMENTO);

        }
    }
}
