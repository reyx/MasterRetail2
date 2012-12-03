using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class UfMap : EntityTypeConfiguration<Uf>
    {
        public UfMap()
        {
            // Primary Key
            this.HasKey(t => t.UfId);

            // Properties
            this.Property(t => t.Sigla)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.Nome)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UFS");
            this.Property(t => t.UfId).HasColumnName("ID_UF");
            this.Property(t => t.Sigla).HasColumnName("SIGLA_UF");
            this.Property(t => t.Nome).HasColumnName("NOME_UF");
            this.Property(t => t.CodigoIbge).HasColumnName("CODIBGE_UF");
        }
    }
}