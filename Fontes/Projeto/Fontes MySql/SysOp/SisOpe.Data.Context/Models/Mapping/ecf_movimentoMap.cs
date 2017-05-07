using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Ecf_MovimentoMap : EntityTypeConfiguration<Ecf_Movimento>
    {
        public Ecf_MovimentoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.STATUS_MOVIMENTO)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.SINCRONIZADO)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ecf_movimento", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_ECF_TURNO).HasColumnName("ID_ECF_TURNO");
            this.Property(t => t.ID_ECF_IMPRESSORA).HasColumnName("ID_ECF_IMPRESSORA");
            this.Property(t => t.ID_ECF_OPERADOR).HasColumnName("ID_ECF_OPERADOR");
            this.Property(t => t.ID_ECF_CAIXA).HasColumnName("ID_ECF_CAIXA");
            this.Property(t => t.ID_GERENTE_SUPERVISOR).HasColumnName("ID_GERENTE_SUPERVISOR");
            this.Property(t => t.DATA_HORA_ABERTURA).HasColumnName("DATA_HORA_ABERTURA");
            this.Property(t => t.DATA_HORA_FECHAMENTO).HasColumnName("DATA_HORA_FECHAMENTO");
            this.Property(t => t.TOTAL_SUPRIMENTO).HasColumnName("TOTAL_SUPRIMENTO");
            this.Property(t => t.TOTAL_SANGRIA).HasColumnName("TOTAL_SANGRIA");
            this.Property(t => t.TOTAL_NAO_FISCAL).HasColumnName("TOTAL_NAO_FISCAL");
            this.Property(t => t.TOTAL_VENDA).HasColumnName("TOTAL_VENDA");
            this.Property(t => t.TOTAL_DESCONTO).HasColumnName("TOTAL_DESCONTO");
            this.Property(t => t.TOTAL_ACRESCIMO).HasColumnName("TOTAL_ACRESCIMO");
            this.Property(t => t.TOTAL_FINAL).HasColumnName("TOTAL_FINAL");
            this.Property(t => t.TOTAL_RECEBIDO).HasColumnName("TOTAL_RECEBIDO");
            this.Property(t => t.TOTAL_TROCO).HasColumnName("TOTAL_TROCO");
            this.Property(t => t.TOTAL_CANCELADO).HasColumnName("TOTAL_CANCELADO");
            this.Property(t => t.STATUS_MOVIMENTO).HasColumnName("STATUS_MOVIMENTO");
            this.Property(t => t.SINCRONIZADO).HasColumnName("SINCRONIZADO");

            // Relationships
            this.HasRequired(t => t.ecf_caixa)
                .WithMany(t => t.ecf_movimento)
                .HasForeignKey(d => d.ID_ECF_CAIXA);
            this.HasRequired(t => t.ecf_impressora)
                .WithMany(t => t.ecf_movimento)
                .HasForeignKey(d => d.ID_ECF_IMPRESSORA);
            this.HasRequired(t => t.ecf_operador)
                .WithMany(t => t.ecf_movimento)
                .HasForeignKey(d => d.ID_ECF_OPERADOR);
            this.HasRequired(t => t.ecf_turno)
                .WithMany(t => t.ecf_movimento)
                .HasForeignKey(d => d.ID_ECF_TURNO);

        }
    }
}
