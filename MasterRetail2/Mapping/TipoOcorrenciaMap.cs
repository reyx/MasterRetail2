using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class TipoOcorrenciaMap : EntityTypeConfiguration<TipoOcorrencia>
    {
        public TipoOcorrenciaMap()
        {
            // Primary Key
            this.HasKey(t => t.TipoOcorrenciaId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("TIPOS_OCORRENCIA");
            this.Property(t => t.TipoOcorrenciaId).HasColumnName("COD_TPOC");
            this.Property(t => t.Descricao).HasColumnName("DESC_TPOC");
        }
    }
}