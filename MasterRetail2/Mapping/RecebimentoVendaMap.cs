using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class RecebimentoVendaMap : EntityTypeConfiguration<RecebimentoVenda>
    {
        public RecebimentoVendaMap()
        {
            // Primary Key
            this.HasKey(t => t.RecebimentoVendaId);

            // Properties
            // Table & Column Mappings
            this.ToTable("RECEBIMENTOS_VENDA");
            this.Property(t => t.RecebimentoVendaId).HasColumnName("ID_RCVD");
            this.Property(t => t.VendaId).HasColumnName("ID_VDA");
            this.Property(t => t.Sequencia).HasColumnName("SEQ_RCVD");
            this.Property(t => t.TipoRecebimentoId).HasColumnName("COD_TPRC");
            this.Property(t => t.SubtipoRecebimentoId).HasColumnName("COD_STRC");
            this.Property(t => t.ParcelamentoSubtipoRecebimentoId).HasColumnName("COD_PRST");
            this.Property(t => t.Valor).HasColumnName("VALOR_RCVD");
            this.Property(t => t.Liquido).HasColumnName("LIQUIDO_RCVD");

            // Relationships
            this.HasOptional(t => t.ParcelamentoSubtipoRecebimento)
                .WithMany(t => t.RecebimentosVenda)
                .HasForeignKey(d => d.ParcelamentoSubtipoRecebimentoId);

            this.HasOptional(t => t.SubtipoRecebimento)
                .WithMany(t => t.RecebimentosVenda)
                .HasForeignKey(d => d.SubtipoRecebimentoId);

            this.HasOptional(t => t.TipoRecebimento)
                .WithMany(t => t.RecebimentosVenda)
                .HasForeignKey(d => d.TipoRecebimentoId);

            this.HasOptional(t => t.Venda)
                .WithMany(t => t.Recebimentos)
                .HasForeignKey(d => d.VendaId);

        }
    }
}