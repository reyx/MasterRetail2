using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class VeiculoMap : EntityTypeConfiguration<Veiculo>
    {
        public VeiculoMap()
        {
            // Primary Key
            this.HasKey(t => t.VeiculoId);

            // Properties
            this.Property(t => t.Placa)
                .IsFixedLength()
                .HasMaxLength(7);

            this.Property(t => t.Rntc)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("VEICULOS");
            this.Property(t => t.VeiculoId).HasColumnName("ID_VEIC");
            this.Property(t => t.Placa).HasColumnName("PLACA_VEIC");
            this.Property(t => t.CidadeId).HasColumnName("ID_CID");
            this.Property(t => t.Rntc).HasColumnName("RNTC_VEIC");
            this.Property(t => t.TransportadorId).HasColumnName("COD_TRAN");

            // Relationships
            this.HasOptional(t => t.Transportador)
                .WithMany(t => t.Veiculos)
                .HasForeignKey(d => d.TransportadorId);

        }
    }
}