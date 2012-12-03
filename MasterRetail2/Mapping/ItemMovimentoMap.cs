using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Entities;

namespace Rcky.MasterRetail2.Mapping
{
    public class ItemMovimentoMap : EntityTypeConfiguration<ItemMovimento>
    {
        public ItemMovimentoMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemMovimentoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ITENS_MOVIMENTO");
            this.Property(t => t.ItemMovimentoId).HasColumnName("ID_ITMV");
            this.Property(t => t.OperadorId).HasColumnName("ID_OPER");
            this.Property(t => t.MovimentoId).HasColumnName("ID_MVNT");
            this.Property(t => t.ValorProdutoId).HasColumnName("ID_VLPR");
            this.Property(t => t.TipoMovimentoId).HasColumnName("COD_TPMV");
            this.Property(t => t.TipoMovimentoDestinoId).HasColumnName("COD_TPMV_DS");
            this.Property(t => t.LocalEstoqueId).HasColumnName("COD_LCES");
            this.Property(t => t.LocalEstoqueDestinoId).HasColumnName("COD_LCES_DS");
            this.Property(t => t.Quantidade).HasColumnName("QTDE_ITMV");
            this.Property(t => t.LojaDestinoId).HasColumnName("COD_LOJA_DS");

            // Relationships
            this.HasOptional(t => t.LocalEstoqueDestino)
                .WithMany(t => t.ItensMovimentoDestino)
                .HasForeignKey(d => d.LocalEstoqueDestinoId);

            this.HasOptional(t => t.LocalEstoque)
                .WithMany(t => t.ItensMovimento)
                .HasForeignKey(d => d.LocalEstoqueId);

            this.HasOptional(t => t.Loja)
                .WithMany(t => t.ItensMovimento)
                .HasForeignKey(d => d.LojaDestinoId);

            this.HasOptional(t => t.Movimento)
                .WithMany(t => t.ItensMovimento)
                .HasForeignKey(d => d.MovimentoId);

            this.HasOptional(t => t.Operador)
                .WithMany(t => t.ItensMovimento)
                .HasForeignKey(d => d.OperadorId);

            this.HasOptional(t => t.TipoMovimentoDestino)
                .WithMany(t => t.ItensMovimentoDestino)
                .HasForeignKey(d => d.TipoMovimentoDestinoId);

            this.HasOptional(t => t.TipoMovimento)
                .WithMany(t => t.ItensMovimento)
                .HasForeignKey(d => d.TipoMovimentoId);

            this.HasOptional(t => t.ValorProduto)
                .WithMany(t => t.ItensMovimento)
                .HasForeignKey(d => d.ValorProdutoId);

        }
    }
}