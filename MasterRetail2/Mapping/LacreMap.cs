using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class LacreMap : EntityTypeConfiguration<Lacre>
    {
        public LacreMap()
        {
            // Primary Key
            this.HasKey(t => t.LacreId);

            // Properties
            this.Property(t => t.Numero)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LACRES");
            this.Property(t => t.LacreId).HasColumnName("ID_LACRE");
            this.Property(t => t.Numero).HasColumnName("NUMERO_LACRE");
            this.Property(t => t.VolumeId).HasColumnName("ID_VOL");

            // Relationships
            this.HasOptional(t => t.Volume)
                .WithMany(t => t.Lacres)
                .HasForeignKey(d => d.VolumeId);

        }
    }
}