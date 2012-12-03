using Rcky.MasterRetail2.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class MenuMap : EntityTypeConfiguration<Menu>
    {
        public MenuMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuId);

            // Properties
            this.Property(t => t.MenuId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Item)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MENUS");
            this.Property(t => t.MenuId).HasColumnName("ID_MENU");
            this.Property(t => t.Item).HasColumnName("ITEM_MENU");
            this.Property(t => t.ParentId).HasColumnName("ID_SBMN");

            // Relationships
            this.HasOptional(t => t.Parent)
                .WithMany(t => t.Menus)
                .HasForeignKey(d => d.ParentId);

        }
    }
}