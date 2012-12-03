using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class TipoParametroMap : EntityTypeConfiguration<TipoParametro>
    {
        public TipoParametroMap()
        {
            // Primary Key
            this.HasKey(t => t.TipoParametroId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            this.Property(t => t.Tipo)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("TIPOS_PARAMETRO");
            this.Property(t => t.TipoParametroId).HasColumnName("ID_TPPR");
            this.Property(t => t.Dicionario).HasColumnName("DESC_TPPR");
            this.Property(t => t.Tipo).HasColumnName("TIPO_TPPR");
            this.Property(t => t.Dicionario).HasColumnName("DICIONARIO_TPPR");
        }
    }
}