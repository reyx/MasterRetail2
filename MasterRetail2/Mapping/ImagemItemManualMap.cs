using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
	public class ImagemItemManualMap : EntityTypeConfiguration<ImagemItemManual>
	{
        public ImagemItemManualMap()
		{
			// Primary Key
			this.HasKey(t => t.ImagemItemManualId);

			// Properties
			// Table & Column Mappings
			this.ToTable("IMAGENS_ITEN_MANUAL");
			this.Property(t => t.ImagemItemManualId).HasColumnName("ID_IMIM");
			this.Property(t => t.ItemManualId).HasColumnName("ID_ITMN");
            this.Property(t => t.Descricao).HasColumnName("DESC_IMIM");

			// Relationships
			this.HasOptional(t => t.ItemManual)
				.WithMany(t => t.ImagensItemManual)
				.HasForeignKey(d => d.ItemManualId);
		}
	}
}