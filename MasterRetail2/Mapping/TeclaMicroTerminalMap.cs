using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class TeclaMicroTerminalMap : EntityTypeConfiguration<TeclaMicroTerminal>
    {
        public TeclaMicroTerminalMap()
        {
            // Primary Key
            this.HasKey(t => t.TeclaMicroTerminalId);

            // Properties
            // Table & Column Mappings
            this.ToTable("TECLAS_MICRO_TERMINAL");
            this.Property(t => t.TeclaMicroTerminalId).HasColumnName("ID_TCMT");
            this.Property(t => t.MicroTerminalId).HasColumnName("ID_MTER");
            this.Property(t => t.Tecla).HasColumnName("TECLA_TCMT");
            this.Property(t => t.ProdutoId).HasColumnName("COD_PROD");

            // Relationships
            this.HasOptional(t => t.MicroTerminal)
                .WithMany(t => t.TeclasMicroTerminal)
                .HasForeignKey(d => d.MicroTerminalId);

            this.HasOptional(t => t.Produto)
                .WithMany(t => t.TeclasMicroTerminal)
                .HasForeignKey(d => d.ProdutoId);

        }
    }
}