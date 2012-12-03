using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class EcfMap : EntityTypeConfiguration<Ecf>
    {
        public EcfMap()
        {
            // Primary Key
            this.HasKey(t => t.EcfId);

            // Properties
            this.Property(t => t.Serie)
                .HasMaxLength(120);

            this.Property(t => t.Calculo)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.GrupoSangria)
                .HasMaxLength(2);

            this.Property(t => t.CodigoSangria)
                .HasMaxLength(2);

            this.Property(t => t.GrupoDeposito)
                .HasMaxLength(2);

            this.Property(t => t.CodigoDeposito)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("ECF");
            this.Property(t => t.EcfId).HasColumnName("ID_ECF");
            this.Property(t => t.ModeloEcfId).HasColumnName("ID_MDEC");
            this.Property(t => t.Serie).HasColumnName("SERIE_ECF");
            this.Property(t => t.Numero).HasColumnName("NUMERO_ECF");
            this.Property(t => t.Calculo).HasColumnName("CALC_ECF");
            this.Property(t => t.GrupoSangria).HasColumnName("GRPSANGRIA_ECF");
            this.Property(t => t.CodigoSangria).HasColumnName("CODSANGRIA_ECF");
            this.Property(t => t.GrupoDeposito).HasColumnName("GRPDEPOS_ECF");
            this.Property(t => t.CodigoDeposito).HasColumnName("CODDEPOS_ECF");

            // Relationships
            this.HasOptional(t => t.ModeloEcf)
                .WithMany(t => t.Ecfs)
                .HasForeignKey(d => d.ModeloEcfId);

        }
    }
}