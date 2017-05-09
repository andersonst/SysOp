using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Ecf_Dav_DetalheMap : EntityTypeConfiguration<Ecf_Dav_Detalhe>
    {
        public Ecf_Dav_DetalheMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ecf_dav_detalhe", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_PRODUTO).HasColumnName("ID_PRODUTO");
            this.Property(t => t.ID_ECF_DAV).HasColumnName("ID_ECF_DAV");
            this.Property(t => t.QUANTIDADE).HasColumnName("QUANTIDADE");
            this.Property(t => t.VALOR_UNITARIO).HasColumnName("VALOR_UNITARIO");
            this.Property(t => t.VALOR_TOTAL).HasColumnName("VALOR_TOTAL");

            // Relationships
            this.HasRequired(t => t.ecf_dav_cabecalho)
                .WithMany(t => t.ecf_dav_detalhe)
                .HasForeignKey(d => d.ID_ECF_DAV);
            this.HasRequired(t => t.produto)
                .WithMany(t => t.ecf_dav_detalhe)
                .HasForeignKey(d => d.ID_PRODUTO);

        }
    }
}
