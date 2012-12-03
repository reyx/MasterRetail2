using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class CondicaoPagamentoMap : EntityTypeConfiguration<CondicaoPagamento>
    {
        public CondicaoPagamentoMap()
        {
            // Primary Key
            this.HasKey(t => t.CondicaoPagamentoId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(30);

            this.Property(t => t.Tipo)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("CONDICOES_PAGAMENTO");
            this.Property(t => t.CondicaoPagamentoId).HasColumnName("COD_CDPG");
            this.Property(t => t.Descricao).HasColumnName("DESC_CDPG");
            this.Property(t => t.Tipo).HasColumnName("TIPO_CDPG");
            this.Property(t => t.Taxa).HasColumnName("TAXA_CDPG");
            this.Property(t => t.Tac).HasColumnName("TAC_CDPG");
            this.Property(t => t.Coeficiente).HasColumnName("COEF_CDPG");
            this.Property(t => t.Dia).HasColumnName("DIA_CDPG");
            this.Property(t => t.Parcelas).HasColumnName("PARCELAS_CDPG");
        }
    }
}