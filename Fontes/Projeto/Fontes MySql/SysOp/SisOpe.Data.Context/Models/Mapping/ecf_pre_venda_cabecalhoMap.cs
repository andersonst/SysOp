using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Ecf_Pre_Venda_CabecalhoMap : EntityTypeConfiguration<Ecf_Pre_Venda_Cabecalho>
    {
        public Ecf_Pre_Venda_CabecalhoMap()
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
