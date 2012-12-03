using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
    public class EquipamentoProdutoMap : EntityTypeConfiguration<EquipamentoProduto>
    {
        public EquipamentoProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.EquipamentoProdutoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("EQUIPAMENTOS_PRODUTO");
            this.Property(t => t.EquipamentoProdutoId).HasColumnName("ID_EQPD");
            this.Property(t => t.ProdutoId).HasColumnName("COD_PROD");
            this.Property(t => t.EquipamentoId).HasColumnName("ID_EQUIP");
            this.Property(t => t.Quantidade).HasColumnName("QTDE_EQPD");

            // Relationships
            this.HasOptional(t => t.Equipamento)
                .WithMany(t => t.Produtos)
                .HasForeignKey(d => d.EquipamentoId);

            this.HasOptional(t => t.Produto)
                .WithMany(t => t.Equipamentos)
                .HasForeignKey(d => d.ProdutoId);

        }
    }
}