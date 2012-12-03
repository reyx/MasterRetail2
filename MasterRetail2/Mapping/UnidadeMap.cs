using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class UnidadeMap : EntityTypeConfiguration<Unidade>
    {
        public UnidadeMap()
        {
            // Primary Key
            this.HasKey(t => t.UnidadeId);

            // Properties
            this.Property(t => t.Codigo)
                .HasMaxLength(2);

            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UNIDADES");
            this.Property(t => t.UnidadeId).HasColumnName("ID_UNID");
            this.Property(t => t.Codigo).HasColumnName("COD_UNID");
            this.Property(t => t.Descricao).HasColumnName("DESC_UNID");


        }
    }
}