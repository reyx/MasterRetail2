using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class LojaOperadorMap : EntityTypeConfiguration<LojaOperador>
    {
        public LojaOperadorMap()
        {
            // Primary Key
            this.HasKey(t => t.LojaOperadorId);

            // Properties
            this.Property(t => t.NivelLoja)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.NivelPdv)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.NivelRetaguarda)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("LOJAS_OPERADOR");
            this.Property(t => t.LojaOperadorId).HasColumnName("ID_LJOP");
            this.Property(t => t.OperadorId).HasColumnName("ID_OPER");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.NivelLoja).HasColumnName("NIVELLOJA_OPER");
            this.Property(t => t.NivelPdv).HasColumnName("NIVELPDV_LJOP");
            this.Property(t => t.NivelRetaguarda).HasColumnName("NIVELRET_LJOP");

            // Relationships
            this.HasOptional(t => t.Loja)
                .WithMany(t => t.LojasOperador)
                .HasForeignKey(d => d.LojaId);

            this.HasOptional(t => t.Operador)
                .WithMany(t => t.LojasOperador)
                .HasForeignKey(d => d.OperadorId);

        }
    }
}