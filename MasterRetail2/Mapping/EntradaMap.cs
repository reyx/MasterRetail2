using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Entities;

namespace Rcky.MasterRetail2.Mapping
{
    public class EntradaMap : EntityTypeConfiguration<Entrada>
    {
        public EntradaMap()
        {
            // Primary Key
            this.HasKey(t => t.EntradaId);

            // Properties
            this.Property(t => t.Condicional)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Tipo)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Status)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ModalidadeFrete)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ENTRADAS");
            //this.Property(t => t.ID_ENTR).HasColumnName("ID_ENTR");
            //this.Property(t => t.NUMERO_ENTR).HasColumnName("NUMERO_ENTR");
            //this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            //this.Property(t => t.FornecedorId).HasColumnName("COD_FORN");
            //this.Property(t => t.CFOP_NTOP).HasColumnName("CFOP_NTOP");
            //this.Property(t => t.CFOP_NTOP_TRAN_ENTR).HasColumnName("CFOP_NTOP_TRAN_ENTR");
            //this.Property(t => t.OperadorId).HasColumnName("ID_OPER");
            //this.Property(t => t.ID_VDA).HasColumnName("ID_VDA");
            //this.Property(t => t.CondicaoPagamentoId).HasColumnName("COD_CDPG");
            //this.Property(t => t.VendedorId).HasColumnName("COD_VEND");
            //this.Property(t => t.TransportadorId).HasColumnName("COD_TRAN");
            //this.Property(t => t.ID_VEIC).HasColumnName("ID_VEIC");
            //this.Property(t => t.DATA_ENTR).HasColumnName("DATA_ENTR");
            //this.Property(t => t.EMISSAO_ENTR).HasColumnName("EMISSAO_ENTR");
            //this.Property(t => t.CONDICIONAL_ENTR).HasColumnName("CONDICIONAL_ENTR");
            //this.Property(t => t.BICMS_ENTR).HasColumnName("BICMS_ENTR");
            //this.Property(t => t.ICMS_ENTR).HasColumnName("ICMS_ENTR");
            //this.Property(t => t.BICMSST_ENTR).HasColumnName("BICMSST_ENTR");
            //this.Property(t => t.ICMSST_ENTR).HasColumnName("ICMSST_ENTR");
            //this.Property(t => t.IPI_ENTR).HasColumnName("IPI_ENTR");
            //this.Property(t => t.IPIST_ENTR).HasColumnName("IPIST_ENTR");
            //this.Property(t => t.PIS_ENTR).HasColumnName("PIS_ENTR");
            //this.Property(t => t.PISST_ENTR).HasColumnName("PISST_ENTR");
            //this.Property(t => t.COFINS_ENTR).HasColumnName("COFINS_ENTR");
            //this.Property(t => t.COFINSST_ENTR).HasColumnName("COFINSST_ENTR");
            //this.Property(t => t.VLRMERC_ENTR).HasColumnName("VLRMERC_ENTR");
            //this.Property(t => t.FRETE_ENTR).HasColumnName("FRETE_ENTR");
            //this.Property(t => t.SEGURO_ENTR).HasColumnName("SEGURO_ENTR");
            //this.Property(t => t.DESCONTO_ENTR).HasColumnName("DESCONTO_ENTR");
            //this.Property(t => t.DESP_ACESSORIA_ENTR).HasColumnName("DESP_ACESSORIA_ENTR");
            //this.Property(t => t.VLRTOT_ENTR).HasColumnName("VLRTOT_ENTR");
            //this.Property(t => t.OBS_ENTR).HasColumnName("OBS_ENTR");
            //this.Property(t => t.TIPO_ENTR).HasColumnName("TIPO_ENTR");
            //this.Property(t => t.STATUS_ENTR).HasColumnName("STATUS_ENTR");
            //this.Property(t => t.ID_ENPS_FORN_ENTR).HasColumnName("ID_ENPS_FORN_ENTR");
            //this.Property(t => t.ID_ENPS_ENT_ENTR).HasColumnName("ID_ENPS_ENT_ENTR");
            //this.Property(t => t.ID_ENPS_LOJA_ENTR).HasColumnName("ID_ENPS_LOJA_ENTR");
            //this.Property(t => t.ID_ENPS_RET_ENTR).HasColumnName("ID_ENPS_RET_ENTR");
            //this.Property(t => t.ID_ENPS_TRAN_ENTR).HasColumnName("ID_ENPS_TRAN_ENTR");
            //this.Property(t => t.II_ENTR).HasColumnName("II_ENTR");
            //this.Property(t => t.BIRRF_ENTR).HasColumnName("BIRRF_ENTR");
            //this.Property(t => t.IRRF_ENTR).HasColumnName("IRRF_ENTR");
            //this.Property(t => t.BPREV_ENTR).HasColumnName("BPREV_ENTR");
            //this.Property(t => t.PREV_ENTR).HasColumnName("PREV_ENTR");
            //this.Property(t => t.RIPI_ENTR).HasColumnName("RIPI_ENTR");
            //this.Property(t => t.RPIS_ENTR).HasColumnName("RPIS_ENTR");
            //this.Property(t => t.RCOFINS_ENTR).HasColumnName("RCOFINS_ENTR");
            //this.Property(t => t.RCSLL_ENTR).HasColumnName("RCSLL_ENTR");
            //this.Property(t => t.MODFRETE_ENTR).HasColumnName("MODFRETE_ENTR");
            //this.Property(t => t.BICMS_TRAN_ENTR).HasColumnName("BICMS_TRAN_ENTR");
            //this.Property(t => t.PICMS_TRAN_ENTR).HasColumnName("PICMS_TRAN_ENTR");
            //this.Property(t => t.ICMS_TRAN_ENTR).HasColumnName("ICMS_TRAN_ENTR");
            //this.Property(t => t.VALOR_TRAN_ENTR).HasColumnName("VALOR_TRAN_ENTR");
            //this.Property(t => t.PESOLIQ_ENTR).HasColumnName("PESOLIQ_ENTR");
            //this.Property(t => t.PESOBRT_ENTR).HasColumnName("PESOBRT_ENTR");

            //// Relationships
            //this.HasOptional(t => t.CONDICOES_PAGAMENTO)
            //    .WithMany(t => t.ENTRADAS)
            //    .HasForeignKey(d => d.CondicaoPagamentoId);

            //this.HasOptional(t => t.ENDERECOS_PESSOA)
            //    .WithMany(t => t.ENTRADAS)
            //    .HasForeignKey(d => d.ID_ENPS_ENT_ENTR);

            //this.HasOptional(t => t.ENDERECOS_PESSOA1)
            //    .WithMany(t => t.ENTRADAS1)
            //    .HasForeignKey(d => d.ID_ENPS_FORN_ENTR);

            //this.HasOptional(t => t.ENDERECOS_PESSOA2)
            //    .WithMany(t => t.ENTRADAS2)
            //    .HasForeignKey(d => d.ID_ENPS_LOJA_ENTR);

            //this.HasOptional(t => t.ENDERECOS_PESSOA3)
            //    .WithMany(t => t.ENTRADAS3)
            //    .HasForeignKey(d => d.ID_ENPS_RET_ENTR);

            //this.HasOptional(t => t.ENDERECOS_PESSOA4)
            //    .WithMany(t => t.ENTRADAS4)
            //    .HasForeignKey(d => d.ID_ENPS_TRAN_ENTR);

            //this.HasOptional(t => t.VENDA)
            //    .WithMany(t => t.ENTRADAS)
            //    .HasForeignKey(d => d.ID_VDA);

            //this.HasOptional(t => t.FORNECEDOR)
            //    .WithMany(t => t.ENTRADAS)
            //    .HasForeignKey(d => d.FornecedorId);

            //this.HasOptional(t => t.Loja)
            //    .WithMany(t => t.ENTRADAS)
            //    .HasForeignKey(d => d.LojaId);

            //this.HasOptional(t => t.Operador)
            //    .WithMany(t => t.ENTRADAS)
            //    .HasForeignKey(d => d.OperadorId);

            //this.HasOptional(t => t.TRANSPORTADOR)
            //    .WithMany(t => t.ENTRADAS)
            //    .HasForeignKey(d => d.TransportadorId);

            //this.HasOptional(t => t.VEICULO)
            //    .WithMany(t => t.ENTRADAS)
            //    .HasForeignKey(d => d.ID_VEIC);

            //this.HasOptional(t => t.VENDEDOR)
            //    .WithMany(t => t.ENTRADAS)
            //    .HasForeignKey(d => d.VendedorId);

        }
    }
}