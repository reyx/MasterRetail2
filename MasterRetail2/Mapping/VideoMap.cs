using Rcky.MasterRetail2.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class VideoMap : EntityTypeConfiguration<Video>
    {
        public VideoMap()
        {
            // Primary Key
            this.HasKey(t => t.VideoId);

            // Properties
            this.Property(t => t.VideoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Titulo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VIDEOS");
            this.Property(t => t.VideoId).HasColumnName("ID_VID");
            this.Property(t => t.Guid).HasColumnName("GUID_VID");
            this.Property(t => t.Titulo).HasColumnName("TITULO_VID");
            this.Property(t => t.Texto).HasColumnName("TEXTO_VID");
            this.Property(t => t.Data).HasColumnName("DATA_VID");
            this.Property(t => t.Url).HasColumnName("URL_VID");
            this.Property(t => t.Imagem).HasColumnName("IMAGEM_VID");
        }
    }
}