using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ModeloEcfMap : EntityTypeConfiguration<ModeloEcf>
    {
        public ModeloEcfMap()
        {
            // Primary Key
            this.HasKey(t => t.ModeloEcfId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("MODELOS_ECF");
            this.Property(t => t.ModeloEcfId).HasColumnName("ID_MDEC");
            this.Property(t => t.MarcaEcfId).HasColumnName("ID_MECF");
            this.Property(t => t.Descricao).HasColumnName("DESC_MDEC");
            this.Property(t => t.Observacao).HasColumnName("OBS_MDEC");

            // Relationships
            this.HasOptional(t => t.MarcaEcf)
                .WithMany(t => t.ModelosEcf)
                .HasForeignKey(d => d.MarcaEcfId);

        }
    }
}