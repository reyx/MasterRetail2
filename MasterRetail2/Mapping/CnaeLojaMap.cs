using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class CnaeLojaMap : EntityTypeConfiguration<CnaeLoja>
    {
        public CnaeLojaMap()
        {
            // Primary Key
            this.HasKey(t => t.CnaeLojaId);

            // Properties
            // Table & Column Mappings
            this.ToTable("CNAES_LOJA");
            this.Property(t => t.CnaeLojaId).HasColumnName("ID_CNLJ");
            this.Property(t => t.CnaeId).HasColumnName("ID_CNAE");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");

            // Relationships
            this.HasOptional(t => t.Loja)
                .WithMany(t => t.CnaesLoja)
                .HasForeignKey(d => d.LojaId);

        }
    }
}