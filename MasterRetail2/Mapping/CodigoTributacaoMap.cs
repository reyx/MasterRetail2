using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class CodigoTributacaoMap : EntityTypeConfiguration<CodigoTributacao>
    {
        public CodigoTributacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.CodigoTributacaoId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CODIGOS_TRIBUTACAO");
            this.Property(t => t.CodigoTributacaoId).HasColumnName("COD_CDTR");
            this.Property(t => t.Descricao).HasColumnName("DESC_CDTR");
            this.Property(t => t.AliquotaIcms).HasColumnName("ALIQICMS");
        }
    }
}