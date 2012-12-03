using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Entities;

namespace Rcky.MasterRetail2.Mapping
{
    public class PedidoCompraMap : EntityTypeConfiguration<PedidoCompra>
	{
        public PedidoCompraMap()
		{
			// Primary Key
			this.HasKey(t => t.PedidoCompraId);

			// Properties
            //this.Property(t => t.CONDICIONAL_PDCP)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.TIPO_PDCP)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.STATUS_PDCP)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.MODFRETE_PDCP)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //// Table & Column Mappings
            //this.ToTable("PEDIDOS_COMPRA");
            //this.Property(t => t.ID_PDCP).HasColumnName("ID_PDCP");
            //this.Property(t => t.NUMERO_PDCP).HasColumnName("NUMERO_PDCP");
            //this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            //this.Property(t => t.FornecedorId).HasColumnName("COD_FORN");
            //this.Property(t => t.CFOP_NTOP).HasColumnName("CFOP_NTOP");
            //this.Property(t => t.CFOP_NTOP_TRAN_PDCP).HasColumnName("CFOP_NTOP_TRAN_PDCP");
            //this.Property(t => t.OperadorId).HasColumnName("ID_OPER");
            ////this.Property(t => t.ID_VDA).HasColumnName("ID_VDA");
            //this.Property(t => t.CondicaoPagamentoId).HasColumnName("COD_CDPG");
            //this.Property(t => t.VendedorId).HasColumnName("COD_VEND");
            //this.Property(t => t.TransportadorId).HasColumnName("COD_TRAN");
            //this.Property(t => t.ID_VEIC).HasColumnName("ID_VEIC");
            //this.Property(t => t.DATA_PDCP).HasColumnName("DATA_PDCP");
            //this.Property(t => t.EMISSAO_PDCP).HasColumnName("EMISSAO_PDCP");
            //this.Property(t => t.CONDICIONAL_PDCP).HasColumnName("CONDICIONAL_PDCP");
            //this.Property(t => t.BICMS_PDCP).HasColumnName("BICMS_PDCP");
            //this.Property(t => t.ICMS_PDCP).HasColumnName("ICMS_PDCP");
            //this.Property(t => t.BICMSST_PDCP).HasColumnName("BICMSST_PDCP");
            //this.Property(t => t.ICMSST_PDCP).HasColumnName("ICMSST_PDCP");
            //this.Property(t => t.IPI_PDCP).HasColumnName("IPI_PDCP");
            //this.Property(t => t.IPIST_PDCP).HasColumnName("IPIST_PDCP");
            //this.Property(t => t.PIS_PDCP).HasColumnName("PIS_PDCP");
            //this.Property(t => t.PISST_PDCP).HasColumnName("PISST_PDCP");
            //this.Property(t => t.COFINS_PDCP).HasColumnName("COFINS_PDCP");
            //this.Property(t => t.COFINSST_PDCP).HasColumnName("COFINSST_PDCP");
            //this.Property(t => t.VLRMERC_PDCP).HasColumnName("VLRMERC_PDCP");
            //this.Property(t => t.FRETE_PDCP).HasColumnName("FRETE_PDCP");
            //this.Property(t => t.SEGURO_PDCP).HasColumnName("SEGURO_PDCP");
            //this.Property(t => t.DESCONTO_PDCP).HasColumnName("DESCONTO_PDCP");
            //this.Property(t => t.DESP_ACESSORIA_PDCP).HasColumnName("DESP_ACESSORIA_PDCP");
            //this.Property(t => t.VLRTOT_PDCP).HasColumnName("VLRTOT_PDCP");
            //this.Property(t => t.OBS_PDCP).HasColumnName("OBS_PDCP");
            //this.Property(t => t.TIPO_PDCP).HasColumnName("TIPO_PDCP");
            //this.Property(t => t.STATUS_PDCP).HasColumnName("STATUS_PDCP");
            //this.Property(t => t.ID_ENPS_FORN_PDCP).HasColumnName("ID_ENPS_FORN_PDCP");
            //this.Property(t => t.ID_ENPS_ENT_PDCP).HasColumnName("ID_ENPS_ENT_PDCP");
            //this.Property(t => t.ID_ENPS_LOJA_PDCP).HasColumnName("ID_ENPS_LOJA_PDCP");
            //this.Property(t => t.ID_ENPS_RET_PDCP).HasColumnName("ID_ENPS_RET_PDCP");
            //this.Property(t => t.ID_ENPS_TRAN_PDCP).HasColumnName("ID_ENPS_TRAN_PDCP");
            //this.Property(t => t.II_PDCP).HasColumnName("II_PDCP");
            //this.Property(t => t.BIRRF_PDCP).HasColumnName("BIRRF_PDCP");
            //this.Property(t => t.IRRF_PDCP).HasColumnName("IRRF_PDCP");
            //this.Property(t => t.BPREV_PDCP).HasColumnName("BPREV_PDCP");
            //this.Property(t => t.PREV_PDCP).HasColumnName("PREV_PDCP");
            //this.Property(t => t.RIPI_PDCP).HasColumnName("RIPI_PDCP");
            //this.Property(t => t.RPIS_PDCP).HasColumnName("RPIS_PDCP");
            //this.Property(t => t.RCOFINS_PDCP).HasColumnName("RCOFINS_PDCP");
            //this.Property(t => t.RCSLL_PDCP).HasColumnName("RCSLL_PDCP");
            //this.Property(t => t.MODFRETE_PDCP).HasColumnName("MODFRETE_PDCP");
            //this.Property(t => t.BICMS_TRAN_PDCP).HasColumnName("BICMS_TRAN_PDCP");
            //this.Property(t => t.PICMS_TRAN_PDCP).HasColumnName("PICMS_TRAN_PDCP");
            //this.Property(t => t.ICMS_TRAN_PDCP).HasColumnName("ICMS_TRAN_PDCP");
            //this.Property(t => t.VALOR_TRAN_PDCP).HasColumnName("VALOR_TRAN_PDCP");
            //this.Property(t => t.PESOLIQ_PDCP).HasColumnName("PESOLIQ_PDCP");
            //this.Property(t => t.PESOBRT_PDCP).HasColumnName("PESOBRT_PDCP");

            //// Relationships
            //this.HasOptional(t => t.CONDICOES_PAGAMENTO)
            //    .WithMany(t => t.PEDIDOS_COMPRA)
            //    .HasForeignKey(d => d.CondicaoPagamentoId);
				
            //this.HasOptional(t => t.ENDERECOS_PESSOA)
            //    .WithMany(t => t.PEDIDOS_COMPRA)
            //    .HasForeignKey(d => d.ID_ENPS_ENT_PDCP);
				
            //this.HasOptional(t => t.ENDERECOS_PESSOA1)
            //    .WithMany(t => t.PEDIDOS_COMPRA1)
            //    .HasForeignKey(d => d.ID_ENPS_FORN_PDCP);
				
            //this.HasOptional(t => t.ENDERECOS_PESSOA2)
            //    .WithMany(t => t.PEDIDOS_COMPRA2)
            //    .HasForeignKey(d => d.ID_ENPS_LOJA_PDCP);
				
            //this.HasOptional(t => t.ENDERECOS_PESSOA3)
            //    .WithMany(t => t.PEDIDOS_COMPRA3)
            //    .HasForeignKey(d => d.ID_ENPS_RET_PDCP);
				
            //this.HasOptional(t => t.ENDERECOS_PESSOA4)
            //    .WithMany(t => t.PEDIDOS_COMPRA4)
            //    .HasForeignKey(d => d.ID_ENPS_TRAN_PDCP);
				
            //this.HasOptional(t => t.FORNECEDOR)
            //    .WithMany(t => t.PEDIDOS_COMPRA)
            //    .HasForeignKey(d => d.FornecedorId);
				
            //this.HasOptional(t => t.Loja)
            //    .WithMany(t => t.PEDIDOS_COMPRA)
            //    .HasForeignKey(d => d.LojaId);
				
            //this.HasOptional(t => t.Operador)
            //    .WithMany(t => t.PEDIDOS_COMPRA)
            //    .HasForeignKey(d => d.OperadorId);
				
            ////this.HasOptional(t => t.VENDA)
            ////    .WithMany(t => t.PEDIDOS_COMPRA)
            ////    .HasForeignKey(d => d.ID_VDA);
				
            //this.HasOptional(t => t.TRANSPORTADOR)
            //    .WithMany(t => t.PEDIDOS_COMPRA)
            //    .HasForeignKey(d => d.TransportadorId);
				
            //this.HasOptional(t => t.VEICULO)
            //    .WithMany(t => t.PEDIDOS_COMPRA)
            //    .HasForeignKey(d => d.ID_VEIC);
				
            //this.HasOptional(t => t.VENDEDOR)
            //    .WithMany(t => t.PEDIDOS_COMPRA)
            //    .HasForeignKey(d => d.VendedorId);
				
		}
	}
}

