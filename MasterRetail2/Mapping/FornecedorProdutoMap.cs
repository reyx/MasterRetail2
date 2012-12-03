using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
    public class FornecedorProdutoMap : EntityTypeConfiguration<FornecedorProduto>
    {
        public FornecedorProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.FornecedorProdutoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("FORNECEDORES_PRODUTO");
            this.Property(t => t.FornecedorProdutoId).HasColumnName("ID_FRPR");
            this.Property(t => t.FornecedorId).HasColumnName("COD_FORN");
            this.Property(t => t.ProdutoId).HasColumnName("COD_PROD");
            this.Property(t => t.Codigo).HasColumnName("COD_FNPD");

            // Relationships
            this.HasOptional(t => t.Fornecedor)
                .WithMany(t => t.FornecedorProdutos)
                .HasForeignKey(d => d.FornecedorId);

            this.HasOptional(t => t.Produto)
                .WithMany(t => t.Fornecedores)
                .HasForeignKey(d => d.ProdutoId);

        }
    }
}