using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisOpe.Data.Context.Models.Mapping
{
    public class ecf_configuracaoMap : EntityTypeConfiguration<Ecf_Configuracao>
    {
        public ecf_configuracaoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.MENSAGEM_CUPOM)
                .HasMaxLength(250);

            this.Property(t => t.PORTA_ECF)
                .HasMaxLength(10);

            this.Property(t => t.PORTA_PINPAD)
                .HasMaxLength(10);

            this.Property(t => t.PORTA_BALANCA)
                .HasMaxLength(10);

            this.Property(t => t.IP_SERVIDOR)
                .HasMaxLength(15);

            this.Property(t => t.IP_SITEF)
                .HasMaxLength(15);

            this.Property(t => t.TIPO_TEF)
                .HasMaxLength(2);

            this.Property(t => t.TITULO_TELA_CAIXA)
                .HasMaxLength(100);

            this.Property(t => t.CAMINHO_IMAGENS_PRODUTOS)
                .HasMaxLength(250);

            this.Property(t => t.CAMINHO_IMAGENS_MARKETING)
                .HasMaxLength(250);

            this.Property(t => t.CAMINHO_IMAGENS_LAYOUT)
                .HasMaxLength(250);

            this.Property(t => t.COR_JANELAS_INTERNAS)
                .HasMaxLength(20);

            this.Property(t => t.MARKETING_ATIVO)
                .HasMaxLength(1);

            this.Property(t => t.DESCRICAO_SUPRIMENTO)
                .HasMaxLength(20);

            this.Property(t => t.DESCRICAO_SANGRIA)
                .HasMaxLength(20);

            this.Property(t => t.SINCRONIZADO)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ecf_configuracao", "sysop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_ECF_IMPRESSORA).HasColumnName("ID_ECF_IMPRESSORA");
            this.Property(t => t.ID_ECF_RESOLUCAO).HasColumnName("ID_ECF_RESOLUCAO");
            this.Property(t => t.ID_ECF_CAIXA).HasColumnName("ID_ECF_CAIXA");
            this.Property(t => t.ID_ECF_EMPRESA).HasColumnName("ID_ECF_EMPRESA");
            this.Property(t => t.MENSAGEM_CUPOM).HasColumnName("MENSAGEM_CUPOM");
            this.Property(t => t.PORTA_ECF).HasColumnName("PORTA_ECF");
            this.Property(t => t.PORTA_PINPAD).HasColumnName("PORTA_PINPAD");
            this.Property(t => t.PORTA_BALANCA).HasColumnName("PORTA_BALANCA");
            this.Property(t => t.IP_SERVIDOR).HasColumnName("IP_SERVIDOR");
            this.Property(t => t.IP_SITEF).HasColumnName("IP_SITEF");
            this.Property(t => t.TIPO_TEF).HasColumnName("TIPO_TEF");
            this.Property(t => t.TITULO_TELA_CAIXA).HasColumnName("TITULO_TELA_CAIXA");
            this.Property(t => t.CAMINHO_IMAGENS_PRODUTOS).HasColumnName("CAMINHO_IMAGENS_PRODUTOS");
            this.Property(t => t.CAMINHO_IMAGENS_MARKETING).HasColumnName("CAMINHO_IMAGENS_MARKETING");
            this.Property(t => t.CAMINHO_IMAGENS_LAYOUT).HasColumnName("CAMINHO_IMAGENS_LAYOUT");
            this.Property(t => t.COR_JANELAS_INTERNAS).HasColumnName("COR_JANELAS_INTERNAS");
            this.Property(t => t.MARKETING_ATIVO).HasColumnName("MARKETING_ATIVO");
            this.Property(t => t.CFOP_ECF).HasColumnName("CFOP_ECF");
            this.Property(t => t.CFOP_NF2).HasColumnName("CFOP_NF2");
            this.Property(t => t.TIMEOUT_ECF).HasColumnName("TIMEOUT_ECF");
            this.Property(t => t.INTERVALO_ECF).HasColumnName("INTERVALO_ECF");
            this.Property(t => t.DESCRICAO_SUPRIMENTO).HasColumnName("DESCRICAO_SUPRIMENTO");
            this.Property(t => t.DESCRICAO_SANGRIA).HasColumnName("DESCRICAO_SANGRIA");
            this.Property(t => t.TEF_TIPO_GP).HasColumnName("TEF_TIPO_GP");
            this.Property(t => t.TEF_TEMPO_ESPERA).HasColumnName("TEF_TEMPO_ESPERA");
            this.Property(t => t.TEF_ESPERA_STS).HasColumnName("TEF_ESPERA_STS");
            this.Property(t => t.TEF_NUMERO_VIAS).HasColumnName("TEF_NUMERO_VIAS");
            this.Property(t => t.INDICE_GERENCIAL_DAV).HasColumnName("INDICE_GERENCIAL_DAV");
            this.Property(t => t.SINCRONIZADO).HasColumnName("SINCRONIZADO");

            // Relationships
            this.HasRequired(t => t.ecf_caixa)
                .WithMany(t => t.ecf_configuracao)
                .HasForeignKey(d => d.ID_ECF_CAIXA);
            this.HasRequired(t => t.ecf_empresa)
                .WithMany(t => t.ecf_configuracao)
                .HasForeignKey(d => d.ID_ECF_EMPRESA);
            this.HasRequired(t => t.ecf_resolucao)
                .WithMany(t => t.ecf_configuracao)
                .HasForeignKey(d => d.ID_ECF_RESOLUCAO);

        }
    }
}
