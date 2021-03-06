using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Mapping
{
    public class FormaPagamentoMap : EntityTypeConfiguration<FormaPagamento>
    {
        public FormaPagamentoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdFormaPagamento);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("FormaPagamento");
            this.Property(t => t.IdFormaPagamento).HasColumnName("IdFormaPagamento");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
        }
    }
}
