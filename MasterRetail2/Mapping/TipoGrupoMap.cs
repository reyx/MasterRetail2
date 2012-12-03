using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class TipoGrupoMap : EntityTypeConfiguration<TipoGrupo>
    {
        public TipoGrupoMap()
        {
            // Primary Key
            this.HasKey(t => t.TipoGrupoId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TIPOS_GRUPO");
            this.Property(t => t.TipoGrupoId).HasColumnName("ID_TPGR");
            this.Property(t => t.Descricao).HasColumnName("DESC_TPGR");
        }
    }
}