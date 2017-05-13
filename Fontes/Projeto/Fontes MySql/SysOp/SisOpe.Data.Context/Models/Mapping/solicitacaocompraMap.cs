using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class SolicitacaoCompraMap : EntityTypeConfiguration<SolicitacaoCompra>
    {
        public SolicitacaoCompraMap()
        {
            // Primary Key
            this.HasKey(t => t.IdSolicitacaoCompra);

            // Properties
            // Table & Column Mappings
            this.ToTable("solicitacaocompra", "sysop");
            this.Property(t => t.IdSolicitacaoCompra).HasColumnName("IdSolicitacaoCompra");
            this.Property(t => t.IdAprovador).HasColumnName("IdAprovador");
            this.Property(t => t.Data).HasColumnName("Data");
        }
    }
}
