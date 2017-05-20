using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Ecf_Dav_CabecalhoMap : EntityTypeConfiguration<Ecf_Dav_Cabecalho>
    {
        public Ecf_Dav_CabecalhoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.NOME_DESTINATARIO)
                .HasMaxLength(100);

            this.Property(t => t.CPF_CNPJ_DESTINATARIO)
                .HasMaxLength(14);

            this.Property(t => t.SITUACAO)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ecf_dav_cabecalho", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CCF).HasColumnName("CCF");
            this.Property(t => t.COO).HasColumnName("COO");
            this.Property(t => t.NOME_DESTINATARIO).HasColumnName("NOME_DESTINATARIO");
            this.Property(t => t.CPF_CNPJ_DESTINATARIO).HasColumnName("CPF_CNPJ_DESTINATARIO");
            this.Property(t => t.DATA_HORA_EMISSAO).HasColumnName("DATA_HORA_EMISSAO");
            this.Property(t => t.SITUACAO).HasColumnName("SITUACAO");
            this.Property(t => t.VALOR).HasColumnName("VALOR");
        }
    }
}
