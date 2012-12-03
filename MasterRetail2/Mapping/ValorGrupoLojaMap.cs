using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ValorGrupoLojaMap : EntityTypeConfiguration<ValorGrupoLoja>
    {
        public ValorGrupoLojaMap()
        {
            // Primary Key
            this.HasKey(t => t.ValorGrupoLojaId);

            // Properties
            // Table & Column Mappings
            this.ToTable("VALORES_GRUPOS_LOJA");
            this.Property(t => t.ValorGrupoLojaId).HasColumnName("ID_VGLJ");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.ValorGrupoId).HasColumnName("ID_VLGR");

            // Relationships
            this.HasOptional(t => t.Loja)
                .WithMany(t => t.ValoresGrupoLoja)
                .HasForeignKey(d => d.LojaId);

            this.HasOptional(t => t.ValorGrupo)
                .WithMany(t => t.Lojas)
                .HasForeignKey(d => d.ValorGrupoId);

        }
    }
}