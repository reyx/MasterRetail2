using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class MovimentoMap : EntityTypeConfiguration<Movimento>
    {
        public MovimentoMap()
        {
            // Primary Key
            this.HasKey(t => t.MovimentoId);

            // Properties
            this.Property(t => t.Controle)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("MOVIMENTOS");
            this.Property(t => t.MovimentoId).HasColumnName("ID_MVNT");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.Data).HasColumnName("DATA_MVNT");
            this.Property(t => t.Controle).HasColumnName("CONTROLE_MVNT");
            this.Property(t => t.OperadorId).HasColumnName("ID_OPER");

            // Relationships
            this.HasOptional(t => t.Loja)
                .WithMany(t => t.Movimentos)
                .HasForeignKey(d => d.LojaId);

            this.HasOptional(t => t.Operador)
                .WithMany(t => t.Movimentos)
                .HasForeignKey(d => d.OperadorId);

        }
    }
}