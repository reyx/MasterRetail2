using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
    public class ProdutoListaMap : EntityTypeConfiguration<ProdutoLista>
    {
        public ProdutoListaMap()
        {
            // Primary Key
            this.HasKey(t => t.ProdutoListaId);

            // Properties
            // Table & Column Mappings
            this.ToTable("PRODUTO_LISTA");
            this.Property(t => t.ProdutoListaId).HasColumnName("ID_PDLS");
            this.Property(t => t.ProdutoId).HasColumnName("COD_PROD");
            this.Property(t => t.ListaId).HasColumnName("COD_LISTA");
            this.Property(t => t.Custo).HasColumnName("CUSTO_PDLS");
            this.Property(t => t.Margem).HasColumnName("MARGEM_PDLS");
            this.Property(t => t.Preco).HasColumnName("PRECO_PDLS");

            // Relationships
            this.HasOptional(t => t.Lista)
                .WithMany(t => t.ProdutosLista)
                .HasForeignKey(d => d.ListaId);

            this.HasOptional(t => t.Produto)
                .WithMany(t => t.Listas)
                .HasForeignKey(d => d.ProdutoId);

        }
    }
}