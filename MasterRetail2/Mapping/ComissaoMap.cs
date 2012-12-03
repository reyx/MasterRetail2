using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
    public class ComissaoMap : EntityTypeConfiguration<Comissao>
    {
        public ComissaoMap()
        {
            // Primary Key
            this.HasKey(t => t.ComissaoId);

            // Properties
            this.Property(t => t.Status)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Numero)
                .HasMaxLength(12);

            this.Property(t => t.Letra)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Tipo)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("COMISSOES");
            this.Property(t => t.ComissaoId).HasColumnName("ID_COMS");
            this.Property(t => t.Status).HasColumnName("STATUS_COMS");
            this.Property(t => t.Faturamento).HasColumnName("DATAFAT_COMS");
            this.Property(t => t.Vencimento).HasColumnName("DATAVENC_COMS");
            this.Property(t => t.Numero).HasColumnName("NUMERO_COMS");
            this.Property(t => t.Letra).HasColumnName("LETRA_COMS");
            this.Property(t => t.ValorPago).HasColumnName("VALPAG_COMS");
            this.Property(t => t.Valor).HasColumnName("VALOR_COMS");
            this.Property(t => t.Tipo).HasColumnName("TIPO_COMS");
            this.Property(t => t.ClienteId).HasColumnName("COD_CLI");
            this.Property(t => t.VendedorId).HasColumnName("COD_VEND");
            this.Property(t => t.CondicaoPagamentoId).HasColumnName("COD_CDPG");
            this.Property(t => t.Parcela).HasColumnName("PARCELA_COMS");

            // Relationships
            this.HasOptional(t => t.Cliente)
                .WithMany(t => t.Comissoes)
                .HasForeignKey(d => d.ClienteId);

            this.HasOptional(t => t.CondicaoPagamento)
                .WithMany(t => t.Comissoes)
                .HasForeignKey(d => d.CondicaoPagamentoId);

            this.HasOptional(t => t.Vendedor)
                .WithMany(t => t.Comissoes)
                .HasForeignKey(d => d.VendedorId);

        }
    }
}