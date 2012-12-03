using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ContaReceberMap : EntityTypeConfiguration<ContaReceber>
    {
        public ContaReceberMap()
        {
            // Primary Key
            this.HasKey(t => t.ContaReceberId);

            // Properties
            this.Property(t => t.Letra)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SituacaoEmissao)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("CONTAS_RECEBER");
            this.Property(t => t.ContaCorrenteId).HasColumnName("ID_CTRC");
            this.Property(t => t.Numero).HasColumnName("NUMERO_CTRC");
            this.Property(t => t.Letra).HasColumnName("LETRA_CTRC");
            this.Property(t => t.ClienteId).HasColumnName("COD_CLI");
            this.Property(t => t.BandeiraId).HasColumnName("COD_BAN");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.EntradaId).HasColumnName("ID_ENTR");
            this.Property(t => t.Emissao).HasColumnName("EMISSAO_CTRC");
            this.Property(t => t.Vencimento).HasColumnName("VENCTO_CTRC");
            this.Property(t => t.Pagamento).HasColumnName("PAGTO_CTRC");
            this.Property(t => t.Valor).HasColumnName("VALOR_CTRC");
            this.Property(t => t.Desconto).HasColumnName("DESCONTO_CTRC");
            this.Property(t => t.Juros).HasColumnName("JUROS_CTRC");
            this.Property(t => t.ValorRecebido).HasColumnName("VALREC_CTRC");
            this.Property(t => t.SituacaoEmissao).HasColumnName("SITEMISSAO_CTRC");
            this.Property(t => t.Historico).HasColumnName("HISTORICO_CTRC");
            this.Property(t => t.VendaId).HasColumnName("ID_VDA");
            this.Property(t => t.ContaCorrenteId).HasColumnName("ID_CTCR");

            // Relationships
            this.HasOptional(t => t.Bandeira)
                .WithMany(t => t.ContasReceber)
                .HasForeignKey(d => d.BandeiraId);

            this.HasOptional(t => t.Cliente)
                .WithMany(t => t.ContasReceber)
                .HasForeignKey(d => d.ClienteId);

            this.HasOptional(t => t.ContaCorrente)
                .WithMany(t => t.ContasReceber)
                .HasForeignKey(d => d.ContaCorrenteId);

            this.HasOptional(t => t.Entrada)
                .WithMany(t => t.ContasReceber)
                .HasForeignKey(d => d.EntradaId);

            this.HasOptional(t => t.Loja)
                .WithMany(t => t.ContasReceber)
                .HasForeignKey(d => d.LojaId);

            this.HasOptional(t => t.Venda)
                .WithMany(t => t.ContasReceber)
                .HasForeignKey(d => d.VendaId);

        }
    }
}