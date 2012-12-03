using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ValorGrupoMap : EntityTypeConfiguration<ValorGrupo>
    {
        public ValorGrupoMap()
        {
            // Primary Key
            this.HasKey(t => t.ValorGrupoId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VALORES_GRUPO");
            this.Property(t => t.ValorGrupoId).HasColumnName("ID_VLGR");
            this.Property(t => t.TipoGrupoId).HasColumnName("ID_TPGR");
            this.Property(t => t.Descricao).HasColumnName("DESC_VLGR");

            // Relationships
            this.HasOptional(t => t.TipoGrupo)
                .WithMany(t => t.ValoresGrupo)
                .HasForeignKey(d => d.TipoGrupoId);

        }
    }
}