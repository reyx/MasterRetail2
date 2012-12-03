using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class TipoParametroPdvMap : EntityTypeConfiguration<TipoParametroPdv>
    {
        public TipoParametroPdvMap()
        {
            // Primary Key
            this.HasKey(t => t.TipoParametroPdvId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            this.Property(t => t.Tipo)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("TIPOS_PARAMETROS_PDV");
            this.Property(t => t.TipoParametroPdvId).HasColumnName("ID_TPPD");
            this.Property(t => t.Descricao).HasColumnName("DESC_TPPD");
            this.Property(t => t.Tipo).HasColumnName("TIPO_TPPD");
        }
    }
}