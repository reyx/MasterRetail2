using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class RegiaoMap : EntityTypeConfiguration<Regiao>
    {
        public RegiaoMap()
        {
            // Primary Key
            this.HasKey(t => t.RegiaoId);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("REGIOES");
            this.Property(t => t.RegiaoId).HasColumnName("COD_REG");
            this.Property(t => t.Nome).HasColumnName("NOME_REG");
        }
    }
}