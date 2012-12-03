using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class LancamentoMap : EntityTypeConfiguration<Lancamento>
    {
        public LancamentoMap()
        {
            // Primary Key
            this.HasKey(t => t.LancamentoId);

            // Properties
            this.Property(t => t.Documento)
                .HasMaxLength(20);

            this.Property(t => t.Operacao)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("LANCAMENTOS");
            this.Property(t => t.LancamentoId).HasColumnName("ID_LANC");
            this.Property(t => t.ContaCorrenteId).HasColumnName("ID_CTCR");
            this.Property(t => t.Data).HasColumnName("DATA_LANC");
            this.Property(t => t.HistoricoLancamentoId).HasColumnName("COD_HIST");
            this.Property(t => t.OperadorId).HasColumnName("ID_OPER");
            this.Property(t => t.TipoDespesaId).HasColumnName("ID_TPDS");
            this.Property(t => t.Documento).HasColumnName("DOCTO_LANC");
            this.Property(t => t.Valor).HasColumnName("VALOR_LANC");
            this.Property(t => t.Operacao).HasColumnName("OPER_LANC");
            this.Property(t => t.SaldoAnterior).HasColumnName("SALDOANT_LANC");
            this.Property(t => t.SaldoAtual).HasColumnName("SALDOATU_LANC");
            this.Property(t => t.Observacao).HasColumnName("OBS_LANC");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");

            // Relationships
            this.HasOptional(t => t.ContaCorrente)
                .WithMany(t => t.Lancamentos)
                .HasForeignKey(d => d.ContaCorrenteId);

            this.HasOptional(t => t.HistoricoLancamento)
                .WithMany(t => t.Lancamentos)
                .HasForeignKey(d => d.HistoricoLancamentoId);

            this.HasOptional(t => t.Loja)
                .WithMany(t => t.Lancamentos)
                .HasForeignKey(d => d.LojaId);

            this.HasOptional(t => t.Operador)
                .WithMany(t => t.Lancamentos)
                .HasForeignKey(d => d.OperadorId);

            this.HasOptional(t => t.TipoDespesa)
                .WithMany(t => t.Lancamentos)
                .HasForeignKey(d => d.TipoDespesaId);

        }
    }
}