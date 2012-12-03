using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class VolumeMap : EntityTypeConfiguration<Volume>
    {
        public VolumeMap()
        {
            // Primary Key
            this.HasKey(t => t.VolumeId);

            // Properties
            this.Property(t => t.Especie)
                .HasMaxLength(20);

            this.Property(t => t.Marca)
                .HasMaxLength(20);

            this.Property(t => t.Numeracao)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("VOLUMES");
            this.Property(t => t.VolumeId).HasColumnName("ID_VOL");
            this.Property(t => t.Quantidade).HasColumnName("QTDE_VOL");
            this.Property(t => t.Especie).HasColumnName("ESPECIE_VOL");
            this.Property(t => t.Marca).HasColumnName("MARCA_VOL");
            this.Property(t => t.Numeracao).HasColumnName("NUMERACAO_VOL");
            this.Property(t => t.PesoLiquido).HasColumnName("PESOLIQ_VOL");
            this.Property(t => t.PesoBruto).HasColumnName("PESOBRT_VOL");
        }
    }
}