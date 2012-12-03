using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class TransacaoEstoqueMap : EntityTypeConfiguration<TransacaoEstoque>
    {
        public TransacaoEstoqueMap()
        {
            // Primary Key
            this.HasKey(t => t.TransacaoEstoqueId);

            // Properties
            this.Property(t => t.Documento)
                .HasMaxLength(20);

            this.Property(t => t.Operacao)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("TRANSACOES_ESTOQUE");
            this.Property(t => t.TransacaoEstoqueId).HasColumnName("ID_TRES");
            this.Property(t => t.OperadorId).HasColumnName("ID_OPER");
            this.Property(t => t.FornecedorId).HasColumnName("COD_FORN");
            this.Property(t => t.ClienteId).HasColumnName("COD_CLI");
            this.Property(t => t.LocalEstoqueId).HasColumnName("COD_LCES");
            this.Property(t => t.TipoMovimentoId).HasColumnName("COD_TPMV");
            this.Property(t => t.ValorProdutoId).HasColumnName("ID_VLPR");
            this.Property(t => t.Data).HasColumnName("DATA_TRES");
            this.Property(t => t.Quantidade).HasColumnName("QTDE_TRES");
            this.Property(t => t.EstoqueAnterior).HasColumnName("ESTANT_TRES");
            this.Property(t => t.EstoqueAtual).HasColumnName("ESTATU_TRES");
            this.Property(t => t.Valor).HasColumnName("VALOR_TRES");
            this.Property(t => t.Documento).HasColumnName("DOCTO_TRES");
            this.Property(t => t.Operacao).HasColumnName("OPERACAO_TRES");
            this.Property(t => t.ItemEntradaId).HasColumnName("ID_ITEN");
            this.Property(t => t.ItemVendaId).HasColumnName("ID_ITVD");
            this.Property(t => t.DataSistema).HasColumnName("DATASIS");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.ItemMovimentoId).HasColumnName("ID_ITMV");
            this.Property(t => t.ItemInventarioId).HasColumnName("ID_ITIV");

            // Relationships
            this.HasOptional(t => t.Cliente)
                .WithMany(t => t.TransacoesEstoque)
                .HasForeignKey(d => d.ClienteId);

            this.HasOptional(t => t.Fornecedor)
                .WithMany(t => t.TransacoesEstoque)
                .HasForeignKey(d => d.FornecedorId);

            this.HasOptional(t => t.ItemEntrada)
                .WithMany(t => t.TransacoesEstoque)
                .HasForeignKey(d => d.ItemEntradaId);

            this.HasOptional(t => t.ItemInventario)
                .WithMany(t => t.TransacoesEstoque)
                .HasForeignKey(d => d.ItemInventarioId);

            this.HasOptional(t => t.ItemMovimento)
                .WithMany(t => t.TransacoesEstoque)
                .HasForeignKey(d => d.ItemMovimentoId);

            this.HasOptional(t => t.ItemVenda)
                .WithMany(t => t.TransacoesEstoque)
                .HasForeignKey(d => d.ItemVendaId);

            this.HasOptional(t => t.LocalEstoque)
                .WithMany(t => t.TransacoesEstoque)
                .HasForeignKey(d => d.LocalEstoqueId);

            this.HasOptional(t => t.Loja)
                .WithMany(t => t.TransacoesEstoque)
                .HasForeignKey(d => d.LojaId);

            this.HasOptional(t => t.Operador)
                .WithMany(t => t.TransacoesEstoque)
                .HasForeignKey(d => d.OperadorId);

            this.HasOptional(t => t.TipoMovimento)
                .WithMany(t => t.TransacoesEstoque)
                .HasForeignKey(d => d.TipoMovimentoId);

            this.HasOptional(t => t.ValorProduto)
                .WithMany(t => t.TransacoesEstoque)
                .HasForeignKey(d => d.ValorProdutoId);

        }
    }
}