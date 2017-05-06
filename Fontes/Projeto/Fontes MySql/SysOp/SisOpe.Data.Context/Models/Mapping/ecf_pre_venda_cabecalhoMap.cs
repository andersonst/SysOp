using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class ecf_pre_venda_cabecalhoMap : EntityTypeConfiguration<ecf_pre_venda_cabecalho>
    {
        public ecf_pre_venda_cabecalhoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SITUACAO)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ecf_pre_venda_cabecalho", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DATA_HORA_PV).HasColumnName("DATA_HORA_PV");
            this.Property(t => t.SITUACAO).HasColumnName("SITUACAO");
            this.Property(t => t.CCF).HasColumnName("CCF");
            this.Property(t => t.VALOR).HasColumnName("VALOR");
        }
    }
}
