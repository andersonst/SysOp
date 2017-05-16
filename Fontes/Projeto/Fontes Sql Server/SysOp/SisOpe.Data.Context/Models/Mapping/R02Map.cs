using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class R02Map : EntityTypeConfiguration<R02>
    {
        public R02Map()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.HORA_EMISSAO)
                .HasMaxLength(8);

            this.Property(t => t.SINCRONIZADO)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("r02", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_ECF_CAIXA).HasColumnName("ID_ECF_CAIXA");
            this.Property(t => t.ID_OPERADOR).HasColumnName("ID_OPERADOR");
            this.Property(t => t.ID_IMPRESSORA).HasColumnName("ID_IMPRESSORA");
            this.Property(t => t.CRZ).HasColumnName("CRZ");
            this.Property(t => t.COO).HasColumnName("COO");
            this.Property(t => t.CRO).HasColumnName("CRO");
            this.Property(t => t.DATA_MOVIMENTO).HasColumnName("DATA_MOVIMENTO");
            this.Property(t => t.DATA_EMISSAO).HasColumnName("DATA_EMISSAO");
            this.Property(t => t.HORA_EMISSAO).HasColumnName("HORA_EMISSAO");
            this.Property(t => t.VENDA_BRUTA).HasColumnName("VENDA_BRUTA");
            this.Property(t => t.GRANDE_TOTAL).HasColumnName("GRANDE_TOTAL");
            this.Property(t => t.SINCRONIZADO).HasColumnName("SINCRONIZADO");

            // Relationships
            this.HasRequired(t => t.ecf_caixa)
                .WithMany(t => t.r02)
                .HasForeignKey(d => d.ID_ECF_CAIXA);

        }
    }
}
