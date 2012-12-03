using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class GrupoMenuMap : EntityTypeConfiguration<GrupoMenu>
    {
        public GrupoMenuMap()
        {
            // Primary Key
            this.HasKey(t => t.GrupoMenuId);

            // Properties
            this.Property(t => t.Item)
                .HasMaxLength(20);

            this.Property(t => t.Icone)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("GRUPOS_MENU");
            this.Property(t => t.GrupoMenuId).HasColumnName("ID_GRMN");
            this.Property(t => t.SubmenuId).HasColumnName("ID_SBMN");
            this.Property(t => t.Item).HasColumnName("ITEM_GRMN");
            this.Property(t => t.Ordem).HasColumnName("ORGEM_GRMN");
            this.Property(t => t.Icone).HasColumnName("ICONE_GRMN");

            // Relationships
            this.HasOptional(t => t.Submenu)
                .WithMany(t => t.Grupos)
                .HasForeignKey(d => d.SubmenuId);

        }
    }
}