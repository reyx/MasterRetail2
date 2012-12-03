using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ParcelamentoSubtipoRecebimentoMap : EntityTypeConfiguration<ParcelamentoSubtipoRecebimento>
    {
        public ParcelamentoSubtipoRecebimentoMap()
        {
            // Primary Key
            this.HasKey(t => t.ParcelamentoSubtipoRecebimentoId);

            // Properties
            this.Property(t => t.Decricao)
                .HasMaxLength(40);

            this.Property(t => t.SequenciaNumerica)
                .HasMaxLength(8);

            this.Property(t => t.SequenciaLetra)
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("PARCELAMENTOS_SUBTIPO_RECEBIMENTO");
            this.Property(t => t.ParcelamentoSubtipoRecebimentoId).HasColumnName("COD_PRST");
            this.Property(t => t.SubtipoRecebimentoId).HasColumnName("COD_STRC");
            this.Property(t => t.Decricao).HasColumnName("DESC_PRST");
            this.Property(t => t.SequenciaNumerica).HasColumnName("SEQNUM_PRST");
            this.Property(t => t.SequenciaLetra).HasColumnName("SEQLETRA_PRST");
            this.Property(t => t.Desconto).HasColumnName("DESCONTO_PRST");
            this.Property(t => t.Dia1).HasColumnName("DIAS1_PRST");
            this.Property(t => t.Dia2).HasColumnName("DIAS2_PRST");
            this.Property(t => t.Dia3).HasColumnName("DIAS3_PRST");
            this.Property(t => t.Dia4).HasColumnName("DIAS4_PRST");
            this.Property(t => t.Dia5).HasColumnName("DIAS5_PRST");
            this.Property(t => t.Dia6).HasColumnName("DIAS6_PRST");

            // Relationships
            this.HasOptional(t => t.SubtipoRecebimento)
                .WithMany(t => t.Parcelamentos)
                .HasForeignKey(d => d.SubtipoRecebimentoId);

        }
    }
}