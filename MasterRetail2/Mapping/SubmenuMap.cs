using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Entities;

namespace Rcky.MasterRetail2.Mapping
{
    public class SubmenuMap : EntityTypeConfiguration<Submenu>
    {
        public SubmenuMap()
        {
            // Primary Key
            this.HasKey(t => t.SubmenuId);

            // Properties
            this.Property(t => t.Item)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("SUBMENUS");
            this.Property(t => t.SubmenuId).HasColumnName("ID_SBMN");
            this.Property(t => t.MenuId).HasColumnName("ID_MENU");
            this.Property(t => t.FuncaoProgramaId).HasColumnName("ID_FNPR");
            this.Property(t => t.Item).HasColumnName("ITEM_SBMN");
            this.Property(t => t.Ordem).HasColumnName("ORDEM_SBMN");

            // Relationships
            this.HasOptional(t => t.FuncoesPrograma)
                .WithMany(t => t.Submenus)
                .HasForeignKey(d => d.FuncaoProgramaId);

        }
    }
}