using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class r06Map : EntityTypeConfiguration<R06>
    {
        public r06Map()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.DENOMINACAO)
                .HasMaxLength(2);

            this.Property(t => t.HORA_EMISSAO)
                .HasMaxLength(8);

            this.Property(t => t.SINCRONIZADO)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("r06", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_ECF_CAIXA).HasColumnName("ID_ECF_CAIXA");
            this.Property(t => t.ID_OPERADOR).HasColumnName("ID_OPERADOR");
            this.Property(t => t.ID_IMPRESSORA).HasColumnName("ID_IMPRESSORA");
            this.Property(t => t.COO).HasColumnName("COO");
            this.Property(t => t.GNF).HasColumnName("GNF");
            this.Property(t => t.GRG).HasColumnName("GRG");
            this.Property(t => t.CDC).HasColumnName("CDC");
            this.Property(t => t.DENOMINACAO).HasColumnName("DENOMINACAO");
            this.Property(t => t.DATA_EMISSAO).HasColumnName("DATA_EMISSAO");
            this.Property(t => t.HORA_EMISSAO).HasColumnName("HORA_EMISSAO");
            this.Property(t => t.SINCRONIZADO).HasColumnName("SINCRONIZADO");

            // Relationships
            this.HasRequired(t => t.ecf_caixa)
                .WithMany(t => t.r06)
                .HasForeignKey(d => d.ID_ECF_CAIXA);

        }
    }
}
