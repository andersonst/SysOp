using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class ecf_recebimento_nao_fiscalMap : EntityTypeConfiguration<ecf_recebimento_nao_fiscal>
    {
        public ecf_recebimento_nao_fiscalMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.DESCRICAO)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ecf_recebimento_nao_fiscal", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_ECF_MOVIMENTO).HasColumnName("ID_ECF_MOVIMENTO");
            this.Property(t => t.DATA_RECBTO).HasColumnName("DATA_RECBTO");
            this.Property(t => t.DESCRICAO).HasColumnName("DESCRICAO");
            this.Property(t => t.VALOR).HasColumnName("VALOR");

            // Relationships
            this.HasRequired(t => t.ecf_movimento)
                .WithMany(t => t.ecf_recebimento_nao_fiscal)
                .HasForeignKey(d => d.ID_ECF_MOVIMENTO);

        }
    }
}
