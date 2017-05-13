using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Sintegra_60mMap : EntityTypeConfiguration<Sintegra_60m>
    {
        public Sintegra_60mMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.NUMERO_SERIE_ECF)
                .HasMaxLength(20);

            this.Property(t => t.MODELO_DOCUMENTO_FISCAL)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("sintegra_60m", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DATA_EMISSAO).HasColumnName("DATA_EMISSAO");
            this.Property(t => t.NUMERO_SERIE_ECF).HasColumnName("NUMERO_SERIE_ECF");
            this.Property(t => t.NUMERO_EQUIPAMENTO).HasColumnName("NUMERO_EQUIPAMENTO");
            this.Property(t => t.MODELO_DOCUMENTO_FISCAL).HasColumnName("MODELO_DOCUMENTO_FISCAL");
            this.Property(t => t.COO_INICIAL).HasColumnName("COO_INICIAL");
            this.Property(t => t.COO_FINAL).HasColumnName("COO_FINAL");
            this.Property(t => t.CRZ).HasColumnName("CRZ");
            this.Property(t => t.CRO).HasColumnName("CRO");
            this.Property(t => t.VALOR_VENDA_BRUTA).HasColumnName("VALOR_VENDA_BRUTA");
            this.Property(t => t.VALOR_GRANDE_TOTAL).HasColumnName("VALOR_GRANDE_TOTAL");
        }
    }
}
