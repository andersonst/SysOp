using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class Ecf_FuncionarioMap : EntityTypeConfiguration<Ecf_Funcionario>
    {
        public Ecf_FuncionarioMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.NOME)
                .HasMaxLength(100);

            this.Property(t => t.TELEFONE)
                .HasMaxLength(10);

            this.Property(t => t.CELULAR)
                .HasMaxLength(10);

            this.Property(t => t.EMAIL)
                .HasMaxLength(250);

            this.Property(t => t.NIVEL_AUTORIZACAO)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ecf_funcionario", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.NOME).HasColumnName("NOME");
            this.Property(t => t.TELEFONE).HasColumnName("TELEFONE");
            this.Property(t => t.CELULAR).HasColumnName("CELULAR");
            this.Property(t => t.EMAIL).HasColumnName("EMAIL");
            this.Property(t => t.COMISSAO_VISTA).HasColumnName("COMISSAO_VISTA");
            this.Property(t => t.COMISSAO_PRAZO).HasColumnName("COMISSAO_PRAZO");
            this.Property(t => t.NIVEL_AUTORIZACAO).HasColumnName("NIVEL_AUTORIZACAO");
        }
    }
}
