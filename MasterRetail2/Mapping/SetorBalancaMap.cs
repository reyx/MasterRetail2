using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class SetorBalancaMap : EntityTypeConfiguration<SetorBalanca>
    {
        public SetorBalancaMap()
        {
            // Primary Key
            this.HasKey(t => t.SetorBalancaId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("SETORES_BALANCA");
            this.Property(t => t.SetorBalancaId).HasColumnName("COD_STBL");
            this.Property(t => t.Descricao).HasColumnName("DESC_STBL");
        }
    }
}