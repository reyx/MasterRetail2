using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class TipoMovimentoMap : EntityTypeConfiguration<TipoMovimento>
    {
        public TipoMovimentoMap()
        {
            // Primary Key
            this.HasKey(t => t.TipoMovimentoId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(30);

            this.Property(t => t.OperacaoProduto)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.OperacaoComponente)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("TIPOS_MOVIMENTO");
            this.Property(t => t.TipoMovimentoId).HasColumnName("COD_TPMV");
            this.Property(t => t.Descricao).HasColumnName("DESC_TPMV");
            this.Property(t => t.OperacaoProduto).HasColumnName("OPERPROD_TPMV");
            this.Property(t => t.OperacaoComponente).HasColumnName("OPERCOMP_TPMV");
            this.Property(t => t.TipoMovimentoAssociadoId).HasColumnName("COD_TPMV_AS");

            // Relationships
            this.HasOptional(t => t.TipoMovimentoAssociado)
                .WithMany(t => t.TiposMovimento)
                .HasForeignKey(d => d.TipoMovimentoAssociadoId);

        }
    }
}