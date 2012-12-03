using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class VolumeEntradaMap : EntityTypeConfiguration<VolumeEntrada>
    {
        public VolumeEntradaMap()
        {
            // Primary Key
            this.HasKey(t => t.VolumeEntradaId);

            // Properties
            // Table & Column Mappings
            this.ToTable("VOLUMES_ENTRADA");
            this.Property(t => t.VolumeEntradaId).HasColumnName("ID_VLVD");
            this.Property(t => t.VolumeId).HasColumnName("ID_VOL");
            this.Property(t => t.EntradaId).HasColumnName("ID_ENTR");

            // Relationships
            this.HasOptional(t => t.Entrada)
                .WithMany(t => t.Volumes)
                .HasForeignKey(d => d.EntradaId);

            this.HasOptional(t => t.Volume)
                .WithMany(t => t.Entradas)
                .HasForeignKey(d => d.VolumeId);

        }
    }
}