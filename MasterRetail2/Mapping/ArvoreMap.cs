using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ArvoreMap : EntityTypeConfiguration<Arvore>
    {
        public ArvoreMap()
        {
            // Primary Key
            this.HasKey(t => t.ArvoreId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ARVORES");
            this.Property(t => t.ArvoreId).HasColumnName("ID_ARV");
            this.Property(t => t.ProdutoId).HasColumnName("COD_PROD");
            this.Property(t => t.Lote).HasColumnName("LOTE_ARV");
            this.Property(t => t.Observacao).HasColumnName("OBS_ARV");

            // Relationships
            this.HasOptional(t => t.Produto)
                .WithMany(t => t.Arvores)
                .HasForeignKey(d => d.ProdutoId);

        }
    }
}