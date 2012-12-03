using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class VolumeVendaMap : EntityTypeConfiguration<VolumeVenda>
    {
        public VolumeVendaMap()
        {
            // Primary Key
            this.HasKey(t => t.VolumeVendaId);

            // Properties
            // Table & Column Mappings
            this.ToTable("VOLUMES_VENDA");
            this.Property(t => t.VolumeVendaId).HasColumnName("ID_VLVD");
            this.Property(t => t.VolumeId).HasColumnName("ID_VOL");
            this.Property(t => t.VendaId).HasColumnName("ID_VDA");

            // Relationships
            this.HasOptional(t => t.Venda)
                .WithMany(t => t.Volumes)
                .HasForeignKey(d => d.VendaId);

            this.HasOptional(t => t.Volume)
                .WithMany(t => t.Vendas)
                .HasForeignKey(d => d.VolumeId);

        }
    }
}