using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class formapagamentoMap : EntityTypeConfiguration<FormaPagamento>
    {
        public formapagamentoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdFormaPagamento);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("formapagamento", "sysop");
            this.Property(t => t.IdFormaPagamento).HasColumnName("IdFormaPagamento");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
        }
    }
}
