using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class PerfilMap : EntityTypeConfiguration<Perfil>
    {
        public PerfilMap()
        {
            // Primary Key
            this.HasKey(t => t.PerfilId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("PERFIS");
            this.Property(t => t.PerfilId).HasColumnName("ID_PERF");
            this.Property(t => t.Descricao).HasColumnName("DESC_PERF");
            this.Property(t => t.Nivel).HasColumnName("NIVEL_PERF");
        }
    }
}