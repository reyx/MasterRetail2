using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class LogradouroMap : EntityTypeConfiguration<Logradouro>
    {
        public LogradouroMap()
        {
            // Primary Key
            this.HasKey(t => t.LogradouroId);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("LOGRADOUROS");
            this.Property(t => t.LogradouroId).HasColumnName("ID_LOGRAD");
            this.Property(t => t.Nome).HasColumnName("NOME_LOGRAD");
        }
    }
}