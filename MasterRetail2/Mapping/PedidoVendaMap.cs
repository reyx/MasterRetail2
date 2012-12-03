using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Entities;

namespace Rcky.MasterRetail2.Mapping
{
	public class PedidoVendaMap : EntityTypeConfiguration<PedidoVenda>
	{
        public PedidoVendaMap()
		{
			// Primary Key
			this.HasKey(t => t.PedidoVendaId);

			// Properties
            //this.Property(t => t.CONDICIONAL_PDVD)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.TIPO_PDVD)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.STATUS_PDVD)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.MODFRETE_PDVD)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //// Table & Column Mappings
            //this.ToTable("PEDIDOS_VENDA");
            //this.Property(t => t.ID_PDVD).HasColumnName("ID_PDVD");
            //this.Property(t => t.NUMERO_PDVD).HasColumnName("NUMERO_PDVD");
            //this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            //this.Property(t => t.ClienteId).HasColumnName("COD_CLI");
            //this.Property(t => t.DESC_NTOP_PDVD).HasColumnName("DESC_NTOP_PDVD");
            //this.Property(t => t.DESC_NTOP_TRAN_PDVD).HasColumnName("DESC_NTOP_TRAN_PDVD");
            //this.Property(t => t.OperadorId).HasColumnName("ID_OPER");
            //this.Property(t => t.ID_VDA).HasColumnName("ID_VDA");
            //this.Property(t => t.CondicaoPagamentoId).HasColumnName("COD_CDPG");
            //this.Property(t => t.VendedorId).HasColumnName("COD_VEND");
            //this.Property(t => t.TransportadorId).HasColumnName("COD_TRAN");
            //this.Property(t => t.ID_VEIC).HasColumnName("ID_VEIC");
            //this.Property(t => t.DATA_PDVD).HasColumnName("DATA_PDVD");
            //this.Property(t => t.EMISSAO_PDVD).HasColumnName("EMISSAO_PDVD");
            //this.Property(t => t.CONDICIONAL_PDVD).HasColumnName("CONDICIONAL_PDVD");
            //this.Property(t => t.BICMS_PDVD).HasColumnName("BICMS_PDVD");
            //this.Property(t => t.ICMS_PDVD).HasColumnName("ICMS_PDVD");
            //this.Property(t => t.BICMSST_PDVD).HasColumnName("BICMSST_PDVD");
            //this.Property(t => t.ICMSST_PDVD).HasColumnName("ICMSST_PDVD");
            //this.Property(t => t.IPI_PDVD).HasColumnName("IPI_PDVD");
            //this.Property(t => t.IPIST_PDVD).HasColumnName("IPIST_PDVD");
            //this.Property(t => t.PIS_PDVD).HasColumnName("PIS_PDVD");
            //this.Property(t => t.PISST_PDVD).HasColumnName("PISST_PDVD");
            //this.Property(t => t.COFINS_PDVD).HasColumnName("COFINS_PDVD");
            //this.Property(t => t.COFINSST_PDVD).HasColumnName("COFINSST_PDVD");
            //this.Property(t => t.VLRMERC_PDVD).HasColumnName("VLRMERC_PDVD");
            //this.Property(t => t.FRETE_PDVD).HasColumnName("FRETE_PDVD");
            //this.Property(t => t.SEGURO_PDVD).HasColumnName("SEGURO_PDVD");
            //this.Property(t => t.DESCONTO_PDVD).HasColumnName("DESCONTO_PDVD");
            //this.Property(t => t.DESP_ACESSORIA_PDVD).HasColumnName("DESP_ACESSORIA_PDVD");
            //this.Property(t => t.VLRTOT_PDVD).HasColumnName("VLRTOT_PDVD");
            //this.Property(t => t.OBS_PDVD).HasColumnName("OBS_PDVD");
            //this.Property(t => t.TIPO_PDVD).HasColumnName("TIPO_PDVD");
            //this.Property(t => t.STATUS_PDVD).HasColumnName("STATUS_PDVD");
            //this.Property(t => t.ID_ENPS_CLI_PDVD).HasColumnName("ID_ENPS_CLI_PDVD");
            //this.Property(t => t.ID_ENPS_ENT_PDVD).HasColumnName("ID_ENPS_ENT_PDVD");
            //this.Property(t => t.ID_ENPS_LOJA_PDVD).HasColumnName("ID_ENPS_LOJA_PDVD");
            //this.Property(t => t.ID_ENPS_RET_PDVD).HasColumnName("ID_ENPS_RET_PDVD");
            //this.Property(t => t.ID_ENPS_TRAN_PDVD).HasColumnName("ID_ENPS_TRAN_PDVD");
            //this.Property(t => t.II_PDVD).HasColumnName("II_PDVD");
            //this.Property(t => t.BIRRF_PDVD).HasColumnName("BIRRF_PDVD");
            //this.Property(t => t.IRRF_PDVD).HasColumnName("IRRF_PDVD");
            //this.Property(t => t.BPREV_PDVD).HasColumnName("BPREV_PDVD");
            //this.Property(t => t.PREV_PDVD).HasColumnName("PREV_PDVD");
            //this.Property(t => t.RIPI_PDVD).HasColumnName("RIPI_PDVD");
            //this.Property(t => t.RPIS_PDVD).HasColumnName("RPIS_PDVD");
            //this.Property(t => t.RCOFINS_PDVD).HasColumnName("RCOFINS_PDVD");
            //this.Property(t => t.RCSLL_PDVD).HasColumnName("RCSLL_PDVD");
            //this.Property(t => t.MODFRETE_PDVD).HasColumnName("MODFRETE_PDVD");
            //this.Property(t => t.BICMS_TRAN_PDVD).HasColumnName("BICMS_TRAN_PDVD");
            //this.Property(t => t.PICMS_TRAN_PDVD).HasColumnName("PICMS_TRAN_PDVD");
            //this.Property(t => t.ICMS_TRAN_PDVD).HasColumnName("ICMS_TRAN_PDVD");
            //this.Property(t => t.VALOR_TRAN_PDVD).HasColumnName("VALOR_TRAN_PDVD");
            //this.Property(t => t.PESOLIQ_PDVD).HasColumnName("PESOLIQ_PDVD");
            //this.Property(t => t.PESOBRT_PDVD).HasColumnName("PESOBRT_PDVD");

            //// Relationships
            //this.HasOptional(t => t.Cliente)
            //    .WithMany(t => t.PedidosVenda)
            //    .HasForeignKey(d => d.ClienteId);
				
            //this.HasOptional(t => t.CONDICOES_PAGAMENTO)
            //    .WithMany(t => t.PEDIDOS_VENDA)
            //    .HasForeignKey(d => d.CondicaoPagamentoId);
				
            //this.HasOptional(t => t.ENDERECO_CLIENTE)
            //    .WithMany(t => t.PEDIDOS_VENDA)
            //    .HasForeignKey(d => d.ID_ENPS_CLI_PDVD);
				
            //this.HasOptional(t => t.ENDERECO_ENTREGA)
            //    .WithMany(t => t.PEDIDOS_VENDA1)
            //    .HasForeignKey(d => d.ID_ENPS_ENT_PDVD);
				
            //this.HasOptional(t => t.ENDERECO_LOJA)
            //    .WithMany(t => t.PEDIDOS_VENDA2)
            //    .HasForeignKey(d => d.ID_ENPS_LOJA_PDVD);
				
            //this.HasOptional(t => t.ENDERECO_RETIRADA)
            //    .WithMany(t => t.PEDIDOS_VENDA3)
            //    .HasForeignKey(d => d.ID_ENPS_RET_PDVD);
				
            //this.HasOptional(t => t.ENDERECO_TRANSPORTADOR)
            //    .WithMany(t => t.PEDIDOS_VENDA4)
            //    .HasForeignKey(d => d.ID_ENPS_TRAN_PDVD);
				
            //this.HasOptional(t => t.Loja)
            //    .WithMany(t => t.PEDIDOS_VENDA)
            //    .HasForeignKey(d => d.LojaId);
				
            //this.HasOptional(t => t.Operador)
            //    .WithMany(t => t.PEDIDOS_VENDA)
            //    .HasForeignKey(d => d.OperadorId);
				
            //this.HasOptional(t => t.TRANSPORTADOR)
            //    .WithMany(t => t.PEDIDOS_VENDA)
            //    .HasForeignKey(d => d.TransportadorId);
				
            //this.HasOptional(t => t.VEICULO)
            //    .WithMany(t => t.PEDIDOS_VENDA)
            //    .HasForeignKey(d => d.ID_VEIC);
				
            //this.HasOptional(t => t.VENDA)
            //    .WithMany(t => t.PEDIDOS_VENDA)
            //    .HasForeignKey(d => d.ID_VDA);
				
            //this.HasOptional(t => t.VENDEDOR)
            //    .WithMany(t => t.PEDIDOS_VENDA)
            //    .HasForeignKey(d => d.VendedorId);
				
		}
	}
}

