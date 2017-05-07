using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class ecf_empresaMap : EntityTypeConfiguration<Ecf_Empresa>
    {
        public ecf_empresaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RAZAO_SOCIAL)
                .HasMaxLength(150);

            this.Property(t => t.NOME_FANTASIA)
                .HasMaxLength(150);

            this.Property(t => t.CNPJ)
                .HasMaxLength(14);

            this.Property(t => t.INSCRICAO_ESTADUAL)
                .HasMaxLength(30);

            this.Property(t => t.INSCRICAO_MUNICIPAL)
                .HasMaxLength(30);

            this.Property(t => t.MATRIZ_FILIAL)
                .HasMaxLength(1);

            this.Property(t => t.ENDERECO)
                .HasMaxLength(100);

            this.Property(t => t.COMPLEMENTO)
                .HasMaxLength(100);

            this.Property(t => t.BAIRRO)
                .HasMaxLength(50);

            this.Property(t => t.CIDADE)
                .HasMaxLength(50);

            this.Property(t => t.UF)
                .HasMaxLength(2);

            this.Property(t => t.CEP)
                .HasMaxLength(8);

            this.Property(t => t.FONE1)
                .HasMaxLength(10);

            this.Property(t => t.FONE2)
                .HasMaxLength(10);

            this.Property(t => t.CONTATO)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("ecf_empresa", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_EMPRESA).HasColumnName("ID_EMPRESA");
            this.Property(t => t.RAZAO_SOCIAL).HasColumnName("RAZAO_SOCIAL");
            this.Property(t => t.NOME_FANTASIA).HasColumnName("NOME_FANTASIA");
            this.Property(t => t.CNPJ).HasColumnName("CNPJ");
            this.Property(t => t.INSCRICAO_ESTADUAL).HasColumnName("INSCRICAO_ESTADUAL");
            this.Property(t => t.INSCRICAO_MUNICIPAL).HasColumnName("INSCRICAO_MUNICIPAL");
            this.Property(t => t.MATRIZ_FILIAL).HasColumnName("MATRIZ_FILIAL");
            this.Property(t => t.DATA_CADASTRO).HasColumnName("DATA_CADASTRO");
            this.Property(t => t.ENDERECO).HasColumnName("ENDERECO");
            this.Property(t => t.COMPLEMENTO).HasColumnName("COMPLEMENTO");
            this.Property(t => t.BAIRRO).HasColumnName("BAIRRO");
            this.Property(t => t.CIDADE).HasColumnName("CIDADE");
            this.Property(t => t.CODIGO_MUNICIPIO_IBGE).HasColumnName("CODIGO_MUNICIPIO_IBGE");
            this.Property(t => t.UF).HasColumnName("UF");
            this.Property(t => t.CEP).HasColumnName("CEP");
            this.Property(t => t.FONE1).HasColumnName("FONE1");
            this.Property(t => t.FONE2).HasColumnName("FONE2");
            this.Property(t => t.CONTATO).HasColumnName("CONTATO");

            // Relationships
            this.HasRequired(t => t.ecf_empresa2)
                .WithMany(t => t.ecf_empresa1)
                .HasForeignKey(d => d.ID_EMPRESA);

        }
    }
}
