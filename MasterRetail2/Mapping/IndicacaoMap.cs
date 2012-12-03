using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class IndicacaoMap : EntityTypeConfiguration<Indicacao>
    {
        public IndicacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IndicacaoId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("INDICACOES");
            this.Property(t => t.IndicacaoId).HasColumnName("COD_IND");
            this.Property(t => t.Descricao).HasColumnName("DESCRICAO_IND");
            this.Property(t => t.Observacao).HasColumnName("OBS_IND");
        }
    }
}