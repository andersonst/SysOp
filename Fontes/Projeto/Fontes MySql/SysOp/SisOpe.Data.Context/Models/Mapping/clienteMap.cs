using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class clienteMap : EntityTypeConfiguration<cliente>
    {
        public clienteMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.NOME)
                .HasMaxLength(150);

            this.Property(t => t.CPF_CNPJ)
                .HasMaxLength(14);

            this.Property(t => t.RG)
                .HasMaxLength(20);

            this.Property(t => t.ORGAO_RG)
                .HasMaxLength(10);

            this.Property(t => t.INSCRICAO_ESTADUAL)
                .HasMaxLength(30);

            this.Property(t => t.INSCRICAO_MUNICIPAL)
                .HasMaxLength(30);

            this.Property(t => t.TIPO_PESSOA)
                .HasMaxLength(1);

            this.Property(t => t.EXCLUIDO)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("cliente", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_SITUACAO_CLI).HasColumnName("ID_SITUACAO_CLI");
            this.Property(t => t.NOME).HasColumnName("NOME");
            this.Property(t => t.CPF_CNPJ).HasColumnName("CPF_CNPJ");
            this.Property(t => t.RG).HasColumnName("RG");
            this.Property(t => t.ORGAO_RG).HasColumnName("ORGAO_RG");
            this.Property(t => t.INSCRICAO_ESTADUAL).HasColumnName("INSCRICAO_ESTADUAL");
            this.Property(t => t.INSCRICAO_MUNICIPAL).HasColumnName("INSCRICAO_MUNICIPAL");
            this.Property(t => t.DESDE).HasColumnName("DESDE");
            this.Property(t => t.TIPO_PESSOA).HasColumnName("TIPO_PESSOA");
            this.Property(t => t.EXCLUIDO).HasColumnName("EXCLUIDO");
            this.Property(t => t.DATA_CADASTRO).HasColumnName("DATA_CADASTRO");

            // Relationships
            this.HasRequired(t => t.situacao_cli)
                .WithMany(t => t.clientes)
                .HasForeignKey(d => d.ID_SITUACAO_CLI);

        }
    }
}
