using SisOpe.Domain.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Ecf_ContadorMap : EntityTypeConfiguration<Ecf_Contador>
    {
        public Ecf_ContadorMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CPF)
                .HasMaxLength(11);

            this.Property(t => t.CNPJ)
                .HasMaxLength(14);

            this.Property(t => t.NOME)
                .HasMaxLength(100);

            this.Property(t => t.INSCRICAO_CRC)
                .HasMaxLength(15);

            this.Property(t => t.FONE)
                .HasMaxLength(15);

            this.Property(t => t.FAX)
                .HasMaxLength(15);

            this.Property(t => t.LOGRADOURO)
                .HasMaxLength(100);

            this.Property(t => t.COMPLEMENTO)
                .HasMaxLength(100);

            this.Property(t => t.BAIRRO)
                .HasMaxLength(30);

            this.Property(t => t.CEP)
                .HasMaxLength(8);

            this.Property(t => t.UF)
                .HasMaxLength(2);

            this.Property(t => t.EMAIL)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("ecf_contador", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_ECF_EMPRESA).HasColumnName("ID_ECF_EMPRESA");
            this.Property(t => t.CPF).HasColumnName("CPF");
            this.Property(t => t.CNPJ).HasColumnName("CNPJ");
            this.Property(t => t.NOME).HasColumnName("NOME");
            this.Property(t => t.INSCRICAO_CRC).HasColumnName("INSCRICAO_CRC");
            this.Property(t => t.FONE).HasColumnName("FONE");
            this.Property(t => t.FAX).HasColumnName("FAX");
            this.Property(t => t.LOGRADOURO).HasColumnName("LOGRADOURO");
            this.Property(t => t.NUMERO).HasColumnName("NUMERO");
            this.Property(t => t.COMPLEMENTO).HasColumnName("COMPLEMENTO");
            this.Property(t => t.BAIRRO).HasColumnName("BAIRRO");
            this.Property(t => t.CEP).HasColumnName("CEP");
            this.Property(t => t.CODIGO_MUNICIPIO).HasColumnName("CODIGO_MUNICIPIO");
            this.Property(t => t.UF).HasColumnName("UF");
            this.Property(t => t.EMAIL).HasColumnName("EMAIL");

            // Relationships
            this.HasRequired(t => t.ecf_empresa)
                .WithMany(t => t.ecf_contador)
                .HasForeignKey(d => d.ID_ECF_EMPRESA);

        }
    }
}
