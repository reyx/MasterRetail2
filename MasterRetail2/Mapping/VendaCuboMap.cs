using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class VendaCuboMap : EntityTypeConfiguration<VendaCubo>
    {
        public VendaCuboMap()
        {
            // Primary Key
            this.HasKey(t => t.VendaCuboId);

            // Properties
            this.Property(t => t.Data)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("VENDAS_CUBO");
            this.Property(t => t.VendaCuboId).HasColumnName("ID_VDCB");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.ValorMercadoria).HasColumnName("VLRMERC_VDA");
            this.Property(t => t.Desconto).HasColumnName("DESCONTO_VDA");
            this.Property(t => t.Acrescimo).HasColumnName("ACRESCIMO_VDA");
            this.Property(t => t.TaxaEntrega).HasColumnName("TXENTR_VDA");
            this.Property(t => t.Servico).HasColumnName("SERVICO_VDA");
            this.Property(t => t.Ipi).HasColumnName("IPI_VDA");
            this.Property(t => t.BaseIcms).HasColumnName("BASEICMS_VDA");
            this.Property(t => t.Icms).HasColumnName("ICMS_VDA");
            this.Property(t => t.Pessoas).HasColumnName("PESSOAS_VDA");
            this.Property(t => t.Data).HasColumnName("DATA_VDA");
            this.Property(t => t.Devolucao).HasColumnName("DEVOLUCAO_ITVD");

            // Relationships
            this.HasOptional(t => t.Loja)
                .WithMany(t => t.VendasCubo)
                .HasForeignKey(d => d.LojaId);

        }
    }
}