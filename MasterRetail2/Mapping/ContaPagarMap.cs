using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ContaPagarMap : EntityTypeConfiguration<ContaPagar>
    {
        public ContaPagarMap()
        {
            // Primary Key
            this.HasKey(t => t.ContaPagarId);

            // Properties
            this.Property(t => t.Letra)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("CONTAS_PAGAR");
            this.Property(t => t.ContaPagarId).HasColumnName("ID_CTPG");
            this.Property(t => t.Numero).HasColumnName("NUMERO_CTPG");
            this.Property(t => t.Letra).HasColumnName("LETRA_CTPG");
            this.Property(t => t.EntradaId).HasColumnName("ID_ENTR");
            this.Property(t => t.FornecedorId).HasColumnName("COD_FORN");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.Emissao).HasColumnName("EMISSAO_CTPG");
            this.Property(t => t.Vencimento).HasColumnName("VENCTO_CTPG");
            this.Property(t => t.Pagamento).HasColumnName("PAGTO_CTPG");
            this.Property(t => t.Valor).HasColumnName("VALOR_CTPG");
            this.Property(t => t.Desconto).HasColumnName("DESCONTO_CTPG");
            this.Property(t => t.Juros).HasColumnName("JUROS_CTPG");
            this.Property(t => t.ValorPago).HasColumnName("VALPAG_CTPG");
            this.Property(t => t.TipoDespesaId).HasColumnName("ID_TPDS");
            this.Property(t => t.Historico).HasColumnName("HISTORICO_CTPG");
            this.Property(t => t.TipoCobrancaId).HasColumnName("COD_TPCB");
            this.Property(t => t.ContaCorrenteId).HasColumnName("ID_CTCR");

            // Relationships
            this.HasOptional(t => t.ContaCorrente)
                .WithMany(t => t.ContasPagar)
                .HasForeignKey(d => d.ContaCorrenteId);

            this.HasOptional(t => t.Entrada)
                .WithMany(t => t.ContasPagar)
                .HasForeignKey(d => d.EntradaId);

            this.HasOptional(t => t.Fornecedor)
                .WithMany(t => t.ContasPagar)
                .HasForeignKey(d => d.FornecedorId);

            this.HasOptional(t => t.Loja)
                .WithMany(t => t.ContasPagar)
                .HasForeignKey(d => d.LojaId);

            this.HasOptional(t => t.TipoCobranca)
                .WithMany(t => t.ContasPagar)
                .HasForeignKey(d => d.TipoCobrancaId);

            this.HasOptional(t => t.TipoDespesa)
                .WithMany(t => t.ContasPagar)
                .HasForeignKey(d => d.TipoDespesaId);

        }
    }
}