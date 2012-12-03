using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ArquivoRecebidoMap : EntityTypeConfiguration<ArquivoRecebido>
    {
        public ArquivoRecebidoMap()
        {
            // Primary Key
            this.HasKey(t => t.ArquivoRecebidoId);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(15);

            this.Property(t => t.Situacao)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Ip)
                .HasMaxLength(15);

            this.Property(t => t.QuantidadeOcorrencias)
                .IsFixedLength()
                .HasMaxLength(1);            

            this.Property(t => t.SucessoString)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.Sucesso);

            this.Property(t => t.Versao)
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("ARQUIVOS_RECEBIDOS");
            this.Property(t => t.ArquivoRecebidoId).HasColumnName("ID_ARQR");
            this.Property(t => t.Nome).HasColumnName("NOME_ARQR");
            this.Property(t => t.Situacao).HasColumnName("SITUACAO_ARQR");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.Data).HasColumnName("DATA_ARQR");
            this.Property(t => t.Ip).HasColumnName("IP_ARQR");
            this.Property(t => t.Observacao).HasColumnName("OBS_ARQR");
            this.Property(t => t.InformacaoAdicional).HasColumnName("OBSCMTRBK_ARQR");
            this.Property(t => t.QuantidadeOcorrencias).HasColumnName("QTDEOCOR_ARQR");
            this.Property(t => t.SucessoString).HasColumnName("SUCESSO_ARQR");
            this.Property(t => t.Versao).HasColumnName("VERSAO_ARQR");

            // Relationships
            this.HasOptional(t => t.Loja)
                .WithMany(t => t.ArquivosRecebidos)
                .HasForeignKey(d => d.LojaId);

        }
    }
}