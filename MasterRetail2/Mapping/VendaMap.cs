using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
    public class VendaMap : EntityTypeConfiguration<Venda>
	{
        public VendaMap()
		{
			// Primary Key
			this.HasKey(t => t.VendaId);

			// Properties
            //this.Property(t => t.NUMERO_VDA)
            //    .HasMaxLength(14);
				
            //this.Property(t => t.TIPOOPER_VDA)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.MODFRETE_VDA)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.STATUS_VDA)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //// Table & Column Mappings
            //this.ToTable("VENDAS");
            //this.Property(t => t.VendaId).HasColumnName("ID_VDA");
            //this.Property(t => t.NUMERO_VDA).HasColumnName("NUMERO_VDA");
            //this.Property(t => t.NOTA_VDA).HasColumnName("NOTA_VDA");
            //this.Property(t => t.TIPOOPER_VDA).HasColumnName("TIPOOPER_VDA");
            //this.Property(t => t.CondicaoPagamentoId).HasColumnName("COD_CDPG");
            //this.Property(t => t.ClienteId).HasColumnName("COD_CLI");
            //this.Property(t => t.COD_ENTR).HasColumnName("COD_ENTR");
            //this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            //this.Property(t => t.VendedorId).HasColumnName("COD_VEND");
            //this.Property(t => t.ID_MVPD).HasColumnName("ID_MVPD");
            //this.Property(t => t.CFOP_NTOP).HasColumnName("CFOP_NTOP");
            //this.Property(t => t.OperadorId).HasColumnName("ID_OPER");
            //this.Property(t => t.OperadorId_AUTO).HasColumnName("ID_OPER_AUTO");
            //this.Property(t => t.ID_ENPS_LOJA_VDA).HasColumnName("ID_ENPS_LOJA_VDA");
            //this.Property(t => t.ID_ENPS_CLI_VDA).HasColumnName("ID_ENPS_CLI_VDA");
            //this.Property(t => t.ID_ENPS_TRAN_VDA).HasColumnName("ID_ENPS_TRAN_VDA");
            //this.Property(t => t.ID_ENPS_ENT_VDA).HasColumnName("ID_ENPS_ENT_VDA");
            //this.Property(t => t.ID_ENPS_RET_VDA).HasColumnName("ID_ENPS_RET_VDA");
            //this.Property(t => t.ID_VOL).HasColumnName("ID_VOL");
            //this.Property(t => t.DATA_VDA).HasColumnName("DATA_VDA");
            //this.Property(t => t.VLRMERC_VDA).HasColumnName("VLRMERC_VDA");
            //this.Property(t => t.DESCONTO_VDA).HasColumnName("DESCONTO_VDA");
            //this.Property(t => t.ACRESCIMO_VDA).HasColumnName("ACRESCIMO_VDA");
            //this.Property(t => t.TXENTR_VDA).HasColumnName("TXENTR_VDA");
            //this.Property(t => t.SERVICO_VDA).HasColumnName("SERVICO_VDA");
            //this.Property(t => t.MODFRETE_VDA).HasColumnName("MODFRETE_VDA");
            //this.Property(t => t.PESSOAS_VDA).HasColumnName("PESSOAS_VDA");
            //this.Property(t => t.COMANDA_VDA).HasColumnName("COMANDA_VDA");
            //this.Property(t => t.STATUS_VDA).HasColumnName("STATUS_VDA");
            //this.Property(t => t.FRETE_VDA).HasColumnName("FRETE_VDA");
            //this.Property(t => t.SEGURO_VDA).HasColumnName("SEGURO_VDA");
            //this.Property(t => t.BICMS_VDA).HasColumnName("BICMS_VDA");
            //this.Property(t => t.ICMS_VDA).HasColumnName("ICMS_VDA");
            //this.Property(t => t.BICMSST_VDA).HasColumnName("BICMSST_VDA");
            //this.Property(t => t.ICMSST_VDA).HasColumnName("ICMSST_VDA");
            //this.Property(t => t.PIS_VDA).HasColumnName("PIS_VDA");
            //this.Property(t => t.COFINS_VDA).HasColumnName("COFINS_VDA");
            //this.Property(t => t.IPI_VDA).HasColumnName("IPI_VDA");
            //this.Property(t => t.BISSQN_VDA).HasColumnName("BISSQN_VDA");
            //this.Property(t => t.ISSQN_VDA).HasColumnName("ISSQN_VDA");
            //this.Property(t => t.II_VDA).HasColumnName("II_VDA");
            //this.Property(t => t.VLRTOT_VDA).HasColumnName("VLRTOT_VDA");
            //this.Property(t => t.BIRRF_VDA).HasColumnName("BIRRF_VDA");
            //this.Property(t => t.BPREV_VDA).HasColumnName("BPREV_VDA");
            //this.Property(t => t.IRRF_VDA).HasColumnName("IRRF_VDA");
            //this.Property(t => t.RCOFINS_VDA).HasColumnName("RCOFINS_VDA");
            //this.Property(t => t.RCSLL_VDA).HasColumnName("RCSLL_VDA");
            //this.Property(t => t.RPIS_VDA).HasColumnName("RPIS_VDA");
            //this.Property(t => t.RPREV_VDA).HasColumnName("RPREV_VDA");
            //this.Property(t => t.DESP_ACESSORIA_VDA).HasColumnName("DESP_ACESSORIA_VDA");
            //this.Property(t => t.TransportadorId).HasColumnName("COD_TRAN");
            //this.Property(t => t.CFOP_NTOP_TRAN_VDA).HasColumnName("CFOP_NTOP_TRAN_VDA");
            //this.Property(t => t.ICMS_TRAN_VDA).HasColumnName("ICMS_TRAN_VDA");
            //this.Property(t => t.BASECALC_TRAN_VDA).HasColumnName("BASECALC_TRAN_VDA");
            //this.Property(t => t.ALIQ_TRAN_VDA).HasColumnName("ALIQ_TRAN_VDA");
            //this.Property(t => t.VALOR_TRAN_VDA).HasColumnName("VALOR_TRAN_VDA");
            //this.Property(t => t.PESOLIQ_VDA).HasColumnName("PESOLIQ_VDA");
            //this.Property(t => t.PESOBRT_VDA).HasColumnName("PESOBRT_VDA");
            //this.Property(t => t.PREV_VDA).HasColumnName("PREV_VDA");
            //this.Property(t => t.PISRETIDO_VDA).HasColumnName("PISRETIDO_VDA");
            //this.Property(t => t.COFINSRETIDO_VDA).HasColumnName("COFINSRETIDO_VDA");
            //this.Property(t => t.CSLL_VDA).HasColumnName("CSLL_VDA");
            //this.Property(t => t.PISISSQN_VDA).HasColumnName("PISISSQN_VDA");
            //this.Property(t => t.COFINSISSQN_VDA).HasColumnName("COFINSISSQN_VDA");
            //this.Property(t => t.VLRTOTISSQN_VDA).HasColumnName("VLRTOTISSQN_VDA");

            //// Relationships
            //this.HasOptional(t => t.Cliente)
            //    .WithMany(t => t.Vendas)
            //    .HasForeignKey(d => d.ClienteId);
				
            //this.HasOptional(t => t.CondicaoPagamento)
            //    .WithMany(t => t.VENDAS)
            //    .HasForeignKey(d => d.CondicaoPagamentoId);
				
            //this.HasOptional(t => t.EnderecoCliente)
            //    .WithMany(t => t.VENDAS)
            //    .HasForeignKey(d => d.ID_ENPS_CLI_VDA);
				
            //this.HasOptional(t => t.EnderecoEntrega)
            //    .WithMany(t => t.VENDAS1)
            //    .HasForeignKey(d => d.ID_ENPS_ENT_VDA);
				
            //this.HasOptional(t => t.EnderecoLoja)
            //    .WithMany(t => t.VENDAS2)
            //    .HasForeignKey(d => d.ID_ENPS_LOJA_VDA);
				
            //this.HasOptional(t => t.EnderecoRetirada)
            //    .WithMany(t => t.VENDAS3)
            //    .HasForeignKey(d => d.ID_ENPS_RET_VDA);
				
            //this.HasOptional(t => t.EnderecoTransportador)
            //    .WithMany(t => t.VENDAS4)
            //    .HasForeignKey(d => d.ID_ENPS_TRAN_VDA);
				
            //this.HasOptional(t => t.Entregador)
            //    .WithMany(t => t.VENDAS)
            //    .HasForeignKey(d => d.COD_ENTR);
				
            //this.HasOptional(t => t.Loja)
            //    .WithMany(t => t.Vendas)
            //    .HasForeignKey(d => d.LojaId);
				
            //this.HasOptional(t => t.MOVIMENTOS_PDV)
            //    .WithMany(t => t.VENDAS)
            //    .HasForeignKey(d => d.ID_MVPD);
				
            //this.HasOptional(t => t.Operador_AUTORIZADOR)
            //    .WithMany(t => t.VENDAS)
            //    .HasForeignKey(d => d.OperadorId_AUTO);
				
            //this.HasOptional(t => t.Operador)
            //    .WithMany(t => t.VENDAS1)
            //    .HasForeignKey(d => d.OperadorId);
				
            //this.HasOptional(t => t.TRANSPORTADOR)
            //    .WithMany(t => t.VENDAS)
            //    .HasForeignKey(d => d.TransportadorId);
				
            //this.HasOptional(t => t.VENDEDOR)
            //    .WithMany(t => t.VENDAS)
            //    .HasForeignKey(d => d.VendedorId);
				
		}
	}
}