using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class MensagemMap : EntityTypeConfiguration<Mensagem>
    {
        public MensagemMap()
        {
            // Primary Key
            this.HasKey(t => t.MensagemId);

            // Properties
            this.Property(t => t.Tela)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Fechar)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Emitente)
                .HasMaxLength(30);

            this.Property(t => t.Opcoes)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("MENSAGENS");
            this.Property(t => t.MensagemId).HasColumnName("ID_MSG");
            this.Property(t => t.Tela).HasColumnName("TELA_MSG");
            this.Property(t => t.QuantidadeExibicoes).HasColumnName("QTDEXIB_MSG");
            this.Property(t => t.Intervalo).HasColumnName("INTERVALO_MSG");
            this.Property(t => t.DataInicial).HasColumnName("DATAINI_MSG");
            this.Property(t => t.DataFinal).HasColumnName("DATAFIN_MSG");
            this.Property(t => t.Fechar).HasColumnName("FECHAR_MSG");
            this.Property(t => t.Tempo).HasColumnName("TEMPO_MSG");
            this.Property(t => t.Emitente).HasColumnName("EMITENTE_MSG");
            this.Property(t => t.Texto).HasColumnName("MENSAGEM_MSG");
            this.Property(t => t.Pesquisa).HasColumnName("PESQUISA_MSG");
            this.Property(t => t.MinimoRespostas).HasColumnName("MINRESP_MSG");
            this.Property(t => t.MaximoRespostas).HasColumnName("MAXRESP_MSG");
            this.Property(t => t.Opcoes).HasColumnName("OPCOES_MSG");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.ValorGrupoId).HasColumnName("ID_VLGR");

            // Relationships
            this.HasOptional(t => t.Loja)
                .WithMany(t => t.Mensagens)
                .HasForeignKey(d => d.LojaId);

            this.HasOptional(t => t.ValoresGrupo)
                .WithMany(t => t.Mensagens)
                .HasForeignKey(d => d.ValorGrupoId);

        }
    }
}