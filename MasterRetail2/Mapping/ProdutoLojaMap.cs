using Rcky.MasterRetail2.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ProdutoLojaMap : EntityTypeConfiguration<ProdutoLoja>
    {
        public ProdutoLojaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProdutoId, t.LojaId });

            // Properties
            this.Property(t => t.ProdutoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LojaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PesoCaixa)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TipoVenda)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TipoBaixa)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TipoEntrada)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Local)
                .HasMaxLength(10);

            this.Property(t => t.Cst)
                .HasMaxLength(3);

            this.Property(t => t.Cf)
                .HasMaxLength(10);

            this.Property(t => t.Impressora)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("PRODUTO_LOJA");
            this.Property(t => t.ProdutoId).HasColumnName("COD_PROD");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.PesoCaixa).HasColumnName("PSCAIXA_PDLJ");
            this.Property(t => t.Etiqueta).HasColumnName("ETIQPROG_PDLJ");
            this.Property(t => t.CoeficienteRoyalties).HasColumnName("COEFROYA_PDLJ");
            this.Property(t => t.TipoVenda).HasColumnName("TIPOVENDA_PDLJ");
            this.Property(t => t.TipoBaixa).HasColumnName("TIPOBAIXA_PDLJ");
            this.Property(t => t.TipoEntrada).HasColumnName("TIPOENTR_PDLJ");
            this.Property(t => t.EstoqueMinimo).HasColumnName("ESTMIN_PDLJ");
            this.Property(t => t.EstoqueMaximo).HasColumnName("ESTMAX_PDLJ");
            this.Property(t => t.Local).HasColumnName("LOCAL_PDLJ");
            this.Property(t => t.CodigoTributacaoId).HasColumnName("COD_CDTR");
            this.Property(t => t.PromocaoId).HasColumnName("COD_PROM");
            this.Property(t => t.Cst).HasColumnName("CST_PDLJ");
            this.Property(t => t.Ipi).HasColumnName("IPI_PDLJ");
            this.Property(t => t.Icms).HasColumnName("ICMS_PDLJ");
            this.Property(t => t.Reducao).HasColumnName("REDUCAO_PDLJ");
            this.Property(t => t.St).HasColumnName("SUBSTR_PDLJ");
            this.Property(t => t.IpiPeso).HasColumnName("IPIPESO_PDLJ");
            this.Property(t => t.Cf).HasColumnName("CF_PDLJ");
            this.Property(t => t.Impressora).HasColumnName("IMPRESSORA_PDLJ");

            // Relationships
            this.HasOptional(t => t.CodigosTributacao)
                .WithMany(t => t.ProdutosLoja)
                .HasForeignKey(d => d.CodigoTributacaoId);

            this.HasRequired(t => t.Loja)
                .WithMany(t => t.ProdutosLoja)
                .HasForeignKey(d => d.LojaId);

            this.HasRequired(t => t.Produto)
                .WithMany(t => t.Lojas)
                .HasForeignKey(d => d.ProdutoId);

            this.HasOptional(t => t.Promocao)
                .WithMany(t => t.ProdutosLoja)
                .HasForeignKey(d => d.PromocaoId);

        }
    }
}