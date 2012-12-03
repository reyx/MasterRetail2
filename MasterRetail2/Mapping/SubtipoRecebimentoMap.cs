using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class SubtipoRecebimentoMap : EntityTypeConfiguration<SubtipoRecebimento>
    {
        public SubtipoRecebimentoMap()
        {
            // Primary Key
            this.HasKey(t => t.SubtipoRecebimentoId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("SUBTIPOS_RECEBIMENTO");
            this.Property(t => t.SubtipoRecebimentoId).HasColumnName("COD_STRC");
            this.Property(t => t.TipoRecebimentoId).HasColumnName("COD_TPRC");
            this.Property(t => t.Descricao).HasColumnName("DESC_STRC");
            this.Property(t => t.BandeiraId).HasColumnName("COD_BAN");

            // Relationships
            this.HasOptional(t => t.Bandeira)
                .WithMany(t => t.SubtiposRecebimento)
                .HasForeignKey(d => d.BandeiraId);

            this.HasOptional(t => t.TipoRecebimento)
                .WithMany(t => t.SubtiposRecebimento)
                .HasForeignKey(d => d.TipoRecebimentoId);

        }
    }
}